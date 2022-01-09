using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmPrincipal : Form
    {
        EstadoDeConsultas admin;
        public FrmPrincipal()
        {
            InitializeComponent();
            
        }

        private void btnAgregarPaciente_Click(object sender, EventArgs e)
        {
            IngresoDePacientes ingresoNuevoPaciente = new IngresoDePacientes();
            ingresoNuevoPaciente.ShowDialog();

            


        }

        private void btnEspecialidades_Click(object sender, EventArgs e)
        {
            DetalleDeEspecialidades ventanaDeEspecialidades = new DetalleDeEspecialidades();
            ventanaDeEspecialidades.ShowDialog();
            
            
        }

        private void btnEstadoDeConsultas_Click(object sender, EventArgs e)
        {
            EstadoDeConsultas estadoDeConsultas = new EstadoDeConsultas();
            estadoDeConsultas.ShowDialog();

        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
