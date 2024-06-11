
using System.Windows.Forms;

namespace Sistemi_Odločanja
{
	public partial class KoristiForm : Form
	{
		List<Parameter> listi;
		List<Korist> koristi;
		public KoristiForm(List<Parameter> parametri)
		{
			listi = new();
			InitializeComponent();
			foreach (Parameter param in parametri)
			{
				if (param.Podparametri.Count() == 0)
				{
					listi.Add(param);
				}
			}
			koristTable.DataSource = listi;
			DataGridViewTextBoxColumn column = new();
			column.Name = "Korist";
			column.HeaderText = "Korist";
			koristTable.Columns.Add(column);

		}

		private void PotrdiKoristi_Click(object sender, EventArgs e)
		{

		}
	}
}
