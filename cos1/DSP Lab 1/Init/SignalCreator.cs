using DSP.Lab1.Presentation.BackEnd;
using DSP.Lab1.Presentation.Model;

namespace DSP.Lab1.Presentation.Init
{
    public static class SignalCreator
    {

        public static Signal GetSinusoid(ParametersModel model, int index = 0)
        {
            return new SinusoidSignal(model.A[index], model.F[index], model.Fi[index], model.N);
        }


        public static Signal GetPulse(ParametersModel model, int index = 0)
        {
            return new PulseWithDifferentDutyCycleSignal(model.A[index], model.F[index], model.N, model.WellRate);
        }

        public static Signal GetTriangle(ParametersModel model, int index = 0)
        {
            return new TriangleSignal(model.A[index], model.F[index], model.N);
        }

        public static Signal GetSawTooth(ParametersModel model, int index = 0)
        {
            return new SawToothSignal(model.A[index], model.F[index], model.N);
        }

        public static Signal GetNoise(ParametersModel model, int index = 0)
        {
            return new NoiseSignal(model.A[index], model.F[index], model.N);
        }
    }
}
