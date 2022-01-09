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
    public partial class IngresoDePacientes : Form
    {
        HospitalAdministracion administrador;

        public IngresoDePacientes()
        {
            InitializeComponent();
            administrador = new HospitalAdministracion();
           
            ListaDeMedicos();
        }

        //Boton de "ASIGNAR" instancio nuevo paciente
        private void btnAsignar_Click(object sender, EventArgs e)
        {
            
            Paciente paciente = new Paciente(txtNombre.Text, txtApellido.Text, int.Parse(txtDni.Text), int.Parse(numericEdad.Text),txtObraSocial.Text);
            administrador.AsignarPacientes(paciente);

            txtApellido.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtDni.Text = string.Empty;
            txtObraSocial.Text = string.Empty;
            numericEdad.Text = string.Empty;

           
            

            

        }

        //Cuando se abre la ventana muestro la lista de medicos disponibles, tengo que ver como obtener la fila seleccionada.
        //Cuando tengo esa info, agrego al medico a la lista de medicos ya asignados (que estan atendiendo) y cambio el estado del medico y estado de la consulta

        public void ListaDeMedicos()
        {
            dgvAsignacionDeMedico.DataSource = null;
            dgvAsignacionDeMedico.DataSource = administrador.Medicos;
        }

        


    }
}
