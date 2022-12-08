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
    public static class SobelFilter2
    {

        public static Bitmap ConvolutionFilter(this Bitmap sourceBitmap, double[,] xFilterMatrix, double[,] yFilterMatrix, bool grayscale = false)
        {
            BitmapData sourceData = sourceBitmap.LockBits(new Rectangle(0, 0, sourceBitmap.Width, sourceBitmap.Height),
                                                            ImageLockMode.ReadOnly,
                                                            PixelFormat.Format32bppArgb);

            byte[] pixelBuffer = new byte[sourceData.Stride * sourceData.Height];
            byte[] resultBuffer = new byte[sourceData.Stride * sourceData.Height];

            Marshal.Copy(sourceData.Scan0, pixelBuffer, 0, pixelBuffer.Length);
            sourceBitmap.UnlockBits(sourceData);

            if (grayscale)
            {
                for (int k = 0; k < pixelBuffer.Length; k += 4)
                {
                    float rgb = pixelBuffer[k] * 0.11f;
                    rgb += pixelBuffer[k + 1] * 0.59f;
                    rgb += pixelBuffer[k + 2] * 0.3f;

                    pixelBuffer[k] = (byte)rgb;
                    pixelBuffer[k + 1] = pixelBuffer[k];
                    pixelBuffer[k + 2] = pixelBuffer[k];
                    pixelBuffer[k + 3] = 255;
                }
            }

            int filterWidth = xFilterMatrix.GetLength(1);
            int filterOffset = (filterWidth - 1) / 2;
            int offsetY = 0;
            int bitmapHeight = sourceBitmap.Height;
            int bitmapWidth = sourceBitmap.Width;
            Parallel.For(offsetY, bitmapHeight, offsetYY =>
            {
                for (int offsetX = 0; offsetX < bitmapWidth; offsetX++)
                {
                    double blueX = 0, greenX = 0, redX = 0;
                    double blueY = 0, greenY = 0, redY = 0;

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

                            blueX += pixelBuffer[calcOffset] * xFilterMatrix[filterY + filterOffset, filterX + filterOffset];
                            greenX += pixelBuffer[calcOffset + 1] * xFilterMatrix[filterY + filterOffset, filterX + filterOffset];
                            redX += pixelBuffer[calcOffset + 2] * xFilterMatrix[filterY + filterOffset, filterX + filterOffset];

                            blueY += pixelBuffer[calcOffset] * yFilterMatrix[filterY + filterOffset, filterX + filterOffset];
                            greenY += pixelBuffer[calcOffset + 1] * yFilterMatrix[filterY + filterOffset, filterX + filterOffset];
                            redY += pixelBuffer[calcOffset + 2] * yFilterMatrix[filterY + filterOffset, filterX + filterOffset];
                        }
                    }

                    double blueTotal = Math.Sqrt((blueX * blueX) + (blueY * blueY));
                    double greenTotal = Math.Sqrt((greenX * greenX) + (greenY * greenY));
                    double redTotal = Math.Sqrt((redX * redX) + (redY * redY));

                    if (blueTotal > 255)
                    {
                        blueTotal = 255;
                    }
                    else if (blueTotal < 0)
                    {
                        blueTotal = 0;
                    }

                    if (greenTotal > 255)
                    {
                        greenTotal = 255;
                    }
                    else if (greenTotal < 0)
                    {
                        greenTotal = 0;
                    }

                    if (redTotal > 255)
                    {
                        redTotal = 255;
                    }
                    else if (redTotal < 0)
                    {
                        redTotal = 0;
                    }

                    resultBuffer[byteOffset] = (byte)(blueTotal);
                    resultBuffer[byteOffset + 1] = (byte)(greenTotal);
                    resultBuffer[byteOffset + 2] = (byte)(redTotal);
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

        public static Bitmap Process(Bitmap source, bool grayscale = true)
        {
            Bitmap resultBitmap = ConvolutionFilter(source, Matrix.Sobel3x3Horizontal, Matrix.Sobel3x3Vertical, grayscale);

            return resultBitmap;

            
        }
    }
}
