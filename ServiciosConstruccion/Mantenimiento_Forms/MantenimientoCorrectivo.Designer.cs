namespace CapaPresentacion.Mantenimiento_Forms
{
    partial class MantenimientoCorrectivo
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
            label9 = new Label();
            btnConsultarMc = new Button();
            btnSalirMc = new Button();
            dtPickerFechaMc = new DateTimePicker();
            btnDesahabilitarMc = new Button();
            btnEditarMc = new Button();
            label8 = new Label();
            dgvMantenimientoCorrectivo = new DataGridView();
            Planificacion = new GroupBox();
            txtDiagnostico = new TextBox();
            cbMaquinaria = new ComboBox();
            cbTecnico = new ComboBox();
            btnCancelarMc = new Button();
            btnModificarMc = new Button();
            btnRegistrarOrden = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            dtPickerFechaOrden = new DateTimePicker();
            label4 = new Label();
            label3 = new Label();
            txtOrden = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnNuevoMc = new Button();
            txtOrdenMc = new TextBox();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvMantenimientoCorrectivo).BeginInit();
            Planificacion.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(341, 45);
            label9.Name = "label9";
            label9.Size = new Size(103, 20);
            label9.TabIndex = 31;
            label9.Text = "Nro de Orden:";
            // 
            // btnConsultarMc
            // 
            btnConsultarMc.Location = new Point(429, 144);
            btnConsultarMc.Name = "btnConsultarMc";
            btnConsultarMc.Size = new Size(114, 57);
            btnConsultarMc.TabIndex = 27;
            btnConsultarMc.Text = "Consultar";
            btnConsultarMc.UseVisualStyleBackColor = true;
            // 
            // btnSalirMc
            // 
            btnSalirMc.Location = new Point(744, 302);
            btnSalirMc.Name = "btnSalirMc";
            btnSalirMc.Size = new Size(114, 57);
            btnSalirMc.TabIndex = 33;
            btnSalirMc.Text = "Salir";
            btnSalirMc.UseVisualStyleBackColor = true;
            // 
            // dtPickerFechaMc
            // 
            dtPickerFechaMc.Location = new Point(27, 87);
            dtPickerFechaMc.Name = "dtPickerFechaMc";
            dtPickerFechaMc.Size = new Size(289, 27);
            dtPickerFechaMc.TabIndex = 30;
            // 
            // btnDesahabilitarMc
            // 
            btnDesahabilitarMc.Location = new Point(624, 302);
            btnDesahabilitarMc.Name = "btnDesahabilitarMc";
            btnDesahabilitarMc.Size = new Size(114, 57);
            btnDesahabilitarMc.TabIndex = 24;
            btnDesahabilitarMc.Text = "Desahabilitar";
            btnDesahabilitarMc.UseVisualStyleBackColor = true;
            // 
            // btnEditarMc
            // 
            btnEditarMc.Location = new Point(495, 302);
            btnEditarMc.Name = "btnEditarMc";
            btnEditarMc.Size = new Size(114, 57);
            btnEditarMc.TabIndex = 26;
            btnEditarMc.Text = "Editar";
            btnEditarMc.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(27, 45);
            label8.Name = "label8";
            label8.Size = new Size(50, 20);
            label8.TabIndex = 28;
            label8.Text = "Fecha:";
            // 
            // dgvMantenimientoCorrectivo
            // 
            dgvMantenimientoCorrectivo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMantenimientoCorrectivo.Location = new Point(366, 60);
            dgvMantenimientoCorrectivo.Name = "dgvMantenimientoCorrectivo";
            dgvMantenimientoCorrectivo.RowHeadersWidth = 51;
            dgvMantenimientoCorrectivo.Size = new Size(550, 211);
            dgvMantenimientoCorrectivo.TabIndex = 23;
            // 
            // Planificacion
            // 
            Planificacion.Controls.Add(txtDiagnostico);
            Planificacion.Controls.Add(cbMaquinaria);
            Planificacion.Controls.Add(cbTecnico);
            Planificacion.Controls.Add(btnCancelarMc);
            Planificacion.Controls.Add(btnModificarMc);
            Planificacion.Controls.Add(btnRegistrarOrden);
            Planificacion.Controls.Add(label7);
            Planificacion.Controls.Add(label6);
            Planificacion.Controls.Add(label5);
            Planificacion.Controls.Add(dtPickerFechaOrden);
            Planificacion.Controls.Add(label4);
            Planificacion.Controls.Add(label3);
            Planificacion.Controls.Add(txtOrden);
            Planificacion.Controls.Add(label1);
            Planificacion.Location = new Point(12, 44);
            Planificacion.Name = "Planificacion";
            Planificacion.Size = new Size(320, 557);
            Planificacion.TabIndex = 32;
            Planificacion.TabStop = false;
            Planificacion.Text = "Correctivo";
            // 
            // txtDiagnostico
            // 
            txtDiagnostico.Location = new Point(13, 224);
            txtDiagnostico.Name = "txtDiagnostico";
            txtDiagnostico.Size = new Size(202, 27);
            txtDiagnostico.TabIndex = 16;
            // 
            // cbMaquinaria
            // 
            cbMaquinaria.FormattingEnabled = true;
            cbMaquinaria.Location = new Point(13, 356);
            cbMaquinaria.Name = "cbMaquinaria";
            cbMaquinaria.Size = new Size(250, 28);
            cbMaquinaria.TabIndex = 15;
            // 
            // cbTecnico
            // 
            cbTecnico.FormattingEnabled = true;
            cbTecnico.Location = new Point(13, 283);
            cbTecnico.Name = "cbTecnico";
            cbTecnico.Size = new Size(250, 28);
            cbTecnico.TabIndex = 14;
            // 
            // btnCancelarMc
            // 
            btnCancelarMc.Location = new Point(84, 494);
            btnCancelarMc.Name = "btnCancelarMc";
            btnCancelarMc.Size = new Size(114, 57);
            btnCancelarMc.TabIndex = 12;
            btnCancelarMc.Text = "Cancelar";
            btnCancelarMc.UseVisualStyleBackColor = true;
            // 
            // btnModificarMc
            // 
            btnModificarMc.Location = new Point(149, 431);
            btnModificarMc.Name = "btnModificarMc";
            btnModificarMc.Size = new Size(114, 57);
            btnModificarMc.TabIndex = 11;
            btnModificarMc.Text = "Modificar";
            btnModificarMc.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarOrden
            // 
            btnRegistrarOrden.Location = new Point(6, 431);
            btnRegistrarOrden.Name = "btnRegistrarOrden";
            btnRegistrarOrden.Size = new Size(114, 57);
            btnRegistrarOrden.TabIndex = 9;
            btnRegistrarOrden.Text = "Registrar Orden";
            btnRegistrarOrden.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 327);
            label7.Name = "label7";
            label7.Size = new Size(59, 20);
            label7.TabIndex = 8;
            label7.Text = "Equipo:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 254);
            label6.Name = "label6";
            label6.Size = new Size(62, 20);
            label6.TabIndex = 7;
            label6.Text = "Tecnico:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 190);
            label5.Name = "label5";
            label5.Size = new Size(89, 20);
            label5.TabIndex = 6;
            label5.Text = "Diagnostico";
            // 
            // dtPickerFechaOrden
            // 
            dtPickerFechaOrden.Location = new Point(10, 143);
            dtPickerFechaOrden.Name = "dtPickerFechaOrden";
            dtPickerFechaOrden.Size = new Size(289, 27);
            dtPickerFechaOrden.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 112);
            label4.Name = "label4";
            label4.Size = new Size(113, 20);
            label4.TabIndex = 4;
            label4.Text = "Fecha de Orden";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 122);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 3;
            // 
            // txtOrden
            // 
            txtOrden.Location = new Point(7, 71);
            txtOrden.Name = "txtOrden";
            txtOrden.Size = new Size(202, 27);
            txtOrden.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 37);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 0;
            label1.Text = "Nro de Orden";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(270, 21);
            label2.Name = "label2";
            label2.Size = new Size(219, 20);
            label2.TabIndex = 22;
            label2.Text = "MANTENIMIENTO CORRECTIVO";
            // 
            // btnNuevoMc
            // 
            btnNuevoMc.Location = new Point(366, 302);
            btnNuevoMc.Name = "btnNuevoMc";
            btnNuevoMc.Size = new Size(114, 57);
            btnNuevoMc.TabIndex = 25;
            btnNuevoMc.Text = "Nuevo";
            btnNuevoMc.UseVisualStyleBackColor = true;
            // 
            // txtOrdenMc
            // 
            txtOrdenMc.Location = new Point(341, 87);
            txtOrdenMc.Name = "txtOrdenMc";
            txtOrdenMc.Size = new Size(202, 27);
            txtOrdenMc.TabIndex = 17;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtOrdenMc);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(btnConsultarMc);
            groupBox1.Controls.Add(dtPickerFechaMc);
            groupBox1.Controls.Add(label8);
            groupBox1.Location = new Point(353, 388);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(604, 207);
            groupBox1.TabIndex = 34;
            groupBox1.TabStop = false;
            groupBox1.Text = "Buscar";
            // 
            // MantenimientoCorrectivo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(969, 614);
            Controls.Add(groupBox1);
            Controls.Add(btnSalirMc);
            Controls.Add(btnDesahabilitarMc);
            Controls.Add(btnEditarMc);
            Controls.Add(dgvMantenimientoCorrectivo);
            Controls.Add(Planificacion);
            Controls.Add(label2);
            Controls.Add(btnNuevoMc);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MantenimientoCorrectivo";
            Text = "MantenimientoCorrectivo";
            ((System.ComponentModel.ISupportInitialize)dgvMantenimientoCorrectivo).EndInit();
            Planificacion.ResumeLayout(false);
            Planificacion.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label9;
        private Button btnConsultarMc;
        private Button btnSalirMc;
        private DateTimePicker dtPickerFechaMc;
        private Button btnDesahabilitarMc;
        private Button btnEditarMc;
        private Label label8;
        private DataGridView dgvMantenimientoCorrectivo;
        private GroupBox Planificacion;
        private ComboBox cbMaquinaria;
        private ComboBox cbTecnico;
        private Button btnCancelarMc;
        private Button btnModificarMc;
        private Button btnRegistrarOrden;
        private Label label7;
        private Label label6;
        private Label label5;
        private DateTimePicker dtPickerFechaOrden;
        private Label label4;
        private Label label3;
        private TextBox txtOrden;
        private Label label1;
        private Label label2;
        private Button btnNuevoMc;
        private TextBox txtDiagnostico;
        private TextBox txtOrdenMc;
        private GroupBox groupBox1;
    }
}