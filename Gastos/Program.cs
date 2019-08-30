using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gastos
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Gasto> gastos = new List<Gasto>();
			string s = obtenerString();

			string fecha = string.Empty;
			string descripcion = string.Empty;
			string tipo = string.Empty;
			string gasto = string.Empty;
			string acum = string.Empty;
			int cont = 0;
			for (int i = 0; i < s.Length; i++)
			{
				if (s[i].Equals(';'))
				{
					cont++;
					switch (cont)
					{
						case 1:
							fecha = acum.Trim();
							acum = string.Empty;
							continue;
						case 2:
							descripcion = acum.Trim();
							acum = string.Empty;
							continue;
						case 3:
							tipo = acum.Trim();
							acum = string.Empty;
							continue;
						case 4:
							gasto = acum.Trim();
							acum = string.Empty;
							cont = 0;
							gastos.Add(new Gasto(fecha, descripcion, tipo,gasto));
							continue;
						default:
							break;
					}
				}



				if (s[i + 1].Equals(';'))
				{

				}
				acum += s[i];

			}
		}
		public static string obtenerString()
		{
			StringBuilder sb = new StringBuilder();
			sb.Append("26/08/2019;	Ital Pavon Sa 4745				; 			;$ 208,71;");
			sb.Append("25/08/2019;	Wendys Ramos Mejia				; 			;$ 295,00;");
			sb.Append("24/08/2019;	Mercadopago*shell				; 			;$ 205,15;");
			sb.Append("23/08/2019;	Triunfo Coop 0000002458839-029-0;			;$ 734,00;");
			sb.Append("23/08/2019;	Triunfo Coop 0000002444427-029-0;			;$ 690,00;");
			sb.Append("22/08/2019;	Mercadopago*euromacocina		;			;$ 140,00;");
			sb.Append("22/08/2019;	Mercadopago*buller				; 			;$ 540,00;");
			sb.Append("20/08/2019;	Ital Pavon Sa 4745				; 			;$ 220,00;");
			sb.Append("16/08/2019;	Mercadopago*burgerking			;	 		;$ 205,00;");
			sb.Append("15/08/2019;	Al Sandwich, Sandwich1466		;			;$ 202,00;");
			sb.Append("15/08/2019;	Dia Tienda 1505 6634			;	 		;$ 106,17;");
			sb.Append("14/08/2019;	Auxilio 24 0000000349222- -		;			;$ 190,00;");
			sb.Append("14/08/2019;	Auxilio 24 0000000191501- -		;			;$ 160,00;");
			sb.Append("13/08/2019;	Dia Tienda 1505 6634			;	 		;$ 288,35;");
			sb.Append("13/08/2019;	Shell Servinorte				; 			;$ 207,90;");
			sb.Append("11/08/2019;	Kalpat Sa 6987				 	;			;$ 194,04;");
			sb.Append("10/08/2019;	Dia Tienda 1505 6634			;	 		;$ 573,20;");
			sb.Append("09/08/2019;	Mc Donalds -sa2 4268			;	 		;$ 115,00;");
			sb.Append("09/08/2019;	Dia Tienda 301 8375				; 			;$ 166,47;");
			sb.Append("08/08/2019;	Mercadopago*mcdonalds			;			;$ 239,00;");
			sb.Append("07/08/2019;	Antigua Carpinacci				; 			;$ 180,00;");
			sb.Append("07/08/2019;	Estacion Lima Sa 5529			;	 		;$ 199,88;");
			sb.Append("06/08/2019;	Coppel						;Cuota: 01/12	;$ 241,62;");
			sb.Append("04/08/2019;	Dia Tienda 1505 6634			;			;$ 2.337,76;");
			sb.Append("02/08/2019;	Ital Pavon Sa 4745				;	 		;$ 175,65;");
			sb.Append("02/08/2019;	Mercadopago*arredo				;	 		;$ 999,00;");
			sb.Append("02/08/2019;	Mercadopago*farmacity			;		 	;$ 309,60;");
			sb.Append("01/08/2019;	Mercadopago*tuenti				;	 		;$ 290,00;");
			sb.Append("24/07/2019;	Nike Shop Santa Fe			;Cuota: 02/03	;$ 166,33;");
			sb.Append("18/06/2019;	Falabella Florida Ii Esp.4	;Cuota: 03/03	;$ 1.426,65;");
			sb.Append("15/06/2019;	Devre						;Cuota: 03/03	;$ 466,00;");
			sb.Append("15/06/2019;	Falabella Avellaneda Esp.4	;Cuota: 03/03	;$ 999,65;");
			sb.Append("07/03/2019;	Perfumerias Juleriaque		;Cuota: 06/06	;$ 325,38;");
			sb.Append("23/11/2018;	Megatlon					;Cuota: 10/10	;$ 3.508,80;");
			return sb.ToString();
		}
	}

}
