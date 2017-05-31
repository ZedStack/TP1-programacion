using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Punto4
{
	public abstract class AbsClientes
	{
		public abstract int ID { get; set; }
		public abstract string Nombre { get; set; }
		public abstract string Clave { get; set; }

	}
}
