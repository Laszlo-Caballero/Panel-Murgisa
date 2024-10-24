namespace CapaPresentacion.Mantenimiento_Forms
{
    partial class MantenimientoPreventivo
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
            label1 = new Label();
            txtPlanificacion = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dtPickerPlanificacion = new DateTimePicker();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btnRegistrarMp = new Button();
            btnModificarMp = new Button();
            btnConsultarMp = new Button();
            label8 = new Label();
            dtPickerPlanificacionMp = new DateTimePicker();
            label9 = new Label();
            Planificacion = new GroupBox();
            cbEquipo = new ComboBox();
            cbTecnico = new ComboBox();
            cbRequerimiento = new ComboBox();
            btnCancelarMp = new Button();
            dataGridView1 = new DataGridView();
            btnNuevoMp = new Button();
            btnEditarMp = new Button();
            btnDesahabilitarMp = new Button();
            btnSalirMp = new Button();
            cbRequerimientoMp = new ComboBox();
            Planificacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 37);
            label1.Name = "label1";
            label1.Size = new Size(146, 20);
            label1.TabIndex = 0;
            label1.Text = "Nro de Planificacion:";
            // 
            // txtPlanificacion
            // 
            txtPlanificacion.Location = new Point(7, 71);
            txtPlanificacion.Name = "txtPlanificacion";
            txtPlanificacion.Size = new Size(202, 27);
            txtPlanificacion.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(307, 34);
            label2.Name = "label2";
            label2.Size = new Size(217, 20);
            label2.TabIndex = 2;
            label2.Text = "MANTENIMIENTO PREVENTIVO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 122);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 112);
            label4.Name = "label4";
            label4.Size = new Size(159, 20);
            label4.TabIndex = 4;
            label4.Text = "Fecha de Planificacion:";
            // 
            // dtPickerPlanificacion
            // 
            dtPickerPlanificacion.Location = new Point(10, 143);
            dtPickerPlanificacion.Name = "dtPickerPlanificacion";
            dtPickerPlanificacion.Size = new Size(289, 27);
            dtPickerPlanificacion.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 190);
            label5.Name = "label5";
            label5.Size = new Size(110, 20);
            label5.TabIndex = 6;
            label5.Text = "Requerimiento:";
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
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 327);
            label7.Name = "label7";
            label7.Size = new Size(59, 20);
            label7.TabIndex = 8;
            label7.Text = "Equipo:";
            // 
            // btnRegistrarMp
            // 
            btnRegistrarMp.Location = new Point(6, 431);
            btnRegistrarMp.Name = "btnRegistrarMp";
            btnRegistrarMp.Size = new Size(114, 57);
            btnRegistrarMp.TabIndex = 9;
            btnRegistrarMp.Text = "Registrar Planificacion";
            btnRegistrarMp.UseVisualStyleBackColor = true;
            // 
            // btnModificarMp
            // 
            btnModificarMp.Location = new Point(149, 431);
            btnModificarMp.Name = "btnModificarMp";
            btnModificarMp.Size = new Size(114, 57);
            btnModificarMp.TabIndex = 11;
            btnModificarMp.Text = "Modificar";
            btnModificarMp.UseVisualStyleBackColor = true;
            btnModificarMp.Click += button2_Click;
            // 
            // btnConsultarMp
            // 
            btnConsultarMp.Location = new Point(379, 509);
            btnConsultarMp.Name = "btnConsultarMp";
            btnConsultarMp.Size = new Size(114, 57);
            btnConsultarMp.TabIndex = 14;
            btnConsultarMp.Text = "Consultar";
            btnConsultarMp.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(379, 407);
            label8.Name = "label8";
            label8.Size = new Size(50, 20);
            label8.TabIndex = 15;
            label8.Text = "Fecha:";
            // 
            // dtPickerPlanificacionMp
            // 
            dtPickerPlanificacionMp.Location = new Point(370, 448);
            dtPickerPlanificacionMp.Name = "dtPickerPlanificacionMp";
            dtPickerPlanificacionMp.Size = new Size(289, 27);
            dtPickerPlanificacionMp.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(676, 407);
            label9.Name = "label9";
            label9.Size = new Size(110, 20);
            label9.TabIndex = 17;
            label9.Text = "Requerimiento:";
            // 
            // Planificacion
            // 
            Planificacion.Controls.Add(cbEquipo);
            Planificacion.Controls.Add(cbTecnico);
            Planificacion.Controls.Add(cbRequerimiento);
            Planificacion.Controls.Add(btnCancelarMp);
            Planificacion.Controls.Add(btnModificarMp);
            Planificacion.Controls.Add(btnRegistrarMp);
            Planificacion.Controls.Add(label7);
            Planificacion.Controls.Add(label6);
            Planificacion.Controls.Add(label5);
            Planificacion.Controls.Add(dtPickerPlanificacion);
            Planificacion.Controls.Add(label4);
            Planificacion.Controls.Add(label3);
            Planificacion.Controls.Add(txtPlanificacion);
            Planificacion.Controls.Add(label1);
            Planificacion.Location = new Point(23, 69);
            Planificacion.Name = "Planificacion";
            Planificacion.Size = new Size(320, 557);
            Planificacion.TabIndex = 19;
            Planificacion.TabStop = false;
            Planificacion.Text = "Planificacion";
            // 
            // cbEquipo
            // 
            cbEquipo.FormattingEnabled = true;
            cbEquipo.Location = new Point(13, 356);
            cbEquipo.Name = "cbEquipo";
            cbEquipo.Size = new Size(250, 28);
            cbEquipo.TabIndex = 15;
            // 
            // cbTecnico
            // 
            cbTecnico.FormattingEnabled = true;
            cbTecnico.Location = new Point(13, 283);
            cbTecnico.Name = "cbTecnico";
            cbTecnico.Size = new Size(250, 28);
            cbTecnico.TabIndex = 14;
            // 
            // cbRequerimiento
            // 
            cbRequerimiento.FormattingEnabled = true;
            cbRequerimiento.Location = new Point(12, 215);
            cbRequerimiento.Name = "cbRequerimiento";
            cbRequerimiento.Size = new Size(250, 28);
            cbRequerimiento.TabIndex = 13;
            // 
            // btnCancelarMp
            // 
            btnCancelarMp.Location = new Point(84, 494);
            btnCancelarMp.Name = "btnCancelarMp";
            btnCancelarMp.Size = new Size(114, 57);
            btnCancelarMp.TabIndex = 12;
            btnCancelarMp.Text = "Cancelar";
            btnCancelarMp.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(370, 81);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(550, 211);
            dataGridView1.TabIndex = 10;
            // 
            // btnNuevoMp
            // 
            btnNuevoMp.Location = new Point(370, 323);
            btnNuevoMp.Name = "btnNuevoMp";
            btnNuevoMp.Size = new Size(114, 57);
            btnNuevoMp.TabIndex = 12;
            btnNuevoMp.Text = "Nuevo";
            btnNuevoMp.UseVisualStyleBackColor = true;
            // 
            // btnEditarMp
            // 
            btnEditarMp.Location = new Point(499, 323);
            btnEditarMp.Name = "btnEditarMp";
            btnEditarMp.Size = new Size(114, 57);
            btnEditarMp.TabIndex = 13;
            btnEditarMp.Text = "Editar";
            btnEditarMp.UseVisualStyleBackColor = true;
            // 
            // btnDesahabilitarMp
            // 
            btnDesahabilitarMp.Location = new Point(628, 323);
            btnDesahabilitarMp.Name = "btnDesahabilitarMp";
            btnDesahabilitarMp.Size = new Size(114, 57);
            btnDesahabilitarMp.TabIndex = 12;
            btnDesahabilitarMp.Text = "Desahabilitar";
            btnDesahabilitarMp.UseVisualStyleBackColor = true;
            // 
            // btnSalirMp
            // 
            btnSalirMp.Location = new Point(748, 323);
            btnSalirMp.Name = "btnSalirMp";
            btnSalirMp.Size = new Size(114, 57);
            btnSalirMp.TabIndex = 21;
            btnSalirMp.Text = "Salir";
            btnSalirMp.UseVisualStyleBackColor = true;
            // 
            // cbRequerimientoMp
            // 
            cbRequerimientoMp.FormattingEnabled = true;
            cbRequerimientoMp.Location = new Point(685, 450);
            cbRequerimientoMp.Name = "cbRequerimientoMp";
            cbRequerimientoMp.Size = new Size(250, 28);
            cbRequerimientoMp.TabIndex = 16;
            // 
            // MantenimientoPreventivo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 660);
            Controls.Add(cbRequerimientoMp);
            Controls.Add(label9);
            Controls.Add(btnConsultarMp);
            Controls.Add(btnSalirMp);
            Controls.Add(dtPickerPlanificacionMp);
            Controls.Add(btnDesahabilitarMp);
            Controls.Add(btnEditarMp);
            Controls.Add(label8);
            Controls.Add(dataGridView1);
            Controls.Add(Planificacion);
            Controls.Add(label2);
            Controls.Add(btnNuevoMp);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MantenimientoPreventivo";
            Text = "MantenimientoPreventivo";
            Planificacion.ResumeLayout(false);
            Planificacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPlanificacion;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker dtPickerPlanificacion;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btnRegistrarMp;
        private Button btnModificarMp;
        private Button btnConsultarMp;
        private Label label8;
        private DateTimePicker dtPickerPlanificacionMp;
        private Label label9;
        private GroupBox Planificacion;
        private DataGridView dataGridView1;
        private Button btnNuevoMp;
        private Button btnEditarMp;
        private Button btnDesahabilitarMp;
        private Button btnCancelarMp;
        private Button btnSalirMp;
        private ComboBox cbEquipo;
        private ComboBox cbTecnico;
        private ComboBox cbRequerimiento;
        private ComboBox cbRequerimientoMp;
    }
}