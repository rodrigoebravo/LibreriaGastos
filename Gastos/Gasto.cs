using PeriodoProj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gastos
{
	public class Gasto
	{
		public Periodo periodoGasto { get { return new Periodo(this.Fecha); } }
		public DateTime Fecha { get; }
		public int Cuota { get; set; }
		public int CuotaTotal { get; set; }
		public double gasto { get; set; }
		public string descripcion{ get; set; }

		public Gasto(string fecha, string descripcion, string tipo, string gasto)
		{
			var fech = fecha.Split('/');
			this.Fecha = new DateTime(int.Parse(fech[2]), int.Parse(fech[1]), int.Parse(fech[0]));
			
			if (!string.IsNullOrEmpty(tipo))
			{
				var tip = tipo.Substring(7).Split('/');
				Cuota = int.Parse(tip[0]);
				CuotaTotal = int.Parse(tip[1]);
			}
			//this.Cuota= 
			
		}
	}
}
