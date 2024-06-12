using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Sistemi_Odločanja
{
	public partial class Visualisation : Form
	{
		public Parameter Max;
		public Parameter Min;
		public Chart chart = new Chart();
		public double Avg;
		public Visualisation(Parameter max, Parameter min, double avg)
		{
			Max = max;
			Min = min;
			Avg = avg;
			InitializeComponent();
			InitializeChart();
		}
		private void InitializeChart()
		{
			chart.Dock = DockStyle.Fill;
			this.Controls.Add(chart);

			ChartArea chartArea = new ChartArea();
			chart.ChartAreas.Add(chartArea);

			Series seriesMax = new Series
			{
				Name = "Max",
				ChartType = SeriesChartType.Column,
				IsValueShownAsLabel = true
			};
			chart.Series.Add(seriesMax);
			DataPoint pointMax = new DataPoint(0, Max.Korist);
			pointMax.AxisLabel = "Max ( " + Max.Ime + " )";
			pointMax["PixelPointWidth"] = "50";
			seriesMax.Points.Add(pointMax);

			Series seriesAvg = new Series
			{
				Name = "Avg",
				ChartType = SeriesChartType.Column,
				IsValueShownAsLabel = true
			};
			chart.Series.Add(seriesAvg);
			DataPoint pointAvg = new DataPoint(1, Avg);
			pointAvg.AxisLabel = "Avg";
			pointAvg["PixelPointWidth"] = "50";
			seriesAvg.Points.Add(pointAvg);

			Series seriesMin = new Series
			{
				Name = "Min",
				ChartType = SeriesChartType.Column,
				IsValueShownAsLabel = true
			};
			chart.Series.Add(seriesMin);
			DataPoint pointMin = new DataPoint(2, Min.Korist);
			pointMin.AxisLabel = "Min ( " + Max.Ime + " )";
			pointMin["PixelPointWidth"] = "50";
			seriesMin.Points.Add(pointMin);
		}

		private void Vizualizacija_Click(object sender, EventArgs e)
		{
			using (SaveFileDialog saveFileDialog = new SaveFileDialog())
			{
				saveFileDialog.Filter = "PNG Image|*.png|JPEG Image|*.jpg|BMP Image|*.bmp";
				saveFileDialog.Title = "Save Chart Image";
				saveFileDialog.ShowDialog();

				if (saveFileDialog.FileName != "")
				{
					chart.SaveImage(saveFileDialog.FileName, ChartImageFormat.Png);
				}
			}
		}
	}

}

