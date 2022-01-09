using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Paciente: Persona
    {
        int dni;
        int edad;
        string obraSocial;

        public int Dni { get => dni; set => dni = value; }

        public int Edad { get => edad; set => edad = value; }
        public string ObraSocial { get => obraSocial; set => obraSocial = value; }

        


        public Paciente(string nombre, string apellido, int dni, int edad, string obraSocial) : base(nombre, apellido)
        {
            this.dni = dni;
            this.edad = edad;
            this.obraSocial = obraSocial;
        }
    }
}
