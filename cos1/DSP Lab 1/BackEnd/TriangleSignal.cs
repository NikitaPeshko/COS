using System;

namespace DSP.Lab1.Presentation.BackEnd
{
    public class TriangleSignal : Signal
    {
        public TriangleSignal(double A, double F, int N) : base(A, F, N)
        {

        }

        public TriangleSignal(double A, double F, double P, int N) : base(A, F, P, N)
        {
        }

        public override double GetValue(int i)
        {
            var temp = (2 * Amplitude / Math.PI) * Math.Asin(Math.Sin((2 * Math.PI * Frequency * i / N) + Phase));
            return temp;


            //var a = (8 * Amplitude / Math.Pow(Math.PI, 2));
            //const int k = 9;
            //double sum = 0;
            //for (var j = 1; j <= k; j++)
            //{
            //    sum += Math.Pow(-1, (j - 1) / 2) 
            //           * Math.Sin(j * 2 * Math.PI * Frequency * i / N + Phase) 
            //           * (1 / Math.Pow(j, 2));
            //}
            //return sum * a;
        }
    }
}
