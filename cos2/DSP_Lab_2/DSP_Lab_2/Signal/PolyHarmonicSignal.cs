using System;

namespace DSP_LAB_2
{
    internal class PolyHarmonicSignal
    {
        private readonly int[] _amplitudes = {3,5,6,8,10,13,16};

        private readonly double[] _phases =
            {Math.PI / 6, Math.PI / 4, Math.PI / 3, Math.PI / 2, 3 * Math.PI / 4, Math.PI};

        private readonly Random _random = new Random();
        private double[] _sequence;

        public double[] GenerateSequence(int dataCount)
        {
            _sequence = new double[dataCount];

            var harmonicAmplitudes = new double[30];
            var harmonicPhases = new double[30];


            for (var j = 0; j < 30; j++)
            {
                harmonicAmplitudes[j] = _amplitudes[_random.Next(_amplitudes.Length - 1)];
                harmonicPhases[j] = _phases[_random.Next(_phases.Length - 1)];
            }

            for (var i = 0; i < dataCount; i++)
            {
                var sum = 0.0;

                for (var j = 1; j <= 30; j++)
                {
                    sum += harmonicAmplitudes[j - 1] *
                           Math.Cos(2 * Math.PI * j * i / dataCount - harmonicPhases[j - 1]);
                }

                _sequence[i] = sum;
            }

            return _sequence;
        }
    }
}