using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escuela
{
	public class Estudiante : Persona
	{
		private int Id{ get; set; }
		public Estudiante(string nombre, string apellido, int id)
		   : base(nombre, apellido)
		{ Id = id; }
		public int id{
			get {
				return Id; 
			}
			set {Id = value; }

		}
}
	}

