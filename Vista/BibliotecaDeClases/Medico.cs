using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Medico: Persona
    {

        Especialidades especialidad;

        public Medico(string nombre, string apellido, Especialidades especialidad) : base(nombre, apellido)
        {
            this.especialidad = especialidad;
        }

        public Especialidades Especialidad { get => especialidad; set => especialidad = value; }
    }
}
