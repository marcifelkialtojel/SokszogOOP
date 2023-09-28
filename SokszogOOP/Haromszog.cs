using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SokszogOOP
{
	internal class Haromszog : Sokszog
	{
		private double bOldal;
		private double cOldal;
		private static Random rnd = new Random();

		public Haromszog(double aOldal, double bOldal, double cOldal) : base(aOldal)
		{
			this.bOldal = bOldal;
			this.cOldal = cOldal;

			if (!IsSzerkesztheto())
			{
				throw new ArgumentException("A háromszög nem szerkeszthető");
            }
		}

		public Haromszog() : base(VeletlenOldalhossz())
		{
			this.bOldal = VeletlenOldalhossz();
			this.cOldal = VeletlenOldalhossz();
			while (!this.IsSzerkesztheto())
			{
				base.AOldal = VeletlenOldalhossz();
				this.bOldal = VeletlenOldalhossz();
				this.cOldal = VeletlenOldalhossz();
			}
		}

		private static int VeletlenOldalhossz()
		{
			return rnd.Next(1, 10000);
		}
		public override double AOldal
		{
			set
			{
				base.AOldal = value;
				if (!IsSzerkesztheto())
				{
					throw new ArgumentException("A háromszög nem szerkeszthető", nameof(value));
				}
			}
		}
		public double BOldal
		{ get => bOldal;
			set
			{
				this.bOldal = value;
				if (!IsSzerkesztheto())
				{
					throw new ArgumentException("A háromszög nem szerkeszthető", nameof(value));
				}
			}
		}
		public double COldal
		{ get => cOldal;
			set
			{
				this.cOldal = value;
				if (!IsSzerkesztheto())
				{
					throw new ArgumentException("A háromszög nem szerkeszthető", nameof(value));
				}
			}
		}

		

			private bool IsSzerkesztheto()
		{
			return this.AOldal + this.bOldal > this.cOldal
				&& this.AOldal + this.cOldal > this.bOldal
				&& this.bOldal + this.cOldal > this.AOldal;
		}

		public override double GetKerulet()
		{

			return this.AOldal + this.BOldal + this.COldal;
		}

		public override double GetTerulet()
		{
			double s = GetKerulet() / 2;
			return Math.Sqrt(s * (s-this.AOldal) * (s-this.BOldal) * (s-this.COldal) );
		}

		public override string ToString()
		{
			return $"A: {this.AOldal} - B: {this.bOldal} - C: {this.cOldal} - {base.ToString()}";
		}
	}
}
