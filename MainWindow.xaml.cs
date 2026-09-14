using System;
using System.Windows;
using System.Windows.Threading;
using ScottPlot;

namespace SignalVisualizer
{
    public partial class MainWindow : Window
    {
        private DispatcherTimer _timer = new DispatcherTimer();
        private double _timeOffset = 0;
        private bool _isRunning = false;

        public MainWindow()
        {
            InitializeComponent();
            
            // Timer for "Play/Pause" signal simulation
            _timer.Interval = TimeSpan.FromMilliseconds(50);
            _timer.Tick += (s, e) => UpdatePlot();
            
            RenderSignal();
        }

        private void RenderSignal()
        {
            double a1 = double.TryParse(TxtAmp1.Text, out var v1) ? v1 : 1.0;
            double f1 = double.TryParse(TxtFreq1.Text, out var v2) ? v2 : 5.0;
            double a2 = double.TryParse(TxtAmp2.Text, out var v3) ? v3 : 0.5;
            double f2 = double.TryParse(TxtFreq2.Text, out var v4) ? v4 : 20.0;

            int sampleCount = 500;
            double[] dataX = new double[sampleCount];
            double[] dataY = new double[sampleCount];

            for (int i = 0; i < sampleCount; i++)
            {
                double t = _timeOffset + (i * 0.002); // 0.002s step size
                dataX[i] = t;
                // Mixed signal periodic calculation
                dataY[i] = a1 * Math.Sin(2 * Math.PI * f1 * t) + a2 * Math.Sin(2 * Math.PI * f2 * t);
            }

            WpfPlot1.Plot.Clear();
            WpfPlot1.Plot.Add.Scatter(dataX, dataY);
            WpfPlot1.Plot.Axes.AutoScale();
            WpfPlot1.Refresh();
        }

        private void UpdatePlot()
        {
            _timeOffset += 0.01;
            RenderSignal();
        }

        private void BtnPlay_Click(object sender, RoutedEventArgs e)
        {
            if (!_isRunning) { _timer.Start(); _isRunning = true; }
        }

        private void BtnPause_Click(object sender, RoutedEventArgs e)
        {
            if (_isRunning) { _timer.Stop(); _isRunning = false; }
        }

        private void BtnReset_Click(object sender, RoutedEventArgs e)
        {
            _timer.Stop();
            _isRunning = false;
            _timeOffset = 0;
            RenderSignal();
        }
    }
}