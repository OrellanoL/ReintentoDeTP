using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public enum Especialidades
    {
        AnalisisClinicos,
        Cardiologia,
        CirugiaGeneral,
        Dermatologia,
        Neurologia,
        Oftalmologia,
        Odontologia,
        Pediatria,
        Traumatologia,
        Urgencias

    }


    //Esta clase va a contener los metodos que van a permitir agregar pacientes, iniciar consultas y todos los temas administrativos que será manejado por un empleado del hospital.
    public class HospitalAdministracion
    {
        List<Paciente> listaDeEspera;
        List<Medico> medicos;
        List<Medico> listaDeMedicosAsignados;
        



       
        //Constructor para instanciar las listas
        public HospitalAdministracion()
        {
            listaDeEspera = new List<Paciente>();
            {
                new Paciente("Lud", "Orel", 12321312, 25, "Cobertura Baisca"); //Quiero que este paciente se vea en la ventana "ESTADO DE CONSULTA"
            }
            medicos = new List<Medico>()

            {
                new Medico ("Enrique", "Verne", Especialidades.AnalisisClinicos),
                new Medico("Josefina", "Brunett", Especialidades.Cardiologia),
                new Medico ("Juan ", "Bosch", Especialidades.CirugiaGeneral),
                new Medico ("Julieta", "Diaz", Especialidades.Dermatologia),
                new Medico ("Luciano", "Ojeda", Especialidades.Neurologia),
                new Medico ("Maria", "Bruno", Especialidades.Oftalmologia),
                new Medico ("Juan Carlos", "Marinelli", Especialidades.Odontologia),
                new Medico ("Luis", "Enrique", Especialidades.Pediatria),
                new Medico ("Patricia", "Vidal", Especialidades.Traumatologia),
                new Medico ("Julia", "Spinetta", Especialidades.Urgencias),

            };

            listaDeMedicosAsignados = new List<Medico>();
        }
       
        //Propiedades
        public List<Paciente> ListaDeEspera { get => listaDeEspera; set => listaDeEspera = value; }
        public List<Medico> Medicos { get => medicos; set => medicos = value; }
        public List<Medico> ListaDeMedicosAsignados { get => listaDeMedicosAsignados; set => listaDeMedicosAsignados = value; }

        private bool EstadoDelMedico (Medico m)
        {
            if (medicos.Contains(m) == true)
            {
                return true; //Si esta atendiendo retorna verdadero
            }
            else
            {
                return false;
            }
        }

        ///Metodo para asignar pacientes a la lista de espera.
        
        public void AsignarPacientes(Paciente p)
        {
            listaDeEspera.Add(p);
        }

        public void EliminarPaciente(Paciente p)
        {
            listaDeEspera.Remove(p);
        }

        public void AsignarMedico ( Medico m)
        {
            listaDeMedicosAsignados.Add(m);

        }


    }
}
