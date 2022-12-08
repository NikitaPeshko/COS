using System;

namespace DSP.Lab1.Presentation.BackEnd
{
    public class PulseWithDifferentDutyCycleSignal : Signal
    {
        private double WellRate { get; }

        public PulseWithDifferentDutyCycleSignal(double a, double f, int n, double wellRate) : base(a, f, n)
        {
            WellRate = wellRate;
        }

        public PulseWithDifferentDutyCycleSignal(double a, double f, double p, int n, double wellRate) : base(a, f, p, n)
        {
            WellRate = wellRate;
        }

        public override double GetValue(int i)
        {
            return Amplitude * GetImpulse(i);
        }

        private double GetImpulse(int n)
        {
            var sin = Math.Sin(2 * Math.PI * Frequency * n / N + Phase) + 1;
            return sin >= WellRate
                ? 1
                : 0;
        }
    }
}
