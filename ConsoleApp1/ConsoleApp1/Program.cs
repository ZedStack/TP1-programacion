using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Punto4
{
	class Program
	{
		static void Main(string[] args)
		{
			ClientesConContacto cliente = new ClientesConContacto(0, "Luke", "25483", "44889635", "48536921", "luke@gmail.com", "Calle falsa 123", "3 de Febrero", "Ciudadela", "Argentina");

			Impresiones Impresion;
			Impresion = new Impresiones();
			Impresion.ImprimeCliente(cliente);
		}
	}
}
