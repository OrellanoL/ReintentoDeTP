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
    public partial class DetalleDeEspecialidades : Form
    {
        HospitalAdministracion administrador;

        public DetalleDeEspecialidades()
        {
            InitializeComponent();
            administrador = new HospitalAdministracion();
            
        }
        
        private void MostrarEspecialidades()
        {
            dgvDetalleEspecialidades.DataSource = null;
            dgvDetalleEspecialidades.DataSource = administrador.Medicos;
        }
        

        private void DetalleDeEspecialidades_Load(object sender, EventArgs e)
        {
            MostrarEspecialidades();
        }

        
    }
}
