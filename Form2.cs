using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Sistemi_Odločanja
{
	public partial class RezultatiForm : Form
	{
		public Parameter Max;
		public Parameter Min;
		public double Avg;

		public RezultatiForm(Parameter Max, Parameter Min, double Avg)
		{
			this.Max = Max;
			this.Min = Min;
			this.Avg = Avg;
			InitializeComponent();
			max_val_name.Text = Max.Ime;
			max_val.Text = Max.Korist.ToString();
			min_val_name.Text = Min.Ime;
			min_val.Text = Min.Korist.ToString();
			avg_val.Text = Math.Round(Avg, 2).ToString();
		}

		private void Vizualizacija_Click(object sender, EventArgs e)
		{
			Visualisation vizualizacija = new(Max, Min, Avg);
			vizualizacija.Show();
		}
	}
}