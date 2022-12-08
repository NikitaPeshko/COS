using System;
using System.Collections.Concurrent;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace CGALabs
{
    public class FastBitmap : IDisposable
    {
        public Bitmap Bitmap { get; private set; }
        public int[] Bits { get; set; }
        public bool Disposed { get; private set; }
        public int Height { get; private set; }
        public int Width { get; private set; }
        public int BitmapSize => Bits.Length;

        private GCHandle BitsHandle { get; set; }


        public FastBitmap(int width, int height)
        {
            Width = width;
            Height = height;
            Bits = new int[width * height];
            BitsHandle = GCHandle.Alloc(Bits, GCHandleType.Pinned);
            Bitmap = new Bitmap(width, height, width * 4, PixelFormat.Format32bppPArgb,
                BitsHandle.AddrOfPinnedObject());
        }

        public FastBitmap(Bitmap bitmap)
        {
            Width = bitmap.Width;
            Height = bitmap.Height;
            Bits = new int[Width * Height];
            BitsHandle = GCHandle.Alloc(Bits, GCHandleType.Pinned);
            Bitmap = new Bitmap(Width, Height, Width * 4, PixelFormat.Format32bppPArgb,
                BitsHandle.AddrOfPinnedObject());
            var sourceData =
                bitmap.LockBits(new Rectangle(0, 0,
                        bitmap.Width, bitmap.Height),
                    ImageLockMode.ReadOnly,
                    PixelFormat.Format32bppArgb);
            Marshal.Copy(sourceData.Scan0, Bits, 0, Bits.Length);
            bitmap.UnlockBits(sourceData);
        }

        public FastBitmap(FastBitmap fastBitmap)
        {
            Width = fastBitmap.Width;
            Height = fastBitmap.Height;
            Bits = fastBitmap.Bits.Clone() as int[];
            BitsHandle = GCHandle.Alloc(Bits, GCHandleType.Pinned);
            Bitmap = new Bitmap(Width, Height, Width * 4, PixelFormat.Format32bppPArgb,
                BitsHandle.AddrOfPinnedObject());
        }

        public void FillRgbValues(int[,] redValues, int[,] greenValues, int[,] blueValues)
        {
            Parallel.ForEach(Partitioner.Create(0, Width), rangeX =>
            {
                for (var i = rangeX.Item1; i < rangeX.Item2; i++)
                {
                    Parallel.ForEach(Partitioner.Create(0, Height), rangeY =>
                    {
                        for (var j = rangeY.Item1; j < rangeY.Item2; j++)
                        {
                            redValues[i, j] = GetPixel(i, j).R;
                            greenValues[i, j] = GetPixel(i, j).G;
                            blueValues[i, j] = GetPixel(i, j).B;
                        }
                    });
                }
            });
        }

        public void Clear()
        {
            var backgroundColor = Color.White.ToArgb();
            for (var i = 0; i < Bits.Length; i++)
            {
                Bits[i] = backgroundColor;
            }
        }

        public void SetPixel(int index, Color color)
        {
            var col = color.ToArgb();
            Bits[index] = col;
        }

        public void SetPixel(int index, int color)
        {
            Bits[index] = color;
        }

        public void SetPixel(int x, int y, int color)
        {
            Bits[x + (y * Width)] = color;
        }

        public void SetPixel(int x, int y, Color color)
        {
            Bits[x + (y * Width)] = color.ToArgb();
        }

        public Color GetPixel(int x, int y)
        {
            var index = x + (y * Width);
            var color = Color.FromArgb(Bits[index]);
            return color;
        }

        public void Dispose()
        {
            BitsHandle.Free();
        }
    }
}