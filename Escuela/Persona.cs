﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escuela
{
    public abstract class Persona
    {
        public string Nombre { get; set; }
        public  string Apellido { get; set; }

        public Persona (string nombre , string apellido) {
			this.Nombre = nombre;
			this.Apellido = apellido;
		}
      
	}
}
