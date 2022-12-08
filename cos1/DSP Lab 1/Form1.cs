using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using DSP.Lab1.Presentation.BackEnd;
using DSP.Lab1.Presentation.Const;
using DSP.Lab1.Presentation.Init;
using DSP.Lab1.Presentation.Model;
using DSP.Lab1.Presentation.WAV;
using NAudio.Wave;

namespace DSP.Lab1.Presentation
{
    public partial class Form1 : Form
    {
        private delegate void Init(Form1 form);

        private delegate ParametersModel GetParameters(Form1 form);

        private delegate void Draw(Chart chart, ParametersModel model);

        private delegate Signal GetSignal(ParametersModel model, int index = 0);
        

        private readonly string[] _modulations =
        {
            ModulationNames.Amplitude,
            ModulationNames.Frequency
        };

        private readonly Dictionary<string, Init> _initParameters = new Dictionary<string, Init>()
        {
            //[TaskNames.Task1A] = TaskInitializer.InitTask1A,
            [TaskNames.Task1A] = TaskInitializer.InitTask1A,
            [TaskNames.Task1B] = TaskInitializer.InitTask1B,
            [TaskNames.Task1C] = TaskInitializer.InitTask1C
         
        };

        private readonly Dictionary<string, GetParameters> _getParameters = new Dictionary<string, GetParameters>()
        {
            [TaskNames.Task1A] = ParametersGetter.Get1a,
            [TaskNames.Task1B] = ParametersGetter.Get1b,
            [TaskNames.Task1C] = ParametersGetter.Get1c
          
        };

  

        private readonly Dictionary<string, Init> _initSignals = new Dictionary<string, Init>()
        {
            [SignalNames.Sinusoid] = SignalInitializer.InitSinusoid,
            [SignalNames.Pulse] = SignalInitializer.InitPulse,
            [SignalNames.Triangle] = SignalInitializer.InitTriangle,
            [SignalNames.SawTooth] = SignalInitializer.InitSawTooth,
            [SignalNames.Noise] = SignalInitializer.InitNoise
        };

        private readonly Dictionary<string, GetSignal> _getSignals = new Dictionary<string, GetSignal>()
        {
            [SignalNames.Sinusoid] = SignalCreator.GetSinusoid,
            [SignalNames.Pulse] = SignalCreator.GetPulse,
            [SignalNames.Triangle] = SignalCreator.GetTriangle,
            [SignalNames.SawTooth] = SignalCreator.GetSawTooth,
            [SignalNames.Noise] = SignalCreator.GetNoise
        };


        public Form1()
        {
            InitializeComponent();
            FillTaskComboBox();
            FillSignalComboBox();
            FillModulatingSignalComboBox();
            FillModulationTypeComboBox();
        }

        private void FillModulationTypeComboBox()
        {
            ModulationComboBox.Items.Clear();
            foreach (var str in _modulations)
            {
                ModulationComboBox.Items.Add(str);
            }
        }

        private void FillModulatingSignalComboBox()
        {
            ModulatingSignalComboBox.Items.Clear();
            foreach (var key in _initSignals.Keys)
            {
                ModulatingSignalComboBox.Items.Add(key);
            }
        }

        private void FillTaskComboBox()
        {
            TaskComboBox.Items.Clear();
            foreach (var key in _initParameters.Keys)
            {
                TaskComboBox.Items.Add(key);
            }
        }

        private void FillSignalComboBox()
        {
            SignalComboBox.Items.Clear();
            foreach (var key in _initSignals.Keys)
            {
                SignalComboBox.Items.Add(key);
            }
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            _initParameters[TaskComboBox.Text](this);
        }

        private void SignalComboBox_TextChanged(object sender, EventArgs e)
        {
            _initSignals[SignalComboBox.Text](this);
        }


        private void WellRateTrackBar_Scroll(object sender, EventArgs e)
        {
            WellRateValuelabel.Text = ((double) WellRateTrackBar.Value / 100d).ToString();
        }

        private static void PlaySound(List<float> samples)
        {
            const ushort numOfChannels = 1;
            const int sampleRate = 44100;

            var waveFormat = WaveFormat.CreateIeeeFloatWaveFormat(sampleRate, numOfChannels);
            ISampleProvider stream = new WavStream(waveFormat, samples);
            WaveFileWriter.CreateWaveFile16("sound.wav", stream);

            
        }

        private void DrawChart(IReadOnlyList<double> values)
        {
            var series = new Series();
            series.ChartType = SeriesChartType.Spline;

            for (var i = 0; i < values.Count; i++)
            {
                series.Points.AddXY(i, values[i]);
            }

            ResultChart.Series.Add(series);
        }

        private double[] GetValues(ParametersModel model)
        {
            switch (TaskComboBox.Text)
            {
                case TaskNames.Task1A:
                {
                    var signal = _getSignals[SignalComboBox.Text](model, 0);
                    signal.Generate();
                    return signal.Values;
                }
                case TaskNames.Task1B:
                {
                    var signal1 = _getSignals[SignalComboBox.Text](model, 0);
                    var signal2 = _getSignals[ModulatingSignalComboBox.Text](model, 1);
                    signal1.Generate();
                    signal2.Generate();
                    for (var i = 0; i < signal1.Values.Length; i++)
                    {
                        signal1.Values[i] += signal2.Values[i];
                    }

                    return signal1.Values;

                  
                    }
                case TaskNames.Task1C:
                {
                    var signal1 = _getSignals[SignalComboBox.Text](model, 0);
                    var signal2 = _getSignals[ModulatingSignalComboBox.Text](model, 1);


                    switch (ModulationComboBox.Text)
                    {
                        case ModulationNames.Amplitude:
                        {
                            var values = Modulator.generateAmplitudeModulateSignal(signal1, signal2).ToList();
                            return values.ToArray();
                        }
                        case ModulationNames.Frequency:
                        {
                            var values = Modulator.FrequencyModulation3(signal1, signal2).ToList();
                            return values.ToArray();
                        }
                    }

                    break;
                }
            }

            return Array.Empty<double>();
        }

        

        private void построитьГрафикToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void сгенерироватьЗвукToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var bytes = new List<float>();
            var model = _getParameters[TaskComboBox.Text](this);
            model.N = 44100;

            var values = GetValues(model).ToList();
            bytes.AddRange(values.Select(value => ((float)value)));
            MessageBox.Show("Сгенерированно успешно");

            PlaySound(bytes);
        }

        private void построитьГрафикToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var model = _getParameters[TaskComboBox.Text](this);
            var values = GetValues(model);

            ResultChart.ChartAreas[0].AxisX.Minimum = 0;
            ResultChart.ChartAreas[0].AxisX.Maximum = model.N;
            ResultChart.Series.Clear();

            DrawChart(values);


            ResultChart.ChartAreas[0].AxisY.Minimum = ResultChart.Series.Min(
                series => series.Points.Min(point => point.YValues.Min())
            ) - 0.1;
            ResultChart.ChartAreas[0].AxisY.Maximum = ResultChart.Series.Max(
                series => series.Points.Max(point => point.YValues.Max())
            ) + 0.1;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TaskComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void A1TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void показатьФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer", "D:\\7sem\\Pack\\ЦОС\\Лабы\\DSP_Lab_1\\DSP Lab 1\\bin\\Debug\\sound.wav");

        }
    }
}