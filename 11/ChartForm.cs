using System;
using System.Linq;
using System.Windows.Forms;
using MathNet.Numerics.Distributions;

namespace Lab11.NormalDistribution
{
	public partial class ChartForm : Form
	{
		private double _mean;
		private double _variance;
		private int _sampleSize; 

		private double[] _sample;
		
		public ChartForm(double mean, double variance, int sampleSize)
		{
			InitializeComponent();

			_mean = mean;
			_variance = variance;
			_sampleSize = sampleSize;
			_sample = new double[_sampleSize];

			// Генерируем нормальное распределение
			GenerateNormalDistribution();

			// Генерируем гистограмму
			GenerateHistogram();

			// Генерируем среднее и дисперсию
			GenerateEmpMeanAndVariance();
		}

		private void GenerateNormalDistribution()
		{
			var rnd = new Random();

			for (var i = 0; i < _sampleSize; i++)
			{
				var par1 = rnd.NextDouble();
				var par2 = rnd.NextDouble();

				var sensor = GenerateStandardNormalSensor(par1, par2);

				_sample[i] = Math.Sqrt(_variance) * sensor + _mean;
			}
		}

		private double GenerateStandardNormalSensor(double par1, double par2)
		{
			return Math.Sqrt(-2 * Math.Log(par1)) * Math.Cos(2 * Math.PI * par2);
		}

		private void GenerateHistogram()
		{
			var intervalCount = (int)Math.Ceiling(Math.Sqrt(_sampleSize));
			var maxSample = _sample.Max();
			var minSample = _sample.Min();
			var step = (maxSample - minSample) / intervalCount;

			var frequencies = new int[intervalCount];

			foreach (var value in _sample)
			{
				int intervalIndex = (int)((value - minSample) / step);
				if (intervalIndex == intervalCount)
				{
					intervalIndex--;
				}
				frequencies[intervalIndex]++;
			}

			var relativeFrequencies = frequencies
				.Select(x => (double)x / _sampleSize)
				.ToArray();

			var terProbabilities = new double[intervalCount];
			var chiSquare = 0d;
			var normalDist = new Normal(_mean, Math.Sqrt(_variance));

			mainChart.Series[0]["PointWidth"] = "1";
			mainChart.ChartAreas[0].AxisX.LabelStyle.Format = "F1";

			for (var i = 0; i < intervalCount; i++)
			{
				var x = minSample + (i * step) + (step / 2);
				mainChart.Series[0].Points.AddXY(x, relativeFrequencies[i]);

				var a = minSample + (i * step);
				var b = minSample + ((i + 1) * step);
				var terProb = normalDist.CumulativeDistribution(b) - normalDist.CumulativeDistribution(a);
				chiSquare += (Math.Pow(frequencies[i], 2) / (_sampleSize * terProb));
			}
			chiSquare -= _sampleSize;
			var criticalValue = ChiSquared.InvCDF(intervalCount - 1, 0.95);
			chiLabel.Text = $"Chi-square: {chiSquare} > {criticalValue} is {chiSquare > criticalValue}";

			mainChart.ChartAreas[0].AxisX.Interval = step;
		}

		private void GenerateEmpMeanAndVariance()
		{
			var empMean = 0d;
			var empVariance = 0d;

			for (var i = 0; i < _sampleSize; i++)
			{
				empMean += _sample[i];
				empVariance += Math.Pow(_sample[i], 2);
			}
			empMean /= _sampleSize;
			empVariance = empVariance / _sampleSize - Math.Pow(empMean, 2);

			var meanError = (Math.Abs(empMean - _mean) / _mean) * 100;
			var varianceError = (Math.Abs(empVariance - _variance) / _variance) * 100;

			meanLabel.Text = $"Average: {empMean} (error = {Math.Round(meanError, 2)}%)";
			varianceLabel.Text = $"Variance: {empVariance} (error = {Math.Round(varianceError, 2)}%)";
		}
	}
}
