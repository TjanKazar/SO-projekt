using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Sistemi_Odločanja
{
	public partial class KoristiForm : Form
	{
		List<Parameter> listi;

		public KoristiForm(List<Parameter> parametri)
		{
			listi = new List<Parameter>();
			InitializeComponent();

			foreach (Parameter param in parametri)
			{
				if (param.Podparametri.Count == 0)
				{
					listi.Add(param);
					Console.WriteLine($"Adding parameter: {param.Ime}, Value: {param.Value}, Probability: {param.Probability}");
				}
			}

			koristTable.DataSource = listi;
			koristTable.Columns[nameof(Parameter.Ime)].HeaderText = "Ime Parametra ";
			koristTable.Columns[nameof(Parameter.Value)].HeaderText = "Vrednost ";
			koristTable.Columns[nameof(Parameter.Probability)].HeaderText = "Verjetnost(%)";
		}

		private void PotrdiKoristi_Click(object sender, EventArgs e)
		{
			Console.WriteLine("Confirm button clicked.");

			foreach (var param in listi)
			{
				Console.WriteLine($"Parameter: {param.Ime}, Value: {param.Value}, Probability: {param.Probability}");
			}
		}

		private void label1_Click(object sender, EventArgs e)
		{
			Console.WriteLine("Label1 clicked.");
		}
	}
}
