using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace DSP_LAB_2
{
    public static class FastFourier
    {
        private static Complex CalculateCoefficient(int k, int N)
        {
            if (k % N == 0) return 1;
            var arg = -2 * Math.PI * k / N;
            return new Complex(Math.Cos(arg), Math.Sin(arg));
        }

        private static Complex[] CalculateRecursive(IReadOnlyList<Complex> x)
        {
            Complex[] X;
            var N = x.Count;
            if (N == 2)
            {
                X = new Complex[2];
                X[0] = x[0] + x[1];
                X[1] = x[0] - x[1];
            }
            else
            {
                var xEven = new Complex[N / 2];
                var xOdd = new Complex[N / 2];
                for (var i = 0; i < N / 2; i++)
                {
                    xEven[i] = x[2 * i];
                    xOdd[i] = x[2 * i + 1];
                }

                var xEvenArray = CalculateRecursive(xEven);
                var xOddArray = CalculateRecursive(xOdd);
                X = new Complex[N];
                for (var i = 0; i < N / 2; i++)
                {
                    X[i] = xEvenArray[i] + CalculateCoefficient(i, N) * xOddArray[i];
                    X[i + N / 2] = xEvenArray[i] - CalculateCoefficient(i, N) * xOddArray[i];
                }
            }

            return X;
        }

        public static FourierResultModel[] CalculateDirect(double[] data)
        {
            var complexData = data.GetComplex();

            var complexFourierResult = CalculateRecursive(complexData);
            

            return complexFourierResult.Select(x => new FourierResultModel
            {
                Amplitude = x.Magnitude * 2 / data.Length,
                Phase = -x.Phase
            }).ToArray();
        }

        public static Complex[] GetComplex(this double[] doubles)
        {
            var complex = new Complex[doubles.Length];

            for (var i = 0; i < doubles.Length; i++)
            {
                complex[i] = doubles[i];
            }

            return complex;
        }
    }
}