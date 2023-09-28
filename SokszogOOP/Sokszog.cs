using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SokszogOOP
{
	internal abstract class Sokszog
	{
		private double aOldal;

		public Sokszog(double aOldal)
		{
			this.aOldal = aOldal;
		}

		public virtual double AOldal { get => aOldal; set => aOldal = value; }

		public abstract double GetKerulet();

		public abstract double GetTerulet();

		public override string ToString()
		{
			return $"K: {this.GetKerulet()} - T {this.GetTerulet()} ";
		}
	}
}
