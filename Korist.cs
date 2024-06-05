using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistemi_Odločanja
{
	public class Korist
	{
		public Parameter param {  get; set; }
		public string name { get; set; }

		public Korist(Parameter param, string name)
		{
			this.param = param;
			this.name = name;
		}
	}
}
