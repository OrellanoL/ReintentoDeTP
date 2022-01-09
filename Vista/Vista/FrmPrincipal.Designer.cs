
namespace Vista
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAgregarPaciente = new System.Windows.Forms.Button();
            this.btnEspecialidades = new System.Windows.Forms.Button();
            this.btnEstadoDeConsultas = new System.Windows.Forms.Button();
            this.btnEstadisticas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAgregarPaciente
            // 
            this.btnAgregarPaciente.Location = new System.Drawing.Point(68, 67);
            this.btnAgregarPaciente.Name = "btnAgregarPaciente";
            this.btnAgregarPaciente.Size = new System.Drawing.Size(257, 59);
            this.btnAgregarPaciente.TabIndex = 0;
            this.btnAgregarPaciente.Text = "Agregar paciente";
            this.btnAgregarPaciente.UseVisualStyleBackColor = true;
            this.btnAgregarPaciente.Click += new System.EventHandler(this.btnAgregarPaciente_Click);
            // 
            // btnEspecialidades
            // 
            this.btnEspecialidades.Location = new System.Drawing.Point(68, 141);
            this.btnEspecialidades.Name = "btnEspecialidades";
            this.btnEspecialidades.Size = new System.Drawing.Size(257, 59);
            this.btnEspecialidades.TabIndex = 1;
            this.btnEspecialidades.Text = "Especialidades";
            this.btnEspecialidades.UseVisualStyleBackColor = true;
            this.btnEspecialidades.Click += new System.EventHandler(this.btnEspecialidades_Click);
            // 
            // btnEstadoDeConsultas
            // 
            this.btnEstadoDeConsultas.Location = new System.Drawing.Point(68, 216);
            this.btnEstadoDeConsultas.Name = "btnEstadoDeConsultas";
            this.btnEstadoDeConsultas.Size = new System.Drawing.Size(257, 59);
            this.btnEstadoDeConsultas.TabIndex = 2;
            this.btnEstadoDeConsultas.Text = "Estado de consultas";
            this.btnEstadoDeConsultas.UseVisualStyleBackColor = true;
            this.btnEstadoDeConsultas.Click += new System.EventHandler(this.btnEstadoDeConsultas_Click);
            // 
            // btnEstadisticas
            // 
            this.btnEstadisticas.Location = new System.Drawing.Point(68, 291);
            this.btnEstadisticas.Name = "btnEstadisticas";
            this.btnEstadisticas.Size = new System.Drawing.Size(257, 59);
            this.btnEstadisticas.TabIndex = 3;
            this.btnEstadisticas.Text = "Estadísticas Históricas";
            this.btnEstadisticas.UseVisualStyleBackColor = true;
            this.btnEstadisticas.Click += new System.EventHandler(this.btnEstadisticas_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 450);
            this.Controls.Add(this.btnEstadisticas);
            this.Controls.Add(this.btnEstadoDeConsultas);
            this.Controls.Add(this.btnEspecialidades);
            this.Controls.Add(this.btnAgregarPaciente);
            this.Name = "FrmPrincipal";
            this.Text = "Clinica - Administración";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarPaciente;
        private System.Windows.Forms.Button btnEspecialidades;
        private System.Windows.Forms.Button btnEstadoDeConsultas;
        private System.Windows.Forms.Button btnEstadisticas;
    }
}

