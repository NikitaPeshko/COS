namespace DSP.Lab1.Presentation.Init
{
    public static class SignalInitializer
    {
        private static void Init(Form1 form)
        {
            form.WellRateLabel.Enabled = false;
            form.WellRateTrackBar.Enabled = false;
            form.WellRateValuelabel.Enabled = false;
        }

        public static void InitSinusoid(Form1 form)
        {
            Init(form);
        }

        public static void InitPulse(Form1 form)
        {
            Init(form);
            form.WellRateLabel.Enabled = true;
            form.WellRateTrackBar.Enabled = true;
            form.WellRateValuelabel.Enabled = true;
        }

        public static void InitSawTooth(Form1 form)
        {
            Init(form);
        }

        public static void InitTriangle(Form1 form)
        {
            Init(form);
        }

        public static void InitNoise(Form1 form)
        {
            Init(form);
        }
    }
}
