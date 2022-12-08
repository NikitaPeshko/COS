using System;

namespace DSP.Lab1.Presentation.BackEnd
{
    public class SawToothSignal : Signal
    {
        public SawToothSignal(double a, double f, int n) : base(a, f, n)
        {
        }

        public SawToothSignal(double a, double f, double p, int n) : base(a, f, p, n)
        {
        }

        public override double GetValue(int i)
        {

            var result= (2 * Amplitude / Math.PI) * Math.Atan(Math.Tan(((2 * Math.PI * Frequency * i / N) + Phase)/2));
            return result;
            //var a = Amplitude / Math.PI;
            //const int k = 9;
            //double sum = 0;
            //for (var j = 1; j <= k; j++)
            //{
            //    sum += Math.Sin(j * 2 * Math.PI * Frequency * i / N + Phase) / j;
            //}
            //return Amplitude / 2 - sum * a;
        }
    }
}
