using System;
using System.Drawing;
using CGALabs;

namespace DSP_Lab_3.Filters
{
    public static class GaussianFilter
    {
        public static Bitmap Process(FastBitmap source, double sigma)
        {
            var result = new FastBitmap(source);

            var windowSize = (int)Math.Ceiling(10 * sigma)+1;
            if (windowSize % 2 == 0)
            {
                windowSize++;
            }


            var window = new double[windowSize, windowSize];
            var halfOfWindowSize = (windowSize - 1) / 2;

            InitializeWindow(window, windowSize, sigma);

            for (var i = 0; i < source.Width - 1; i++)
            {
                for (var j = 0; j < source.Height - 1; j++)
                {
                    double r = 0;
                    double g = 0;
                    double b = 0;

                    for (var k = -halfOfWindowSize; k <= halfOfWindowSize; k++)
                    {
                        for (var l = -halfOfWindowSize; l <= halfOfWindowSize; l++)
                        {
                            var retrievedPixel = source.GetPixel(CheckBound(i + l, source.Width - 1),
                                CheckBound(j + k, source.Height - 1));
                            r += window[k + halfOfWindowSize, l + halfOfWindowSize] * retrievedPixel.R;
                            g += window[k + halfOfWindowSize, l + halfOfWindowSize] * retrievedPixel.G;
                            b += window[k + halfOfWindowSize, l + halfOfWindowSize] * retrievedPixel.B;
                        }
                    }

                    r = CorrectColor(r);
                    g = CorrectColor(g);
                    b = CorrectColor(b);

                    result.SetPixel(i, j, Color.FromArgb((int)r, (int)g, (int)b));
                }
            }

            return result.Bitmap;
        }

        private static int CheckBound(int v, int v1)
        {
            if (v < 0)
            {
                return 0;
            }

            return v > v1 ? v1 : v;
        }

        private static double CorrectColor(double color)
        {
            color = color > 255 ? 255 : color;
            color = color < 0 ? 0 : color;
            return color;
        }

        private static void InitializeWindow(double[,] window, int windowSize, double sigma)
        {
            double kernelSum = 0;
            var foff = (windowSize - 1) / 2;
            var constant = 1d / (2 * Math.PI * sigma * sigma);
            for (var y = -foff; y <= foff; y++)
            {
                for (var x = -foff; x <= foff; x++)
                {
                    var distance = ((y * y) + (x * x)) / (2 * sigma * sigma);
                    window[y + foff, x + foff] = constant * Math.Exp(-distance);
                    kernelSum += window[y + foff, x + foff];
                }
            }

            for (var y = 0; y < windowSize; y++)
            {
                for (var x = 0; x < windowSize; x++)
                {
                    window[y, x] = window[y, x] * 1.0 / kernelSum;
                }
            }
        }
    }
}