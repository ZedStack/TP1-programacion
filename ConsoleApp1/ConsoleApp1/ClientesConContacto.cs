using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Punto4
{
	class ClientesConContacto : ClientesBase    //Herencia
	{
		public ClientesConContacto()
		{
			_Direccion = new Direcciones();
		}

		public ClientesConContacto(int pID, string pNombre, string pClave, string pTelefono1, string pTelefono2, string pEmail, string pCalle, string pMunicipio, string pLocalidad, string pPais)	//polimorfismo
		{
			ID = pID;
			Nombre = pNombre;
			Clave = pClave;
			Telefono1 = pTelefono1;
			Telefono2 = pTelefono2;
			Email = pEmail;
			_Direccion = new Direcciones();
			Direccion.Calle = pCalle;
			Direccion.Municipio = pMunicipio;
			Direccion.Localidad = pLocalidad;
			Direccion.Pais = pPais;
		}

		public string Telefono1 { get; set; }
		public string Telefono2 { get; set; }
		public string Email { get; set; }

		private Direcciones _Direccion;

		public Direcciones Direccion { get => _Direccion; set => _Direccion = value; }  //Encapsulamiento

	}
}
