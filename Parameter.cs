namespace Sistemi_Odločanja
{
	public class Parameter
	{
        public string Ime { get; set; }
		public List<Parameter> Podparametri { get; set; }
		public string Parent { get; set; }
		public double Value { get; set; }
		public double Probability { get; set; }
		public double Korist {  get; set; }
		public bool baseNode { get; set; }

		public Parameter(string ime, List<Parameter> podparametri, string parent, double value, double probability, double korist, bool baseNode) : this(ime, podparametri, parent, value, probability)
		{
			Korist = korist;
			this.baseNode = baseNode;
		}

		public Parameter(string ime, List<Parameter> podparametri, string parent, double value, double probability) : this(ime, podparametri, parent)
		{
			this.Value = value;
			this.Probability = probability;
		}

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
