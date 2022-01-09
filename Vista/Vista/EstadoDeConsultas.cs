using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaDeClases;

namespace Vista
{
    public partial class EstadoDeConsultas : Form
    {
        HospitalAdministracion administrador;
        public EstadoDeConsultas()
        {
            InitializeComponent();
            administrador = new HospitalAdministracion();
            MostrarEstadoDeConsulta();
        }

        
        //Necesito mostrar la lista de pacientes en espera en esta ventana
        public void MostrarEstadoDeConsulta()
        {
            dgvEstadoDeConsultas.DataSource = null;
            dgvEstadoDeConsultas.DataSource = administrador.ListaDeEspera;
        }

        
    }
}
