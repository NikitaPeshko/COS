using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DSP.Lab1.Presentation.BackEnd
{
    public static class Modulator
    {
        

        
        public static IEnumerable<double> FrequencyModulation3(Signal signal1, Signal signal2)
        {
            signal2.Generate();
            

            signal1.Values = new double[signal2.Values.Length];
            signal1.Phase = 0;

            for (var i = 0; i < signal2.Values.Length; i++)
            {
                signal1.Values[i] = signal1.GetValue(1);
              
               signal1.Phase+=2 * Math.PI * signal1.Frequency * (1 + signal2.Values[i]) / signal1.N;
            }

            return signal1.Values;
        }
      
       


        public static IEnumerable<double> generateAmplitudeModulateSignal(Signal s1, Signal s2)

        {
            s1.Generate();
            s2.Generate();



            if (s1.Values.Length != s2.Values.Length)
            {
                throw new Exception("Сигналы должны иметь одинаковую длину");
            }
            var values =new double[s1.Values.Length];
            for(var i = 0; i < s1.Values.Length; i++)
            {
                values[i] = s1.Values[i] * (1 + s2.Values[i]);

            }
            return values;


        }
    }
}
