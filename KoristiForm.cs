using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Reflection.Metadata;
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
			koristTable.Columns[nameof(Parameter.Ime)].HeaderText = "Parameter Name";
			koristTable.Columns[nameof(Parameter.Value)].HeaderText = "Value";
			koristTable.Columns[nameof(Parameter.Probability)].HeaderText = "Probability";
			koristTable.Columns[nameof(Parameter.Korist)].Visible = false;
		}

		private void PotrdiKoristi_Click(object sender, EventArgs e)
		{
			foreach (var param in listi)
			{
				param.Korist = param.Value * (param.Probability / 100);
				Console.WriteLine($"Parameter: {param.Ime}, Value: {param.Value}, Probability: {param.Probability}, Korist: {param.Korist}");
			}

			List<Parameter> parentNodes = parametri.Where(p => p.Podparametri.Count() != 0).ToList();
			foreach (var param in parentNodes)
			{
				double parentKorist = 0;
				foreach(var parameter in param.Podparametri)
				{
					parentKorist += parameter.Korist;
                   
                }
				param.Korist = parentKorist;
				Console.WriteLine("Preverjanje vrednosti v Parent Param: Parent Param name : " + param.Ime + " Parent Param Korist : " + param.Korist);
			}
			foreach (var param in parentNodes)
			{

				Console.WriteLine("Preverjanje vrednosti v listu: Podparameter name : " + param.Ime + " Podparameter Korist : " + param.Korist);
			}
			Parameter MaxNode = parentNodes.OrderByDescending(p => p.Korist).First();
			Parameter MinNode = parentNodes.OrderBy(p => p.Korist).First();
			double avg = 0;
			foreach (var param in parentNodes)
			{
				avg += param.Korist;
			}
			avg = avg / parentNodes.Count();
			RezultatiForm rezultati = new(MaxNode, MinNode, avg);
			rezultati.Show();
		}
	}
}