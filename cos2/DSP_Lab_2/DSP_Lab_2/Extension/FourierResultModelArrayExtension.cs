using System;

namespace DSP_LAB_2
{
    public static class FourierResultModelArrayExtension
    {
        public static FourierResultModel[] ApplyFilter(this FourierResultModel[] fourierResults, Func<int, bool> filter)
        {
            if (filter == null)
            {
                return fourierResults;
            }

            for (var i = 0; i < fourierResults.Length; i++)
            {
                if (filter(i)) continue;
                fourierResults[i].Amplitude = 0;
                fourierResults[i].Phase = 0;
            }

            return fourierResults;
        }
    }
}
