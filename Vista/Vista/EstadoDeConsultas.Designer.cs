
namespace Vista
{
    partial class EstadoDeConsultas
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
            this.labelConsultasActivas = new System.Windows.Forms.Label();
            this.dgvEstadoDeConsultas = new System.Windows.Forms.DataGridView();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFinalizarConsulta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadoDeConsultas)).BeginInit();
            this.SuspendLayout();
            // 
            // labelConsultasActivas
            // 
            this.labelConsultasActivas.AutoSize = true;
            this.labelConsultasActivas.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelConsultasActivas.Location = new System.Drawing.Point(31, 31);
            this.labelConsultasActivas.Name = "labelConsultasActivas";
            this.labelConsultasActivas.Size = new System.Drawing.Size(152, 23);
            this.labelConsultasActivas.TabIndex = 0;
            this.labelConsultasActivas.Text = "Consultas activas";
            // 
            // dgvEstadoDeConsultas
            // 
            this.dgvEstadoDeConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstadoDeConsultas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Estado});
            this.dgvEstadoDeConsultas.Location = new System.Drawing.Point(31, 57);
            this.dgvEstadoDeConsultas.Name = "dgvEstadoDeConsultas";
            this.dgvEstadoDeConsultas.RowTemplate.Height = 25;
            this.dgvEstadoDeConsultas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEstadoDeConsultas.Size = new System.Drawing.Size(738, 326);
            this.dgvEstadoDeConsultas.TabIndex = 1;
           
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            // 
            // btnFinalizarConsulta
            // 
            this.btnFinalizarConsulta.Location = new System.Drawing.Point(590, 398);
            this.btnFinalizarConsulta.Name = "btnFinalizarConsulta";
            this.btnFinalizarConsulta.Size = new System.Drawing.Size(179, 34);
            this.btnFinalizarConsulta.TabIndex = 2;
            this.btnFinalizarConsulta.Text = "Finalizar";
            this.btnFinalizarConsulta.UseVisualStyleBackColor = true;
            // 
            // EstadoDeConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 459);
            this.Controls.Add(this.btnFinalizarConsulta);
            this.Controls.Add(this.dgvEstadoDeConsultas);
            this.Controls.Add(this.labelConsultasActivas);
            this.Name = "EstadoDeConsultas";
            this.Text = "Estado de consultas";
         
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadoDeConsultas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelConsultasActivas;
        private System.Windows.Forms.DataGridView dgvEstadoDeConsultas;
        private System.Windows.Forms.Button btnFinalizarConsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}