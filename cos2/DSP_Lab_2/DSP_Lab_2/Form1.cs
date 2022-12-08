using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DSP_LAB_2
{
    public partial class Form1 : Form
    {
        private const int N = 512;

        public Form1()
        {
            InitializeComponent();
        }


        private void DrawHarmonic()
        {
            PrepareCharts();


            var harmonicSignal = new HarmonicSignal(30, 20, -3*Math.PI/4);
            var originalData = harmonicSignal.GenerateSequence(N);

            var fourierResults = DiscreteFourierTransformer.CalculateDirect(originalData, N);

            var restoredData = DiscreteFourierTransformer.CalculateInverse(fourierResults, N);

            for (var i = 0; i < N; i++)
            {
                _harmonicOriginal.Points.AddXY(i, originalData[i]);
                _harmonicRestored.Points.AddXY(i, restoredData[i]);
            }

            for (var i = 0; i < fourierResults.Length; i++)
            {
                _harmonicAmplitudeSpec.Points.AddXY(i, fourierResults[i].Amplitude);
                _harmonicPhaseSpec.Points.AddXY(i, fourierResults[i].Phase);
            }

            cHarmonicOriginal.Series.Add(_harmonicOriginal);
            cHarmonicRestored.Series.Add(_harmonicRestored);
            cHarmonicPhase.Series.Add(_harmonicPhaseSpec);
            cHarmonicAmplitude.Series.Add(_harmonicAmplitudeSpec);
        }

        private void DrawPolyHarmonic(bool isFast = false, bool withoutPhase = false)
        {
            PrepareCharts();

            var polyHarmonicSignal = new PolyHarmonicSignal();
            var originalData = polyHarmonicSignal.GenerateSequence(N);

            var fourierResults = isFast
                ? FastFourier.CalculateDirect(originalData)
                : DiscreteFourierTransformer.CalculateDirect(originalData, N);

            var restoredData = DiscreteFourierTransformer.CalculateInverse(fourierResults, N, withoutPhase);

            for (var i = 0; i < N; i++)
            {
                _polyHarmonicOriginal.Points.AddXY(i, originalData[i]);
                _polyHarmonicRestored.Points.AddXY(i, restoredData[i]);
            }

            for (var i = 0; i < fourierResults.Length; i++)
            {
                _polyHarmonicAmplitudeSpec.Points.AddXY(i, fourierResults[i].Amplitude);
                _polyHarmonicPhaseSpec.Points.AddXY(i, fourierResults[i].Phase);
            }

            cHarmonicOriginal.Series.Add(_polyHarmonicOriginal);
            cHarmonicRestored.Series.Add(_polyHarmonicRestored);
            cHarmonicAmplitude.Series.Add(_polyHarmonicPhaseSpec);
            cHarmonicPhase.Series.Add(_polyHarmonicAmplitudeSpec);
        }

        private void DrawFilters()
        {
            PrepareCharts();

            var polyHarmonicSignal = new PolyHarmonicSignal();
            var originalData = polyHarmonicSignal.GenerateSequence(N);

            var fourierResults = DiscreteFourierTransformer.CalculateDirect(originalData, N);

            var fourierResultsHf = fourierResults.Select(x => new FourierResultModel
            {
                Amplitude = x.Amplitude,
                Phase = x.Phase
            }).ToArray();

            var fourierResultsLf = fourierResults.Select(x => new FourierResultModel
            {
                Amplitude = x.Amplitude,
                Phase = x.Phase
            }).ToArray();

            var fourierResultsBp = fourierResults.Select(x => new FourierResultModel
            {
                Amplitude = x.Amplitude,
                Phase = x.Phase
            }).ToArray();

            var hfFilterData =
                DiscreteFourierTransformer.CalculateInverse(fourierResultsHf.ApplyFilter(i => i >= 30), N);
            var lfFilterData =
                DiscreteFourierTransformer.CalculateInverse(fourierResultsLf.ApplyFilter(i => i < 10), N);
            var bpFilterData =
                DiscreteFourierTransformer.CalculateInverse(fourierResultsBp.ApplyFilter(i => i >= 10 & i < 30), N);


            for (var i = 0; i < N; i++)
            {
                _filterOriginal.Points.AddXY(i, originalData[i]);
                _filterBandPass.Points.AddXY(i, bpFilterData[i]);
                _filterLowFrequency.Points.AddXY(i, lfFilterData[i]);
                _filterHighFrequency.Points.AddXY(i, hfFilterData[i]);
            }

            cHarmonicOriginal.Series.Add(_filterOriginal);
            cHarmonicRestored.Series.Add(_filterBandPass);
            cHarmonicAmplitude.Series.Add(_filterLowFrequency);
            cHarmonicPhase.Series.Add(_filterHighFrequency);
        }

       
        

        private void ResetCharts()
        {
            cHarmonicOriginal.Series.Clear();
            cHarmonicRestored.Series.Clear();
            cHarmonicAmplitude.Series.Clear();
            cHarmonicPhase.Series.Clear();

            _harmonicOriginal.Points.Clear();
            _harmonicRestored.Points.Clear();

            _harmonicAmplitudeSpec.Points.Clear();
            _harmonicPhaseSpec.Points.Clear();

            _polyHarmonicOriginal.Points.Clear();
            _polyHarmonicRestored.Points.Clear();

            _polyHarmonicAmplitudeSpec.Points.Clear();
            _polyHarmonicPhaseSpec.Points.Clear();

            _filterOriginal.Points.Clear();
            _filterBandPass.Points.Clear();
            _filterLowFrequency.Points.Clear();
            _filterHighFrequency.Points.Clear();
        }

        // task 2
        private readonly Series _harmonicOriginal = new Series
        {
            ChartType = SeriesChartType.Spline,
            Color = Color.Yellow,
            LegendText = "Исходный сигнал"
        };

        private readonly Series _harmonicRestored = new Series
        {
            ChartType = SeriesChartType.Spline,
            Color = Color.Crimson,
            LegendText = "Восстановленный сигнал"
        };

        private readonly Series _harmonicAmplitudeSpec = new Series
        {
            ChartType = SeriesChartType.Candlestick,
            Color = Color.Indigo,
            LegendText = "Амплитудный спектр"
        };

        private readonly Series _harmonicPhaseSpec = new Series
        {
            ChartType = SeriesChartType.Candlestick,
            Color = Color.DarkOrange,
            LegendText = "Фазовый спектр"
        };

        // task 3-4
        private readonly Series _polyHarmonicOriginal = new Series
        {
            ChartType = SeriesChartType.Spline,
            Color = Color.Yellow,
            LegendText = "Исходный сигнал"
        };

        private readonly Series _polyHarmonicRestored = new Series
        {
            ChartType = SeriesChartType.Spline,
            Color = Color.Crimson,
            LegendText = "Восстановленный сигнал"
        };

        private readonly Series _polyHarmonicAmplitudeSpec = new Series
        {
            ChartType = SeriesChartType.Candlestick,
            Color = Color.Indigo,
            LegendText = "Амплитудный спектр"
        };

        private readonly Series _polyHarmonicPhaseSpec = new Series
        {
            ChartType = SeriesChartType.Candlestick,
            Color = Color.DarkOrange,
            LegendText = "Фазовый спектр"
        };

        // task 5
        private readonly Series _filterOriginal = new Series
        {
            ChartType = SeriesChartType.Spline,
            Color = Color.Yellow,
            LegendText = "Исходный сигнал"
        };

        private readonly Series _filterBandPass = new Series
        {
            ChartType = SeriesChartType.Spline,
            Color = Color.Crimson,
            LegendText = "Полосовой фильтр"
        };

        private readonly Series _filterLowFrequency = new Series
        {
            ChartType = SeriesChartType.Spline,
            Color = Color.Indigo,
            LegendText = "НЧ-фильтр"
        };

        private readonly Series _filterHighFrequency = new Series
        {
            ChartType = SeriesChartType.FastLine,
            Color = Color.DarkOrange,
            LegendText = "ВЧ-фильтр"
        };

        private void PrepareCharts()
        {
            cHarmonicOriginal.ChartAreas[0].AxisX =
                new Axis { Minimum = 0, Maximum = N, IntervalOffset = 0, Interval = 16 };
            cHarmonicRestored.ChartAreas[0].AxisX =
                new Axis { Minimum = 0, Maximum = N, IntervalOffset = 0, Interval = 16 };
            cHarmonicAmplitude.ChartAreas[0].AxisX =
                new Axis { Minimum = 0, Maximum = N/2, IntervalOffset = 0, Interval = 16 };
            cHarmonicPhase.ChartAreas[0].AxisX = new Axis { Minimum = 0, Maximum = N/2, IntervalOffset = 0, Interval = 16 };
            cHarmonicOriginal.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            cHarmonicOriginal.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            cHarmonicRestored.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            cHarmonicRestored.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            cHarmonicAmplitude.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            cHarmonicAmplitude.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            cHarmonicPhase.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            cHarmonicPhase.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
        }

       

        private void button4_Click(object sender, EventArgs e)
        {
            ResetCharts();
            DrawHarmonic();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResetCharts();
            DrawPolyHarmonic(false, false);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ResetCharts();
            DrawPolyHarmonic(true, false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ResetCharts();
            DrawFilters();

        }
    }
}