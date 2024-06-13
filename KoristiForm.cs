using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Sistemi_Odločanja
{
	public partial class KoristiForm : Form
	{
		List<Parameter> listi;
		List<Parameter> parametri;

		public KoristiForm(List<Parameter> parametri)
		{
			this.parametri = parametri;
			listi = new List<Parameter>();
			InitializeComponent();

			foreach (Parameter param in parametri)
			{
				if (param.Podparametri.Count == 0)
				{
					listi.Add(param);
					Console.WriteLine($"Adding parameter: {param.Ime}, Value: {param.Value}, Probability: {param.Probability}, Korist: {param.Korist}");
				}
			}
			koristTable.DataSource = listi;
			CustomizeColumnHeaders();
		}

		private void CustomizeColumnHeaders()
		{
			koristTable.Columns[nameof(Parameter.Ime)].HeaderText = "Ime Parametra";
			koristTable.Columns[nameof(Parameter.Value)].HeaderText = "Vrednost";
			koristTable.Columns[nameof(Parameter.Probability)].HeaderText = "Verjetnost";
			koristTable.Columns[nameof(Parameter.Korist)].Visible = false;
			koristTable.Columns[nameof(Parameter.baseNode)].Visible = false;
		}

		private void PotrdiKoristi_Click(object sender, EventArgs e)
		{
			foreach (var param in listi)
			{
				param.Korist = param.Value * (param.Probability / 100);
				Console.WriteLine($"Parameter: {param.Ime}, Value: {param.Value}, Probability: {param.Probability}, Korist: {param.Korist}");
			}

			CalculateKoristForAllNodes();

			List<Parameter> secondDeepestNodes = parametri.Where(p => p.baseNode).ToList();

			if (secondDeepestNodes.Count == 0)
			{
				MessageBox.Show("No second deepest nodes found.");
				return;
			}

			Parameter MaxNode = secondDeepestNodes.OrderByDescending(p => p.Korist).FirstOrDefault();
			Parameter MinNode = secondDeepestNodes.OrderBy(p => p.Korist).FirstOrDefault();
			double avg = secondDeepestNodes.Average(p => p.Korist);

			if (MaxNode == null || MinNode == null)
			{
				MessageBox.Show("No valid nodes to calculate MaxNode or MinNode.");
				return;
			}

			RezultatiForm rezultati = new RezultatiForm(MaxNode, MinNode, avg);
			rezultati.Show();
		}

		private void CalculateKoristForAllNodes()
		{
			foreach (var param in parametri)
			{
				CalculateKorist(param);
			}
		}

		private double CalculateKorist(Parameter param)
		{
			if (param.Podparametri.Count == 0)
			{
				return param.Korist;
			}

			double totalKorist = 0;
			foreach (var child in param.Podparametri)
			{
				totalKorist += CalculateKorist(child);
			}
			param.Korist = totalKorist;
			return totalKorist;
		}
	}
}
