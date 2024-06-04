using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private double[] xArray;
        private double[] yArray;
        private double result;
        private int iterations;
        private Interpolation interpolationMethod;

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string selectedItem = listBox.SelectedItem?.ToString();
            CalculationHandler calculationHandler = new CalculationHandler();

            calculationHandler.HandleCalculation(xValuesTx.Text, yValuesTx.Text, inrerpolationTx.Text, selectedItem, txtResult, txtPolynomial, txtNumberOfIterations, chart1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox.Items.Add("Lagrange");
            listBox.Items.Add("Aitken");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|Image Files (*.png)|*.png|All Files (*.*)|*.*";
            saveFileDialog.Title = "Save Interpolation Results";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                SaveHandler saveHandler = new SaveHandler();

                saveHandler.SaveResults(filePath, txtResult.Text, txtPolynomial.Text, txtNumberOfIterations.Text, chart1);
            }
        }

    }
    public interface Interpolation
    {
        (double result, int iterations) Interpolate(double[] xValues, double[] yValues, double x);
    }
    public class Lagrange : Interpolation
    {
        public (double result, int iterations) Interpolate(double[] xValues, double[] yValues, double x)
        {
            int n = xValues.Length;
            double result = 0;
            int iterations = 0;

            for (int i = 0; i < n; i++)
            {
                double term = yValues[i];
                for (int j = 0; j < n; j++)
                {
                    if (j != i)
                    {
                        term = term * (x - xValues[j]) / (xValues[i] - xValues[j]);
                        iterations++;
                    }
                }
                result += term;
            }

            return (result, iterations);
        }
        public string GetLagrangePolynomialString(double[] xValues, double[] yValues)
        {
            int n = xValues.Length;
            StringBuilder polynomial = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                if (yValues[i] >= 0 && i > 0)
                {
                    polynomial.Append("+");
                }
                polynomial.Append($"{yValues[i]:F3}"); // Format coefficient with 4 decimal places
                for (int j = 0; j < n; j++)
                {
                    if (j != i)
                    {
                        polynomial.Append($"*(x - {xValues[j]:F4}) / ({xValues[i]:F4} - {xValues[j]:F4})");
                    }
                }
                if (i < n - 1)
                {
                    polynomial.Append(" ");
                }
            }

            return polynomial.ToString();
        }
    }
    public class Aitken : Interpolation
    {
        public (double result, int iterations) Interpolate(double[] xValues, double[] yValues, double x)
        {
            int n = xValues.Length;
            double[,] p = new double[n, n];
            int iterations = 0;

            for (int i = 0; i < n; i++)
            {
                p[i, 0] = yValues[i];
            }

            for (int j = 1; j < n; j++)
            {
                for (int i = j; i < n; i++)
                {
                    p[i, j] = ((x - xValues[i - j]) * p[i, j - 1] - (x - xValues[i]) * p[i - 1, j - 1]) / (xValues[i] - xValues[i - j]);
                    iterations++;
                }
            }

            return (p[n - 1, n - 1], iterations);
        }
        public string GetAitkenPolynomialString(double[] xValues, double[] yValues)
        {
            int n = xValues.Length;
            double[,] p = new double[n, n];
            StringBuilder polynomial = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                p[i, 0] = yValues[i];
            }

            for (int j = 1; j < n; j++)
            {
                for (int i = j; i < n; i++)
                {
                    p[i, j] = ((xValues[i] - xValues[i - j]) * p[i, j - 1] - (xValues[i] - xValues[i - j]) * p[i - 1, j - 1]) / (xValues[i] - xValues[i - j]);
                    polynomial.Append($"({p[i, j]:F4}*(x - {xValues[i - j]:F4}) / ({xValues[i]:F4} - {xValues[i - j]:F4}))");
                    if (i < n - 1)
                    {
                        polynomial.Append(" + ");
                    }
                }
            }

            return polynomial.ToString();
        }
    }

    public class CalculationHandler
    {
        private readonly InputHandler _inputHandler;

        public CalculationHandler()
        {
            _inputHandler = new InputHandler();
        }

        public void HandleCalculation(string xValuesText, string yValuesText, string interpolationText, string selectedItem, TextBox txtResult, TextBox txtPolynomial, TextBox txtNumberOfIterations, Chart chart1)
        {
            double result;
            int iterations;

            (double[] xArray, double[] yArray, double x, Interpolation interpolationMethod) = _inputHandler.ParseAndValidate(xValuesText, yValuesText, interpolationText, selectedItem);
            if (xArray == null || yArray == null || interpolationMethod == null)
            {
                return;
            }

            (result, iterations) = interpolationMethod.Interpolate(xArray, yArray, x);

            // Получение полиномиальной строки
            string polynomial = interpolationMethod is Lagrange
                ? ((Lagrange)interpolationMethod).GetLagrangePolynomialString(xArray, yArray)
                : ((Aitken)interpolationMethod).GetAitkenPolynomialString(xArray, yArray);

            // Обновление текстовых полей на форме
            txtResult.Text = $"Interpolated value at x = {x} is {result}.";
            txtPolynomial.Text = $"The polynomial is: {polynomial}";
            txtNumberOfIterations.Text = $"{selectedItem} iterations: {iterations}";

            // Add the interpolated point to the data
            List<double> xList = new List<double>(xArray);
            List<double> yList = new List<double>(yArray);
            xList.Add(x);
            yList.Add(result);

            // Визуализация данных
            DataVisualizer visualizer = new DataVisualizer(chart1, xList.ToArray(), yList.ToArray());
            visualizer.VisualizeData();
        }
    }


    public class SaveHandler
    {
        public void SaveResults(string filePath, string resultText, string polynomialText, string iterationsText, Chart chart)
        {
            string extension = Path.GetExtension(filePath).ToLower();

            if (extension == ".txt")
            {
                SaveResultsToTextFile(filePath, resultText, polynomialText, iterationsText);
            }
            else if (extension == ".png")
            {
                SaveChartToImage(filePath, chart);
            }
            else
            {
                MessageBox.Show("Unsupported file format.");
            }
        }

        private void SaveResultsToTextFile(string filePath, string resultText, string polynomialText, string iterationsText)
        {
            string textToSave = $"Result: {resultText}\nPolynomial: {polynomialText}\nIterations: {iterationsText}";
            System.IO.File.WriteAllText(filePath, textToSave);
        }

        private void SaveChartToImage(string filePath, Chart chart)
        {
            chart.SaveImage(filePath, ChartImageFormat.Png);
        }
    }


    public class InputHandler
    {
        public (double[] xArray, double[] yArray, double x, Interpolation interpolationMethod) ParseAndValidate(string xValuesText, string yValuesText, string interpolationText, string selectedItem)
        {
            double[] xArray = null;
            double[] yArray = null;
            double x = 0;
            Interpolation interpolationMethod = null;

            // Validate the input
            if (string.IsNullOrWhiteSpace(xValuesText) || string.IsNullOrWhiteSpace(yValuesText))
            {
                MessageBox.Show("Please enter both x and y values.");
                return (null, null, 0, null);
            }

            // Parse the comma-separated x and y values into arrays
            try
            {
                xArray = xValuesText.Split(',').Select(val => double.Parse(val, CultureInfo.InvariantCulture)).ToArray();
                yArray = yValuesText.Split(',').Select(val => double.Parse(val, CultureInfo.InvariantCulture)).ToArray();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter numbers only, separated by commas.");
                return (null, null, 0, null);
            }

            // Ensure sufficient points
            if (xArray.Length < 2 || yArray.Length < 2)
            {
                MessageBox.Show("Please enter at least two points for both x and y values.");
                return (null, null, 0, null);
            }

            // Ensure x and y arrays have the same length
            if (xArray.Length != yArray.Length)
            {
                MessageBox.Show("The number of x and y values must be the same.");
                return (null, null, 0, null);
            }

            if (!double.TryParse(interpolationText, NumberStyles.Any, CultureInfo.InvariantCulture, out x))
            {
                MessageBox.Show("Please enter a valid number for interpolation.");
                return (null, null, 0, null);
            }

            switch (selectedItem)
            {
                case "Lagrange":
                    interpolationMethod = new Lagrange();
                    break;
                case "Aitken":
                    interpolationMethod = new Aitken();
                    break;
                default:
                    MessageBox.Show("Please select a valid interpolation method.");
                    return (null, null, 0, null);
            }

            return (xArray, yArray, x, interpolationMethod);
        }
    }

    public class DataVisualizer
    {
        private Chart chart;
        private double[] xArray;
        private double[] yArray;
        private Interpolation interpolationMethod;

        public DataVisualizer(Chart chart, double[] xArray, double[] yArray)
        {
            this.chart = chart;
            this.xArray = xArray;
            this.yArray = yArray;
        }

        public void VisualizeData()
        {
            // Add points to the Points series
            var pointsSeries = GetOrCreateSeries("Points", SeriesChartType.Point, Color.Red);
            for (int i = 0; i < xArray.Length; i++)
            {
                pointsSeries.Points.AddXY(xArray[i], yArray[i]);
            }

            // Add the curve series to the chart
            var curveSeries = GetOrCreateSeries("Curve", SeriesChartType.Line, Color.Blue);

            // Calculate the interpolation curve
            CalculateInterpolationCurve("Lagrange", curveSeries);
            CalculateInterpolationCurve("Aitken", curveSeries);

            // Force the chart to redraw itself
            chart.Invalidate();
            chart.Legends[0].Docking = Docking.Bottom;
            chart.Legends[0].Alignment = StringAlignment.Center;
        }

        private Series GetOrCreateSeries(string seriesName, SeriesChartType chartType, Color color)
        {
            var series = chart.Series.FindByName(seriesName);

            if (series == null)
            {
                series = new Series
                {
                    Name = seriesName,
                    Color = color,
                    IsVisibleInLegend = true,
                    IsXValueIndexed = false,
                    ChartType = chartType
                };

                chart.Series.Add(series);
            }
            else
            {
                series.Points.Clear();
            }

            return series;
        }

        private void CalculateInterpolationCurve(string method, Series series)
        {
            if (xArray == null || yArray == null)
            {
                MessageBox.Show("Please enter valid x and y values.");
                return;
            }

            double step = (xArray.Max() - xArray.Min()) / 1000;
            for (double x = xArray.Min(); x <= xArray.Max(); x += step)
            {
                double y;
                if (method == "Lagrange")
                {
                    interpolationMethod = new Lagrange();
                }
                else // Aitken
                {
                    interpolationMethod = new Aitken();
                }
                (y, _) = interpolationMethod.Interpolate(xArray, yArray, x);
                series.Points.AddXY(x, y);
            }
        }
    }

}
