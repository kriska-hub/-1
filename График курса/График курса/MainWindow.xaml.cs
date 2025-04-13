using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace График_курса
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private readonly Random rand = new Random();

        private void BuildButton_Click(object sender, RoutedEventArgs e)
        {
            int days = GetDays();
            string currency = ((ComboBoxItem)CurrencyBox.SelectedItem).Content.ToString();
            List<double> values = GenerateValues(currency, days);

            double average = values.Average();
            AverageText.Text = $"Среднее значение: {average:F2}";

            DrawChart(values);
        }

        private int GetDays()
        {
            string period = ((ComboBoxItem)PeriodBox.SelectedItem).Content.ToString();
            return period switch
            {
                "Месяц" => 30,
                "Полгода" => 180,
                "Год" => 365,
                _ => 30
            };
        }

        private List<double> GenerateValues(string currency, int count)
        {
            double baseValue = currency == "USD" ? 90 : 100;
            return Enumerable.Range(0, count)
                             .Select(_ => baseValue + rand.NextDouble() * 10 - 5)
                             .ToList();
        }

        private void DrawChart(List<double> values)
        {
            ChartCanvas.Children.Clear();

            double width = ChartCanvas.ActualWidth;
            double height = ChartCanvas.ActualHeight;

            if (width == 0 || height == 0) return;

            int count = values.Count;
            double maxVal = values.Max();
            double minVal = values.Min();

            double stepX = width / (count - 1);
            double rangeY = maxVal - minVal;
            if (rangeY == 0) rangeY = 1;

            Point[] points = new Point[count];
            for (int i = 0; i < count; i++)
            {
                double x = i * stepX;
                double y = height - ((values[i] - minVal) / rangeY * height);
                points[i] = new Point(x, y);
            }

            Polyline line = new Polyline
            {
                Stroke = Brushes.Yellow,
                StrokeThickness = 2
            };
            foreach (var pt in points)
            {
                line.Points.Add(pt);
            }
            ChartCanvas.Children.Add(line);

            // Отметки на оси Y 
            for (int i = 0; i <= 5; i++)
            {
                double val = minVal + i * (rangeY / 5);
                double y = height - (i * height / 5);
                Line tick = new Line
                {
                    X1 = 0,
                    X2 = 5,
                    Y1 = y,
                    Y2 = y,
                    Stroke = Brushes.White
                };
                ChartCanvas.Children.Add(tick);

                TextBlock label = new TextBlock
                {
                    Text = val.ToString("F2"),
                    FontSize = 15,
                    Foreground = Brushes.White,
                };
                Canvas.SetLeft(label, 10);
                Canvas.SetTop(label, y - 10);
                ChartCanvas.Children.Add(label);
            }
        }
    }
}