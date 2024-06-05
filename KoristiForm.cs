
namespace Sistemi_Odločanja
{
	public partial class KoristiForm : Form
	{
		List<Parameter> listi;
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
		}

	}
}
