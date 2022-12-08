using CGALabs;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DSP_Lab_3.Filters
{
    public static class BoxBlurFilter
    {
        public static Bitmap Process(Bitmap source, int size=3)
        {
            (double[,] Matrix, double NormalizationRate) tuple = GetBoxBlurMatrix(size);
            Bitmap resultBitmap = ConvolutionFilter(source, tuple.Matrix, tuple.NormalizationRate);


            return resultBitmap;
        }


        private static Bitmap ConvolutionFilter(Bitmap sourceBitmap, double[,] filterMatrix, double factor = 1, int bias = 0)
        {
            BitmapData sourceData = sourceBitmap.LockBits(new Rectangle(0, 0, sourceBitmap.Width, sourceBitmap.Height),
                                                            ImageLockMode.ReadOnly,
                                                            PixelFormat.Format32bppArgb);

            byte[] pixelBuffer = new byte[sourceData.Stride * sourceData.Height];
            byte[] resultBuffer = new byte[sourceData.Stride * sourceData.Height];

            Marshal.Copy(sourceData.Scan0, pixelBuffer, 0, pixelBuffer.Length);
            sourceBitmap.UnlockBits(sourceData);

            int filterWidth = filterMatrix.GetLength(1);
            int filterOffset = (filterWidth - 1) / 2;
            int offsetY = 0;
            int bitmapHeight = sourceBitmap.Height;
            int bitmapWidth = sourceBitmap.Width;
            Parallel.For(offsetY, bitmapHeight, offsetYY =>
            {
                for (int offsetX = 0; offsetX < bitmapWidth; offsetX++)
                {
                    double blue = 0;
                    double green = 0;
                    double red = 0;
                    int byteOffset = offsetYY * sourceData.Stride + offsetX * 4;
                    for (int filterY = -filterOffset; filterY <= filterOffset; filterY++)
                    {
                        for (int filterX = -filterOffset; filterX <= filterOffset; filterX++)
                        {
                            int calcOffset = byteOffset + (filterX * 4) + (filterY * sourceData.Stride);
                            if (filterY + offsetYY < 0)
                            {
                                calcOffset += filterOffset * sourceData.Stride;
                            }
                            if (filterY + offsetYY >= bitmapHeight)
                            {
                                calcOffset -= filterOffset * sourceData.Stride;
                            }

                            if (filterX + offsetX < 0)
                            {
                                calcOffset += filterOffset * 4;
                            }
                            if (filterX + offsetX >= bitmapWidth)
                            {
                                calcOffset -= filterOffset * 4;
                            }

                            blue += pixelBuffer[calcOffset] * filterMatrix[filterY + filterOffset, filterX + filterOffset];
                            green += pixelBuffer[calcOffset + 1] * filterMatrix[filterY + filterOffset, filterX + filterOffset];
                            red += pixelBuffer[calcOffset + 2] * filterMatrix[filterY + filterOffset, filterX + filterOffset];
                        }
                    }

                    (byte R, byte G, byte B) = NormalizeRgb(red, green, blue, factor, bias);

                    resultBuffer[byteOffset] = B;
                    resultBuffer[byteOffset + 1] = G;
                    resultBuffer[byteOffset + 2] = R;
                    resultBuffer[byteOffset + 3] = 255;
                }
            });

            Bitmap resultBitmap = new Bitmap(bitmapWidth, bitmapHeight);
            BitmapData resultData = resultBitmap.LockBits(new Rectangle(0, 0, resultBitmap.Width, resultBitmap.Height),
                                                            ImageLockMode.WriteOnly,
                                                            PixelFormat.Format32bppArgb);

            Marshal.Copy(resultBuffer, 0, resultData.Scan0, resultBuffer.Length);
            resultBitmap.UnlockBits(resultData);

            return resultBitmap;
        }

        private static (byte r, byte g, byte b) NormalizeRgb(double red, double green, double blue, double factor, int bias)
        {
            red = factor * red + bias;
            green = factor * green + bias;
            blue = factor * blue + bias;

            if (red > 255)
            {
                red = 255;
            }
            else if (red < 0)
            {
                red = 0;
            }

            if (green > 255)
            {
                green = 255;
            }
            else if (green < 0)
            {
                green = 0;
            }

            if (blue > 255)
            {
                blue = 255;
            }
            else if (blue < 0)
            {
                blue = 0;
            }

            return ((byte)red, (byte)green, (byte)blue);
        }
        public static (double[,], double) GetBoxBlurMatrix(int size)
        {
            double[,] matrix = new double[size, size];
            int offset = (size - 1) / 2;
            double sum = 0;
            for (int y = -offset; y <= offset; y++)
            {
                for (int x = -offset; x <= offset; x++)
                {
                    matrix[y + offset, x + offset] = 1;
                    sum += matrix[y + offset, x + offset];
                }
            }

            sum = 1 / sum;
            return (matrix, sum);
        }


    }
}
