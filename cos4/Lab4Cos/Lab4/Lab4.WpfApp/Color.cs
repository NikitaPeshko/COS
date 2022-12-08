// Licensed to the.NET Foundation under one or more agreements.
// The.NET Foundation licenses this file to you under the MIT license.

using System;

namespace Lab4.WpfApp;

public struct Color : IEquatable<Color>, IComparable<Color>, IComparable
{
    public bool Equals(Color other) => this == other;

    public override bool Equals(object? obj) => obj is Color other && Equals(other);

    public override int GetHashCode() => HashCode.Combine(Red, Green, Blue, Alpha);

    public Color(float value)
    {
        Red = value;
        Green = value;
        Blue = value;
        Alpha = 1;
    }

    public Color(float red, float green, float blue, float alpha = 1)
    {
        Red = red;
        Green = green;
        Blue = blue;
        Alpha = alpha;
    }

    public static Color Zero => new(0);

    public float Red { get; set; }
    public float Green { get; set; }
    public float Blue { get; set; }
    public float Alpha { get; set; }

    public static Color operator *(Color left, float right) =>
        new(left.Red * right, left.Green * right, left.Blue * right);

    public static Color operator *(Color left, Color right) =>
        new(left.Red * right.Red, left.Green * right.Red, left.Blue * right.Red);

    public static Color operator *(float left, Color right) => right * left;

    public static Color operator /(Color left, float right) =>
        new(left.Red / right, left.Green / right, left.Blue / right);

    public static Color operator /(float left, Color right) => right / left;

    public static Color operator +(Color left, Color right) =>
        new(left.Red + right.Red, left.Green + right.Green, left.Blue + right.Blue);

    public static Color operator -(Color left, Color right) =>
        new(left.Red - right.Red, left.Green - right.Green, left.Blue - right.Blue);

    public static bool operator ==(Color color1, Color color2) => color1.Red == color2.Red &&
                                                                  color1.Green == color2.Green &&
                                                                  color1.Blue == color2.Blue &&
                                                                  color1.Alpha == color2.Alpha;

    public static bool operator !=(Color color1, Color color2) => !(color1 == color2);

    public override string ToString() => $"RED: {Red}, GREEN: {Green}, BLUE: {Blue};";

    public int CompareTo(Color other)
    {
        var val1 = Red * Alpha + Green * Alpha + Blue * Alpha;
        var val2 = other.Red * other.Alpha + other.Green * other.Alpha + other.Blue * other.Alpha;
        return val1.CompareTo(val2);
    }

    public int CompareTo(object? obj)
    {
        if (ReferenceEquals(null, obj))
        {
            return 1;
        }

        return obj is Color other
            ? CompareTo(other)
            : throw new ArgumentException($"Object must be of type {nameof(Color)}");
    }

    public float ToGrayscale() => ToGrayscale(this);

    public static float ToGrayscale(Color color) =>
        //return 0.0721f * color.Blue + 0.7154f * color.Green + 0.2125f * color.Red;
        (color.Red + color.Green + color.Blue) / 3;
}
