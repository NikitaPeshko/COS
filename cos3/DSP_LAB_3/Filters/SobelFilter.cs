using System;
using System.Drawing;
using CGALabs;

namespace DSP_Lab_3.Filters
{
    public static class SobelFilter
    {
        private static readonly int[,] XSobel = new int[,]
        {
            {-1, 0, 1},
            {-2, 0, 2},
            {-1, 0, 1}
        };

        private static readonly int[,] YSobel = new int[,]
        {
            {1, 2, 1},
            {0, 0, 0},
            {-1, -2, -1}
        };

        public static Bitmap Process(FastBitmap source)
        {
            var result = new FastBitmap(source);

            var height = source.Height;
            var width = source.Width;

            var sourceBitsRedValues = new int[width, height];
            var sourceBitsGreenValues = new int[width, height];
            var sourceBitsBlueValues = new int[width, height];

            result.FillRgbValues(sourceBitsRedValues, sourceBitsGreenValues, sourceBitsBlueValues);

            for (var i = 1; i < source.Width - 1; i++)
            {
                for (var j = 1; j < source.Height - 1; j++)
                {
                    int newXR = 0, newYR = 0;
                    int newXG = 0, newYG = 0;
                    int newXB = 0, newYB = 0;

                    for (var wi = -1; wi < 2; wi++)
                    {
                        for (var hw = -1; hw < 2; hw++)
                        {
                            newXR += XSobel[wi + 1, hw + 1] * sourceBitsRedValues[i + hw, j + wi];
                            newYR += YSobel[wi + 1, hw + 1] * sourceBitsRedValues[i + hw, j + wi];

                            newXG += XSobel[wi + 1, hw + 1] * sourceBitsGreenValues[i + hw, j + wi];
                            newYG += YSobel[wi + 1, hw + 1] * sourceBitsGreenValues[i + hw, j + wi];

                            newXB += XSobel[wi + 1, hw + 1] * sourceBitsBlueValues[i + hw, j + wi];
                            newYB += YSobel[wi + 1, hw + 1] * sourceBitsBlueValues[i + hw, j + wi];
                        }
                    }

                    var R = Math.Sqrt(newXR * newXR + newYR * newYR);
                    var G = Math.Sqrt(newXG * newXG + newYG * newYG);
                    var B = Math.Sqrt(newXB * newXB + newYB * newYB);
                    var gray = (byte) (0.21 * R + 0.71 * G + 0.071 * B);
                    var clr = gray < 128 ? Color.Black : Color.White;
                    //Color clr = Color.FromArgb(gray, gray, gray);
                    //Color clr = Color.FromArgb((byte)R, (byte)G, (byte)B);

                    result.SetPixel(i, j, clr);
                }
            }

            return result.Bitmap;
        }
    }
}