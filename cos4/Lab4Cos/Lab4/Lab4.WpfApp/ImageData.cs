// Licensed to the.NET Foundation under one or more agreements.
// The.NET Foundation licenses this file to you under the MIT license.

namespace Lab4.WpfApp;

public class ImageData
{
    public ImageData(byte[] pixels, int width, int height)
    {
        Colors = new Color[width, height];
        for (var i = 0; i < width; i++)
        {
            for (var j = 0; j < height; j++)
            {
                var offset = 3 * (i + j * width);
                Colors[i, j] = new Color(pixels[offset], pixels[offset + 1], pixels[offset + 2]) / 255;
            }
        }

        Width = width;
        Height = height;
    }

    public ImageData(Color[,] colors, int width, int height)
    {
        Colors = colors;
        Width = width;
        Height = height;
    }

    public Color[,] Colors { get; }
    public int Height { get; }
    public int Width { get; }

    public ImageData CropFragment(int fragmentX, int fragmentY, int fragmentWidth, int fragmentHeight)
    {
        Color[,] fragmentColors = new Color[fragmentWidth, fragmentHeight];

        for (var i = 0; i < fragmentWidth; i++)
        {
            for (var j = 0; j < fragmentHeight; j++)
            {
                fragmentColors[i, j] = Colors[fragmentX + i, fragmentY + j];
            }
        }

        return new ImageData(fragmentColors, fragmentWidth, fragmentHeight);
    }
}
