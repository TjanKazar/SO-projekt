using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistemi_Odločanja
{
	internal class Alternativa
	{
		public List<Parameter> Parametri { get; set; }
		public string Name { get; set; }

		public Alternativa(List<Parameter> parametri, string name)
		{
			Parametri = parametri;
			Name = name;
		}
	}
}
