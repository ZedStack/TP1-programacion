using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Punto4
{
	public class Direcciones
	{
		public Direcciones()
		{
			Calle = string.Empty;
			Localidad = string.Empty;
			Municipio = string.Empty;
			Pais = string.Empty;
		}
		public string Calle { get; set; }
		public string Localidad { get; set; }
		public string Municipio { get; set; }
		public string Pais { get; set; }
	}
}
