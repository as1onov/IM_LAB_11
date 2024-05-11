using System;
using System.Windows.Forms;

namespace Lab11.NormalDistribution
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void startBtn_Click(object sender, EventArgs e)
		{
			var mean = double.Parse(meanBox.Text);
			var variance = double.Parse(varBox.Text);
			var sampleSize = int.Parse(sizeBox.Text);

			var chartForm = new ChartForm(mean, variance, sampleSize);
			chartForm.Show();
		}
	}
}
