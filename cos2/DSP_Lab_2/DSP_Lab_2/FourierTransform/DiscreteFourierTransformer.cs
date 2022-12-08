using System;

namespace DSP_LAB_2
{
    public static class DiscreteFourierTransformer
    {
        public static FourierResultModel[] CalculateDirect(double[] sequence, int harmonicCount)
        {
            var sequenceLength = sequence.Length;
            var fourierResults = new FourierResultModel[harmonicCount];

            for (var j = 0; j < harmonicCount; j++)
            {
                var cosAmplitudeSum = 0.0;
                var sinAmplitudeSum = 0.0;

                for (var i = 0; i < sequenceLength; i++)
                {
                    cosAmplitudeSum += sequence[i] * Math.Cos(2 * Math.PI * j * i / sequenceLength);
                    sinAmplitudeSum += sequence[i] * Math.Sin(2 * Math.PI * j * i / sequenceLength);
                }

                cosAmplitudeSum = cosAmplitudeSum * 2 / sequenceLength;
                sinAmplitudeSum = sinAmplitudeSum * 2 / sequenceLength;

                var amplitude = Math.Sqrt(Math.Pow(cosAmplitudeSum, 2) + Math.Pow(sinAmplitudeSum, 2));
                var phase = Math.Atan2(sinAmplitudeSum, cosAmplitudeSum);

                fourierResults[j] = new FourierResultModel
                {
                    Amplitude = amplitude,
                    Phase = amplitude > 0.001 ? phase : 0.0
                };
            }

            return fourierResults;
        }

        public static double[] CalculateInverse(FourierResultModel[] fourierResults, int dataCount,
            bool withoutPhase = false)
        {
            var restoredData = new double[dataCount];

            for (var i = 0; i < dataCount; i++)
            {
                var sum = fourierResults[0].Amplitude / 2;

                for (var j = 1; j < dataCount / 2 - 1; j++)
                {
                    sum += fourierResults[j].Amplitude * Math.Cos(2 * Math.PI * j * i / dataCount -
                                                                  (withoutPhase ? 0.0 : fourierResults[j].Phase));
                }

                restoredData[i] = sum;
            }

            return restoredData;
        }
    }
}