namespace CapaPresentacion.Mantenimiento_Forms
{
    partial class MantenimientoPlanificacion
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
            groupBox1 = new GroupBox();
            txtIdPlanificacion = new TextBox();
            label9 = new Label();
            btnConsultarMP = new Button();
            dtPickerFechaMP = new DateTimePicker();
            label8 = new Label();
            btnSalirMP = new Button();
            btnDesahabilitarMP = new Button();
            btnEditarMP = new Button();
            dgvMP = new DataGridView();
            Planificacion = new GroupBox();
            cbTipoMant = new ComboBox();
            label11 = new Label();
            cbHorario = new ComboBox();
            label10 = new Label();
            cbPrioridad = new ComboBox();
            cbRecurso = new ComboBox();
            cbPersonal = new ComboBox();
            btnCancelarMP = new Button();
            btnModificarMP = new Button();
            btnRegistrarMP = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            dtPickerFechaMantenimiento = new DateTimePicker();
            label4 = new Label();
            label3 = new Label();
            txtIdMP = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnNuevoMP = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMP).BeginInit();
            Planificacion.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtIdPlanificacion);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(btnConsultarMP);
            groupBox1.Controls.Add(dtPickerFechaMP);
            groupBox1.Controls.Add(label8);
            groupBox1.Location = new Point(347, 367);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(603, 284);
            groupBox1.TabIndex = 42;
            groupBox1.TabStop = false;
            groupBox1.Text = "Buscar";
            // 
            // txtIdPlanificacion
            // 
            txtIdPlanificacion.Location = new Point(341, 87);
            txtIdPlanificacion.Name = "txtIdPlanificacion";
            txtIdPlanificacion.Size = new Size(202, 27);
            txtIdPlanificacion.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(341, 44);
            label9.Name = "label9";
            label9.Size = new Size(143, 20);
            label9.TabIndex = 31;
            label9.Text = "Nro de Planificación";
            // 
            // btnConsultarMP
            // 
            btnConsultarMP.Location = new Point(429, 144);
            btnConsultarMP.Name = "btnConsultarMP";
            btnConsultarMP.Size = new Size(114, 57);
            btnConsultarMP.TabIndex = 27;
            btnConsultarMP.Text = "Consultar";
            btnConsultarMP.UseVisualStyleBackColor = true;
            btnConsultarMP.Click += btnConsultarMP_Click;
            // 
            // dtPickerFechaMP
            // 
            dtPickerFechaMP.Location = new Point(27, 87);
            dtPickerFechaMP.Name = "dtPickerFechaMP";
            dtPickerFechaMP.Size = new Size(289, 27);
            dtPickerFechaMP.TabIndex = 30;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(27, 44);
            label8.Name = "label8";
            label8.Size = new Size(50, 20);
            label8.TabIndex = 28;
            label8.Text = "Fecha:";
            // 
            // btnSalirMP
            // 
            btnSalirMP.Location = new Point(738, 280);
            btnSalirMP.Name = "btnSalirMP";
            btnSalirMP.Size = new Size(114, 57);
            btnSalirMP.TabIndex = 41;
            btnSalirMP.Text = "Salir";
            btnSalirMP.UseVisualStyleBackColor = true;
            btnSalirMP.Click += btnSalirMP_Click;
            // 
            // btnDesahabilitarMP
            // 
            btnDesahabilitarMP.Location = new Point(618, 280);
            btnDesahabilitarMP.Name = "btnDesahabilitarMP";
            btnDesahabilitarMP.Size = new Size(114, 57);
            btnDesahabilitarMP.TabIndex = 37;
            btnDesahabilitarMP.Text = "Desahabilitar";
            btnDesahabilitarMP.UseVisualStyleBackColor = true;
            btnDesahabilitarMP.Click += btnDesahabilitarMP_Click;
            // 
            // btnEditarMP
            // 
            btnEditarMP.Location = new Point(489, 280);
            btnEditarMP.Name = "btnEditarMP";
            btnEditarMP.Size = new Size(114, 57);
            btnEditarMP.TabIndex = 39;
            btnEditarMP.Text = "Editar";
            btnEditarMP.UseVisualStyleBackColor = true;
            btnEditarMP.Click += btnEditarMP_Click;
            // 
            // dgvMP
            // 
            dgvMP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMP.Location = new Point(360, 39);
            dgvMP.Name = "dgvMP";
            dgvMP.RowHeadersWidth = 51;
            dgvMP.Size = new Size(550, 211);
            dgvMP.TabIndex = 36;
            // 
            // Planificacion
            // 
            Planificacion.Controls.Add(cbTipoMant);
            Planificacion.Controls.Add(label11);
            Planificacion.Controls.Add(cbHorario);
            Planificacion.Controls.Add(label10);
            Planificacion.Controls.Add(cbPrioridad);
            Planificacion.Controls.Add(cbRecurso);
            Planificacion.Controls.Add(cbPersonal);
            Planificacion.Controls.Add(btnCancelarMP);
            Planificacion.Controls.Add(btnModificarMP);
            Planificacion.Controls.Add(btnRegistrarMP);
            Planificacion.Controls.Add(label7);
            Planificacion.Controls.Add(label6);
            Planificacion.Controls.Add(label5);
            Planificacion.Controls.Add(dtPickerFechaMantenimiento);
            Planificacion.Controls.Add(label4);
            Planificacion.Controls.Add(label3);
            Planificacion.Controls.Add(txtIdMP);
            Planificacion.Controls.Add(label1);
            Planificacion.Location = new Point(6, 23);
            Planificacion.Name = "Planificacion";
            Planificacion.Size = new Size(320, 641);
            Planificacion.TabIndex = 40;
            Planificacion.TabStop = false;
            Planificacion.Text = "Planificación";
            // 
            // cbTipoMant
            // 
            cbTipoMant.FormattingEnabled = true;
            cbTipoMant.Location = new Point(10, 196);
            cbTipoMant.Margin = new Padding(3, 4, 3, 4);
            cbTipoMant.Name = "cbTipoMant";
            cbTipoMant.Size = new Size(130, 28);
            cbTipoMant.TabIndex = 20;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(10, 172);
            label11.Name = "label11";
            label11.Size = new Size(125, 20);
            label11.TabIndex = 19;
            label11.Text = "T. Mantenimiento";
            // 
            // cbHorario
            // 
            cbHorario.FormattingEnabled = true;
            cbHorario.Location = new Point(10, 344);
            cbHorario.Name = "cbHorario";
            cbHorario.Size = new Size(283, 28);
            cbHorario.TabIndex = 18;
            cbHorario.SelectedIndexChanged += cbHorario_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(10, 313);
            label10.Name = "label10";
            label10.Size = new Size(63, 20);
            label10.TabIndex = 17;
            label10.Text = "Horario:";
            // 
            // cbPrioridad
            // 
            cbPrioridad.FormattingEnabled = true;
            cbPrioridad.Location = new Point(161, 196);
            cbPrioridad.Margin = new Padding(3, 4, 3, 4);
            cbPrioridad.Name = "cbPrioridad";
            cbPrioridad.Size = new Size(132, 28);
            cbPrioridad.TabIndex = 16;
            // 
            // cbRecurso
            // 
            cbRecurso.FormattingEnabled = true;
            cbRecurso.Location = new Point(161, 272);
            cbRecurso.Name = "cbRecurso";
            cbRecurso.Size = new Size(132, 28);
            cbRecurso.TabIndex = 15;
            // 
            // cbPersonal
            // 
            cbPersonal.FormattingEnabled = true;
            cbPersonal.Location = new Point(10, 272);
            cbPersonal.Name = "cbPersonal";
            cbPersonal.Size = new Size(130, 28);
            cbPersonal.TabIndex = 14;
            // 
            // btnCancelarMP
            // 
            btnCancelarMP.Location = new Point(156, 476);
            btnCancelarMP.Name = "btnCancelarMP";
            btnCancelarMP.Size = new Size(114, 47);
            btnCancelarMP.TabIndex = 12;
            btnCancelarMP.Text = "Cancelar";
            btnCancelarMP.UseVisualStyleBackColor = true;
            btnCancelarMP.Click += btnCancelarMP_Click;
            // 
            // btnModificarMP
            // 
            btnModificarMP.Location = new Point(161, 411);
            btnModificarMP.Name = "btnModificarMP";
            btnModificarMP.Size = new Size(109, 47);
            btnModificarMP.TabIndex = 11;
            btnModificarMP.Text = "Modificar";
            btnModificarMP.UseVisualStyleBackColor = true;
            btnModificarMP.Click += btnModificarMP_Click;
            // 
            // btnRegistrarMP
            // 
            btnRegistrarMP.Location = new Point(21, 411);
            btnRegistrarMP.Name = "btnRegistrarMP";
            btnRegistrarMP.Size = new Size(114, 47);
            btnRegistrarMP.TabIndex = 9;
            btnRegistrarMP.Text = "Registrar";
            btnRegistrarMP.UseVisualStyleBackColor = true;
            btnRegistrarMP.Click += btnRegistrarMP_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(161, 249);
            label7.Name = "label7";
            label7.Size = new Size(64, 20);
            label7.TabIndex = 8;
            label7.Text = "Recurso:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 249);
            label6.Name = "label6";
            label6.Size = new Size(62, 20);
            label6.TabIndex = 7;
            label6.Text = "Tecnico:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(161, 172);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 6;
            label5.Text = "Prioridad";
            // 
            // dtPickerFechaMantenimiento
            // 
            dtPickerFechaMantenimiento.Location = new Point(10, 121);
            dtPickerFechaMantenimiento.Name = "dtPickerFechaMantenimiento";
            dtPickerFechaMantenimiento.Size = new Size(283, 27);
            dtPickerFechaMantenimiento.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 99);
            label4.Name = "label4";
            label4.Size = new Size(173, 20);
            label4.TabIndex = 4;
            label4.Text = "Fecha de Mantenimiento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 121);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 3;
            // 
            // txtIdMP
            // 
            txtIdMP.Location = new Point(10, 57);
            txtIdMP.Name = "txtIdMP";
            txtIdMP.Size = new Size(110, 27);
            txtIdMP.TabIndex = 1;
            txtIdMP.KeyDown += txtIdMP_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 35);
            label1.Name = "label1";
            label1.Size = new Size(143, 20);
            label1.TabIndex = 0;
            label1.Text = "Nro de Planificación";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(360, 12);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 35;
            label2.Text = "Planificación";
            // 
            // btnNuevoMP
            // 
            btnNuevoMP.Location = new Point(360, 280);
            btnNuevoMP.Name = "btnNuevoMP";
            btnNuevoMP.Size = new Size(114, 57);
            btnNuevoMP.TabIndex = 38;
            btnNuevoMP.Text = "Nuevo";
            btnNuevoMP.UseVisualStyleBackColor = true;
            btnNuevoMP.Click += btnNuevoMP_Click;
            // 
            // MantenimientoPlanificacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1002, 699);
            Controls.Add(groupBox1);
            Controls.Add(btnSalirMP);
            Controls.Add(btnDesahabilitarMP);
            Controls.Add(btnEditarMP);
            Controls.Add(dgvMP);
            Controls.Add(Planificacion);
            Controls.Add(label2);
            Controls.Add(btnNuevoMP);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "MantenimientoPlanificacion";
            Text = "Mantenimiento Planificacion";
            Load += MantenimientoPlanificacion_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMP).EndInit();
            Planificacion.ResumeLayout(false);
            Planificacion.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtIdPlanificacion;
        private Label label9;
        private Button btnConsultarMP;
        private DateTimePicker dtPickerFechaMP;
        private Label label8;
        private Button btnSalirMP;
        private Button btnDesahabilitarMP;
        private Button btnEditarMP;
        private DataGridView dgvMP;
        private GroupBox Planificacion;
        private TextBox txtDiagnostico;
        private ComboBox cbRecurso;
        private ComboBox cbPersonal;
        private Button btnCancelarMP;
        private Button btnModificarMP;
        private Button btnRegistrarMP;
        private Label label7;
        private Label label6;
        private Label label5;
        private DateTimePicker dtPickerFechaMantenimiento;
        private Label label4;
        private Label label3;
        private TextBox txtIdMP;
        private Label label1;
        private Label label2;
        private Button btnNuevoMP;
        private ComboBox cbPrioridad;
        private ComboBox cbHorario;
        private Label label10;
        private ComboBox cbTipoMant;
        private Label label11;
    }
}