namespace DentalCare_System.Interfaz
{
    partial class Citas
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
            this.label1 = new System.Windows.Forms.Label();
            this.citasControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DiaActual = new System.Windows.Forms.Label();
            this.ListadoCitas = new System.Windows.Forms.DataGridView();
            this.hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnAtras = new System.Windows.Forms.Button();
            this.BtnSiguiente = new System.Windows.Forms.Button();
            this.TxtDiaActual = new System.Windows.Forms.TextBox();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.AgregarCita = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.TxtFecha = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtDoctor = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.citasControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListadoCitas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(466, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Doctor";
            // 
            // citasControl
            // 
            this.citasControl.Controls.Add(this.tabPage1);
            this.citasControl.Controls.Add(this.tabPage2);
            this.citasControl.Font = new System.Drawing.Font("Century", 11.25F);
            this.citasControl.Location = new System.Drawing.Point(12, 26);
            this.citasControl.Name = "citasControl";
            this.citasControl.SelectedIndex = 0;
            this.citasControl.Size = new System.Drawing.Size(933, 517);
            this.citasControl.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.DiaActual);
            this.tabPage1.Controls.Add(this.ListadoCitas);
            this.tabPage1.Controls.Add(this.BtnAtras);
            this.tabPage1.Controls.Add(this.BtnSiguiente);
            this.tabPage1.Controls.Add(this.TxtDiaActual);
            this.tabPage1.Controls.Add(this.BtnEditar);
            this.tabPage1.Controls.Add(this.AgregarCita);
            this.tabPage1.Controls.Add(this.BtnEliminar);
            this.tabPage1.Controls.Add(this.TxtFecha);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.TxtDoctor);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Font = new System.Drawing.Font("Century", 9.25F);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(925, 486);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Citas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // DiaActual
            // 
            this.DiaActual.AutoSize = true;
            this.DiaActual.Font = new System.Drawing.Font("Century", 16.25F);
            this.DiaActual.Location = new System.Drawing.Point(267, 80);
            this.DiaActual.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.DiaActual.Name = "DiaActual";
            this.DiaActual.Size = new System.Drawing.Size(48, 27);
            this.DiaActual.TabIndex = 41;
            this.DiaActual.Text = "Dia";
            // 
            // ListadoCitas
            // 
            this.ListadoCitas.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ListadoCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListadoCitas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hora,
            this.paciente,
            this.motivo});
            this.ListadoCitas.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.ListadoCitas.Location = new System.Drawing.Point(18, 116);
            this.ListadoCitas.Name = "ListadoCitas";
            this.ListadoCitas.Size = new System.Drawing.Size(868, 364);
            this.ListadoCitas.TabIndex = 40;
            // 
            // hora
            // 
            this.hora.HeaderText = "Hora";
            this.hora.Name = "hora";
            // 
            // paciente
            // 
            this.paciente.HeaderText = "Paciente";
            this.paciente.Name = "paciente";
            this.paciente.Width = 300;
            // 
            // motivo
            // 
            this.motivo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.motivo.HeaderText = "Motivo";
            this.motivo.Name = "motivo";
            // 
            // BtnAtras
            // 
            this.BtnAtras.Location = new System.Drawing.Point(22, 78);
            this.BtnAtras.Name = "BtnAtras";
            this.BtnAtras.Size = new System.Drawing.Size(98, 30);
            this.BtnAtras.TabIndex = 38;
            this.BtnAtras.Text = "Atras";
            this.BtnAtras.UseVisualStyleBackColor = true;
            // 
            // BtnSiguiente
            // 
            this.BtnSiguiente.Location = new System.Drawing.Point(792, 79);
            this.BtnSiguiente.Name = "BtnSiguiente";
            this.BtnSiguiente.Size = new System.Drawing.Size(98, 30);
            this.BtnSiguiente.TabIndex = 37;
            this.BtnSiguiente.Text = "Siguiente";
            this.BtnSiguiente.UseVisualStyleBackColor = true;
            // 
            // TxtDiaActual
            // 
            this.TxtDiaActual.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.TxtDiaActual.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtDiaActual.Font = new System.Drawing.Font("Century", 15.25F);
            this.TxtDiaActual.Location = new System.Drawing.Point(323, 84);
            this.TxtDiaActual.Name = "TxtDiaActual";
            this.TxtDiaActual.Size = new System.Drawing.Size(168, 25);
            this.TxtDiaActual.TabIndex = 36;
            // 
            // BtnEditar
            // 
            this.BtnEditar.Location = new System.Drawing.Point(673, 80);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(98, 30);
            this.BtnEditar.TabIndex = 34;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = true;
            // 
            // AgregarCita
            // 
            this.AgregarCita.Location = new System.Drawing.Point(740, 18);
            this.AgregarCita.Name = "AgregarCita";
            this.AgregarCita.Size = new System.Drawing.Size(98, 30);
            this.AgregarCita.TabIndex = 33;
            this.AgregarCita.Text = "Agregar";
            this.AgregarCita.UseVisualStyleBackColor = true;
            this.AgregarCita.Click += new System.EventHandler(this.Agregar_Click_1);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(557, 80);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(98, 30);
            this.BtnEliminar.TabIndex = 32;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // TxtFecha
            // 
            this.TxtFecha.Location = new System.Drawing.Point(74, 21);
            this.TxtFecha.Margin = new System.Windows.Forms.Padding(5);
            this.TxtFecha.Name = "TxtFecha";
            this.TxtFecha.Size = new System.Drawing.Size(347, 22);
            this.TxtFecha.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-48, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 30;
            this.label2.Text = "Fecha";
            // 
            // TxtDoctor
            // 
            this.TxtDoctor.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.TxtDoctor.CausesValidation = false;
            this.TxtDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TxtDoctor.Location = new System.Drawing.Point(523, 19);
            this.TxtDoctor.Margin = new System.Windows.Forms.Padding(5);
            this.TxtDoctor.Name = "TxtDoctor";
            this.TxtDoctor.Size = new System.Drawing.Size(209, 24);
            this.TxtDoctor.TabIndex = 29;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(925, 507);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Citas Pendientes";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 42;
            this.label3.Text = "Fecha";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label9.Location = new System.Drawing.Point(333, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 33);
            this.label9.TabIndex = 40;
            this.label9.Text = "Citas";
            // 
            // Citas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 566);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.citasControl);
            this.Font = new System.Drawing.Font("Century", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Citas";
            this.Text = "Citas";
            this.citasControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListadoCitas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl citasControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView ListadoCitas;
        private System.Windows.Forms.Button BtnAtras;
        private System.Windows.Forms.Button BtnSiguiente;
        private System.Windows.Forms.TextBox TxtDiaActual;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button AgregarCita;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.DateTimePicker TxtFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox TxtDoctor;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label DiaActual;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn paciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn motivo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
    }
}