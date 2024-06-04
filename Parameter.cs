using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistemi_Odločanja
{
	public class Parameter
	{
        public string Ime { get; set; }
		public List<Parameter> Podparametri { get; set; }

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
