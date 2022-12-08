using System;
using System.IO;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Microsoft.Win32;

namespace Lab4.WpfApp;

/// <summary>
///     Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow() => InitializeComponent();

    public ImageData? OriginalImageData { get; set; }
    public ImageData? FragmentImageData { get; set; }
    public BitmapSource? OriginalBitmapSource { get; set; }
    public WriteableBitmap? AffectedBitmapSource { get; set; }
    public WriteableBitmap? ResultBitmapSource { get; set; }

    private BitmapSource? ReadImage()
    {
        OpenFileDialog openFileDialog = new() { Filter = "Image (*.jpg;*.jpeg)|*.jpg;*.jpeg" };
        if (openFileDialog.ShowDialog() == true)
        {
            MemoryStream memoryStream = new();

            using (FileStream imageStreamSource =
                   new(openFileDialog.FileName, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                imageStreamSource.CopyTo(memoryStream);
            }

            memoryStream.Seek(0, SeekOrigin.Begin);

            var ext = Path.GetExtension(openFileDialog.FileName);

            if (ext == ".jpg" || ext == ".jpeg")
            {
                return BitmapDecoder.Create(memoryStream, BitmapCreateOptions.PreservePixelFormat,
                    BitmapCacheOption.Default).Frames[0];
            }
        }

        return null;
    }

    private void OpenFileMenuItem_OnClick(object sender, RoutedEventArgs e)
    {
        if (ReadImage() is { } bitmapSource)
        {
            var width = bitmapSource.PixelWidth;
            var height = bitmapSource.PixelHeight;
            var bytesPerPixel = bitmapSource.Format.BitsPerPixel / 8;

            var pixels = new byte[width * height * bytesPerPixel];
            bitmapSource.CopyPixels(pixels, width * bytesPerPixel, 0);

            OriginalImageData = new ImageData(pixels, width, height);

            AffectedBitmapSource = new WriteableBitmap(bitmapSource);
            OriginalBitmapSource = new WriteableBitmap(bitmapSource);
            OriginalImage.Source = AffectedBitmapSource;

            var fragmentHeight = Math.Min(200, height / 5);
            var fragmentWidth = Math.Min(200, width / 5);
            if (fragmentHeight % 2 == 0)
            {
                fragmentHeight++;
            }

            if (fragmentWidth % 2 == 0)
            {
                fragmentWidth++;
            }

            var fragmentX = RandomNumberGenerator.GetInt32(0, width - fragmentWidth);
            var fragmentY = RandomNumberGenerator.GetInt32(0, height - fragmentHeight);

            FragmentImageData = OriginalImageData.CropFragment(fragmentX, fragmentY, fragmentWidth, fragmentHeight);

            for (var i = 0; i < width; i++)
            {
                for (var j = 0; j < height; j++)
                {
                    if (i < fragmentX || i >= fragmentX + fragmentWidth || j < fragmentY ||
                        j >= fragmentY + fragmentHeight)
                    {
                        var offset = 3 * (i + j * width);

                        pixels[offset] = 0;
                        pixels[offset + 1] = 0;
                        pixels[offset + 2] = 0;
                    }
                }
            }

            WriteableBitmap wb = new(width, height, 96, 96, PixelFormats.Bgr24, null);
            Int32Rect rect = new(0, 0, width, height);
            wb.WritePixels(rect, pixels, width * 3, 0);
            FragmentImage.Source = wb;

            
        }
    }

    private void CrossCorrelation()
    {
        if (OriginalImageData is not null && FragmentImageData is not null && OriginalBitmapSource is not null)
        {
            AffectedBitmapSource = new WriteableBitmap(OriginalBitmapSource);

            var width = OriginalImageData.Width;
            var fragmentWidth = FragmentImageData.Width;
            var height = OriginalImageData.Height;
            var fragmentHeight = FragmentImageData.Height;
            var sum1 = new float[width, height];
            var sum2 = new float[width, height];
            var sum3 = new float[width, height];
            var results = new float[width, height];

            var avgOriginal = 0f;

            for (var x = 0; x < width; x++)
            {
                for (var y = 0; y < height; y++)
                {
                    avgOriginal += OriginalImageData.Colors[x, y].ToGrayscale() / (width * height);
                }
            }

            var avgFragment = 0f;

            for (var x = 0; x < fragmentWidth; x++)
            {
                for (var y = 0; y < fragmentHeight; y++)
                {
                    avgFragment += FragmentImageData.Colors[x, y].ToGrayscale() / (fragmentWidth * fragmentHeight);
                }
            }

            Parallel.For(0, width, i =>
            {
                for (var j = 0; j < height; j++)
                {
                    for (var m = -fragmentWidth / 2; m < fragmentWidth / 2; m++)
                    {
                        for (var n = -fragmentHeight / 2; n < fragmentHeight / 2; n++)
                        {
                            var offsetX = Math.Clamp(i + m, 0, width - 1);
                            var offsetY = Math.Clamp(j + n, 0, height - 1);


                            var colorOriginal1 = OriginalImageData.Colors[offsetX, offsetY].ToGrayscale();
                            var colorOriginal2 = OriginalImageData
                                .Colors[m + fragmentWidth / 2, n + fragmentHeight / 2].ToGrayscale();
                            var colorFragment = FragmentImageData
                                .Colors[m + fragmentWidth / 2, n + fragmentHeight / 2].ToGrayscale();

                            sum1[i, j] += (colorOriginal1 - avgOriginal) * (colorFragment - avgFragment);
                            sum2[i, j] += MathF.Pow(colorOriginal2 - avgOriginal, 2);
                            sum3[i, j] += MathF.Pow(colorFragment - avgFragment, 2);
                        }
                    }

                    results[i, j] = sum1[i, j] / MathF.Sqrt(sum2[i, j] * sum3[i, j]);
                }
            });

            var pixels = new byte[OriginalImageData.Width * OriginalImageData.Height];
            var (max, maxX, maxY) = (double.MinValue, 0, 0);

            for (var i = 0; i < OriginalImageData.Width; i++)
            {
                for (var j = 0; j < OriginalImageData.Height; j++)
                {
                    if (results[i, j] >= max)
                    {
                        max = results[i, j];
                        maxX = i;
                        maxY = j;
                    }
                }
            }

            for (var i = 0; i < OriginalImageData.Width; i++)
            {
                for (var j = 0; j < OriginalImageData.Height; j++)
                {
                    pixels[i + j * OriginalImageData.Width] = (byte)Math.Clamp(255f * results[i, j], 0, 255);
                }
            }

            ResultBitmapSource = new WriteableBitmap(OriginalImageData.Width, OriginalImageData.Height,
                96, 96, PixelFormats.Gray8, null
            );
            Int32Rect rect = new(0, 0, width, height);
            ResultBitmapSource.WritePixels(rect, pixels, width, 0);
            ResultImage.Source = ResultBitmapSource;

            var newPixels = new byte[3 * width * height];
            AffectedBitmapSource?.CopyPixels(rect, newPixels, 3 * width, 0);

            for (var i = maxX - fragmentHeight / 2; i < maxX + fragmentWidth / 2; i++)
            {
                if (i >= 0 && i < width)
                {
                    if (maxY - fragmentHeight / 2 >= 0)
                    {
                        newPixels[3 * (i + (maxY - fragmentHeight / 2) * width)] = 200;
                        newPixels[3 * (i + (maxY - fragmentHeight / 2) * width) + 1] = 200;
                        newPixels[3 * (i + (maxY - fragmentHeight / 2) * width) + 2] = 200;
                    }

                    if (maxY + fragmentHeight / 2 < height)
                    {
                        newPixels[3 * (i + (maxY + fragmentHeight / 2) * width)] = 200;
                        newPixels[3 * (i + (maxY + fragmentHeight / 2) * width) + 1] = 200;
                        newPixels[3 * (i + (maxY + fragmentHeight / 2) * width) + 2] = 200;
                    }
                }
            }

            for (var j = maxY - fragmentHeight / 2; j < maxY + fragmentHeight / 2; j++)
            {
                if (j >= 0 && j < height)
                {
                    if (maxX - fragmentWidth / 2 >= 0)
                    {
                        newPixels[3 * (maxX - fragmentWidth / 2 + j * width)] = 200;
                        newPixels[3 * (maxX - fragmentWidth / 2 + j * width) + 1] = 200;
                        newPixels[3 * (maxX - fragmentWidth / 2 + j * width) + 2] = 200;
                    }

                    if (maxY + fragmentHeight / 2 < height)
                    {
                        newPixels[3 * (maxX + fragmentWidth / 2 + j * width)] = 200;
                        newPixels[3 * (maxX + fragmentWidth / 2 + j * width) + 1] = 200;
                        newPixels[3 * (maxX + fragmentWidth / 2 + j * width) + 2] = 200;
                    }
                }
            }

            AffectedBitmapSource?.WritePixels(rect, newPixels, 3 * width, 0);
            OriginalImage.Source = AffectedBitmapSource;
        }
    }

    private void AutoCorrelation()
    {
        if (OriginalImageData is not null && OriginalBitmapSource is not null)
        {
            AffectedBitmapSource = new WriteableBitmap(OriginalBitmapSource);
            OriginalImage.Source = AffectedBitmapSource;

            var width = OriginalImageData.Width;
            var height = OriginalImageData.Height;
            var sum1 = new float[width, height];
            var results = new float[width, height];

            var avgOriginal = 0f;
            var sum2 = 0f;

            for (var x = 0; x < width; x++)
            {
                for (var y = 0; y < height; y++)
                {
                    avgOriginal += OriginalImageData.Colors[x, y].ToGrayscale() / (width * height);
                }
            }

            for (var x = 0; x < width; x++)
            {
                for (var y = 0; y < height; y++)
                {
                    var color = OriginalImageData.Colors[x, y].ToGrayscale();
                    sum2 += MathF.Pow(color - avgOriginal, 2);
                }
            }

            Parallel.For(0, width,
                new ParallelOptions { MaxDegreeOfParallelism = Environment.ProcessorCount - 1 },
                i =>
                {
                    for (var j = 0; j < height; j++)
                    {
                        for (var m = -width / 2; m < width / 2; m++)
                        {
                            for (var n = -height / 2; n < height / 2; n++)
                            {
                                var offsetX = Math.Clamp(i + m, 0, width - 1);
                                var offsetY = Math.Clamp(j + n, 0, height - 1);

                                var color1 = OriginalImageData.Colors[offsetX, offsetY].ToGrayscale();
                                var color2 = OriginalImageData.Colors[m + width / 2, n + height / 2].ToGrayscale();

                                sum1[i, j] += (color1 - avgOriginal) * (color2 - avgOriginal);
                            }
                        }

                        results[i, j] = sum1[i, j] / MathF.Sqrt(sum2 * sum2);
                    }
                }
            );

            var pixels = new byte[OriginalImageData.Width * OriginalImageData.Height];

            for (var i = 0; i < OriginalImageData.Width; i++)
            {
                for (var j = 0; j < OriginalImageData.Height; j++)
                {
                    pixels[i + j * OriginalImageData.Width] = (byte)Math.Clamp(255f * results[i, j], 0, 255);
                }
            }

            ResultBitmapSource = new WriteableBitmap(OriginalImageData.Width, OriginalImageData.Height,
                96, 96, PixelFormats.Gray8, null
            );
            Int32Rect rect = new(0, 0, width, height);
            ResultBitmapSource.WritePixels(rect, pixels, width, 0);
            ResultImage.Source = ResultBitmapSource;
        }
    }

    private void RadioButton_Checked(object sender, RoutedEventArgs e)
    {
        CrossCorrelation();
    }

    private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
    {
        AutoCorrelation();
    }
}
