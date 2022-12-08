using System;

namespace DSP.Lab1.Presentation.BackEnd
{
    public class NoiseSignal : Signal
    {
        private readonly Random _random = new Random();

        public NoiseSignal(double a, double f, int n) : base(a, f, n)
        {
        }

        public NoiseSignal(double a, double f, double p, int n) : base(a, f, p, n)
        {
        }

        public override double GetValue(int i)
        {
            return Amplitude * Math.Sin(2 * Math.PI * Frequency * i / N * _random.NextDouble() + Phase);
        }
    }
}
