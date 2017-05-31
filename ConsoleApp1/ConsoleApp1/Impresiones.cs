using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Punto4
{
	public class Impresiones
	{
		public void ImprimeCliente(AbsClientes cliente)
		{
			Console.WriteLine(cliente.Nombre);
			Console.WriteLine(cliente.ID);
			Console.WriteLine(cliente.Clave);
			Console.ReadKey();
		}
	}
}
