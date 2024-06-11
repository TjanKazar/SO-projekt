namespace Sistemi_Odločanja
{
	public class Parameter
	{
        public string Ime { get; set; }
		public List<Parameter> Podparametri { get; set; }
		public string Parent { get; set; }

		public Parameter(string ime, List<Parameter> podparametri, string parent)
		{
			Parent = parent;
			Ime = ime;
			Podparametri = podparametri;
		}

		public Parameter(string ime, List<Parameter> podparametri)
		{
			Ime = ime;
			Podparametri = podparametri;
		}
		public Parameter()
		{

		}
	}
}
