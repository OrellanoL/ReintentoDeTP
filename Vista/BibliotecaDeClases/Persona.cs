﻿using System;

namespace BibliotecaDeClases
{
    public class Persona
    {
        private string nombre;
        private string apellido;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }

        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }
    }
}
