
namespace Vista
{
    partial class IngresoDePacientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gBoxDetalleDelPaciente = new System.Windows.Forms.GroupBox();
            this.txtObraSocial = new System.Windows.Forms.TextBox();
            this.numericEdad = new System.Windows.Forms.NumericUpDown();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.labelObraSocial = new System.Windows.Forms.Label();
            this.labelEdad = new System.Windows.Forms.Label();
            this.labelDNI = new System.Windows.Forms.Label();
            this.labelApellido = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.groupBoxAsignacionDeTurno = new System.Windows.Forms.GroupBox();
            this.dgvAsignacionDeMedico = new System.Windows.Forms.DataGridView();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.gBoxDetalleDelPaciente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericEdad)).BeginInit();
            this.groupBoxAsignacionDeTurno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsignacionDeMedico)).BeginInit();
            this.SuspendLayout();
            // 
            // gBoxDetalleDelPaciente
            // 
            this.gBoxDetalleDelPaciente.Controls.Add(this.txtObraSocial);
            this.gBoxDetalleDelPaciente.Controls.Add(this.numericEdad);
            this.gBoxDetalleDelPaciente.Controls.Add(this.txtDni);
            this.gBoxDetalleDelPaciente.Controls.Add(this.txtApellido);
            this.gBoxDetalleDelPaciente.Controls.Add(this.txtNombre);
            this.gBoxDetalleDelPaciente.Controls.Add(this.labelObraSocial);
            this.gBoxDetalleDelPaciente.Controls.Add(this.labelEdad);
            this.gBoxDetalleDelPaciente.Controls.Add(this.labelDNI);
            this.gBoxDetalleDelPaciente.Controls.Add(this.labelApellido);
            this.gBoxDetalleDelPaciente.Controls.Add(this.labelNombre);
            this.gBoxDetalleDelPaciente.Location = new System.Drawing.Point(29, 41);
            this.gBoxDetalleDelPaciente.Name = "gBoxDetalleDelPaciente";
            this.gBoxDetalleDelPaciente.Size = new System.Drawing.Size(829, 257);
            this.gBoxDetalleDelPaciente.TabIndex = 0;
            this.gBoxDetalleDelPaciente.TabStop = false;
            this.gBoxDetalleDelPaciente.Text = "Detalle del paciente";
            // 
            // txtObraSocial
            // 
            this.txtObraSocial.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtObraSocial.Location = new System.Drawing.Point(133, 205);
            this.txtObraSocial.Name = "txtObraSocial";
            this.txtObraSocial.Size = new System.Drawing.Size(228, 31);
            this.txtObraSocial.TabIndex = 10;
            // 
            // numericEdad
            // 
            this.numericEdad.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericEdad.Location = new System.Drawing.Point(133, 157);
            this.numericEdad.Name = "numericEdad";
            this.numericEdad.Size = new System.Drawing.Size(120, 31);
            this.numericEdad.TabIndex = 9;
            // 
            // txtDni
            // 
            this.txtDni.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDni.Location = new System.Drawing.Point(133, 114);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(228, 31);
            this.txtDni.TabIndex = 8;
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtApellido.Location = new System.Drawing.Point(133, 73);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(228, 31);
            this.txtApellido.TabIndex = 7;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombre.Location = new System.Drawing.Point(133, 35);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(228, 31);
            this.txtNombre.TabIndex = 6;
            // 
            // labelObraSocial
            // 
            this.labelObraSocial.AutoSize = true;
            this.labelObraSocial.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelObraSocial.Location = new System.Drawing.Point(15, 205);
            this.labelObraSocial.Name = "labelObraSocial";
            this.labelObraSocial.Size = new System.Drawing.Size(105, 23);
            this.labelObraSocial.TabIndex = 5;
            this.labelObraSocial.Text = "Obra Social";
            // 
            // labelEdad
            // 
            this.labelEdad.AutoSize = true;
            this.labelEdad.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEdad.Location = new System.Drawing.Point(37, 159);
            this.labelEdad.Name = "labelEdad";
            this.labelEdad.Size = new System.Drawing.Size(52, 23);
            this.labelEdad.TabIndex = 4;
            this.labelEdad.Text = "Edad";
            // 
            // labelDNI
            // 
            this.labelDNI.AutoSize = true;
            this.labelDNI.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDNI.Location = new System.Drawing.Point(37, 122);
            this.labelDNI.Name = "labelDNI";
            this.labelDNI.Size = new System.Drawing.Size(44, 23);
            this.labelDNI.TabIndex = 3;
            this.labelDNI.Text = "DNI";
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelApellido.Location = new System.Drawing.Point(27, 81);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(79, 23);
            this.labelApellido.TabIndex = 2;
            this.labelApellido.Text = "Apellido";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNombre.Location = new System.Drawing.Point(27, 43);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(77, 23);
            this.labelNombre.TabIndex = 1;
            this.labelNombre.Text = "Nombre";
            // 
            // groupBoxAsignacionDeTurno
            // 
            this.groupBoxAsignacionDeTurno.Controls.Add(this.dgvAsignacionDeMedico);
            this.groupBoxAsignacionDeTurno.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxAsignacionDeTurno.Location = new System.Drawing.Point(29, 320);
            this.groupBoxAsignacionDeTurno.Name = "groupBoxAsignacionDeTurno";
            this.groupBoxAsignacionDeTurno.Size = new System.Drawing.Size(829, 193);
            this.groupBoxAsignacionDeTurno.TabIndex = 1;
            this.groupBoxAsignacionDeTurno.TabStop = false;
            this.groupBoxAsignacionDeTurno.Text = "Asignación de turno";
            // 
            // dgvAsignacionDeMedico
            // 
            this.dgvAsignacionDeMedico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsignacionDeMedico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Estado});
            this.dgvAsignacionDeMedico.Location = new System.Drawing.Point(15, 22);
            this.dgvAsignacionDeMedico.Name = "dgvAsignacionDeMedico";
            this.dgvAsignacionDeMedico.RowTemplate.Height = 25;
            this.dgvAsignacionDeMedico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAsignacionDeMedico.Size = new System.Drawing.Size(796, 155);
            this.dgvAsignacionDeMedico.TabIndex = 0;
            // 
            // Estado
            // 
            this.Estado.Frozen = true;
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // btnAsignar
            // 
            this.btnAsignar.Location = new System.Drawing.Point(300, 539);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(201, 49);
            this.btnAsignar.TabIndex = 19;
            this.btnAsignar.Text = "Asignar";
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // IngresoDePacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 643);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.groupBoxAsignacionDeTurno);
            this.Controls.Add(this.gBoxDetalleDelPaciente);
            this.Name = "IngresoDePacientes";
            this.Text = "Ingreso de pacientes";
            this.gBoxDetalleDelPaciente.ResumeLayout(false);
            this.gBoxDetalleDelPaciente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericEdad)).EndInit();
            this.groupBoxAsignacionDeTurno.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsignacionDeMedico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxDetalleDelPaciente;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label labelObraSocial;
        private System.Windows.Forms.Label labelEdad;
        private System.Windows.Forms.Label labelDNI;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.NumericUpDown numericEdad;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.GroupBox groupBoxAsignacionDeTurno;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.TextBox txtObraSocial;
        private System.Windows.Forms.DataGridView dgvAsignacionDeMedico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}