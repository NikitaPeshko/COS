using System;

namespace DSP_LAB_2
{
    internal class HarmonicSignal
    {
        private readonly double _amplitude;
        private readonly double _frequency;
        private readonly double _phase;
        
        private double[] _sequence;

        public HarmonicSignal(double amplitude, double frequency, double phase)
        {
            _amplitude = amplitude;
            _frequency = frequency;
            _phase = phase;
        }

        public double[] GenerateSequence(int N)
        {
            _sequence = new double[N];

            for (var i = 0; i < N; i++)
            {
                _sequence[i] = _amplitude * Math.Cos(2 * Math.PI * i * _frequency / N + _phase);
            }

            return _sequence;
        }
    }
}