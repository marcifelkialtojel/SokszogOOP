using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SokszogOOP
{
	internal class Teglalap : Sokszog
	{
		private double bOldal;

		public Teglalap( double aOldal,double bOldal) : base(aOldal)
		{
			this.bOldal = bOldal;
		}

		public double BOldal {  get => bOldal; set => bOldal = value; }

		public override double GetKerulet()
		{
			return 2 * (this.AOldal + this.BOldal);
		}

		public override double GetTerulet()
		{
			return this.AOldal * this.BOldal;
		}

		public override string ToString()
		{
			return $"A: {this.AOldal} - B: {this.bOldal} - {base.ToString()}";
		}
	}
}
