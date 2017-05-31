using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Punto4
{
	public class ClientesBase : AbsClientes
	{
		public ClientesBase()
		{
			ID = 0;
			Nombre = string.Empty;
			Clave = string.Empty;
		}

		public ClientesBase(int pID, string pNombre, string pClave)
		{
			ID = pID;
			Nombre = pNombre;
			Clave = pClave;
		}

		public override int ID { get; set; }
		public override string Nombre { get; set; }
		public override string Clave { get; set; }

	}
}