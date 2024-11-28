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
            btnSalirMc = new Button();
            btnDesahabilitarMP = new Button();
            btnEditarMP = new Button();
            dgvMP = new DataGridView();
            Planificacion = new GroupBox();
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
            label11 = new Label();
            comboBox1 = new ComboBox();
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
            groupBox1.Location = new Point(304, 275);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(528, 213);
            groupBox1.TabIndex = 42;
            groupBox1.TabStop = false;
            groupBox1.Text = "Buscar";
            // 
            // txtIdPlanificacion
            // 
            txtIdPlanificacion.Location = new Point(298, 65);
            txtIdPlanificacion.Margin = new Padding(3, 2, 3, 2);
            txtIdPlanificacion.Name = "txtIdPlanificacion";
            txtIdPlanificacion.Size = new Size(177, 23);
            txtIdPlanificacion.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(298, 33);
            label9.Name = "label9";
            label9.Size = new Size(114, 15);
            label9.TabIndex = 31;
            label9.Text = "Nro de Planificación";
            // 
            // btnConsultarMP
            // 
            btnConsultarMP.Location = new Point(375, 108);
            btnConsultarMP.Margin = new Padding(3, 2, 3, 2);
            btnConsultarMP.Name = "btnConsultarMP";
            btnConsultarMP.Size = new Size(100, 43);
            btnConsultarMP.TabIndex = 27;
            btnConsultarMP.Text = "Consultar";
            btnConsultarMP.UseVisualStyleBackColor = true;
            btnConsultarMP.Click += btnConsultarMP_Click;
            // 
            // dtPickerFechaMP
            // 
            dtPickerFechaMP.Location = new Point(24, 65);
            dtPickerFechaMP.Margin = new Padding(3, 2, 3, 2);
            dtPickerFechaMP.Name = "dtPickerFechaMP";
            dtPickerFechaMP.Size = new Size(253, 23);
            dtPickerFechaMP.TabIndex = 30;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(24, 33);
            label8.Name = "label8";
            label8.Size = new Size(41, 15);
            label8.TabIndex = 28;
            label8.Text = "Fecha:";
            // 
            // btnSalirMc
            // 
            btnSalirMc.Location = new Point(646, 210);
            btnSalirMc.Margin = new Padding(3, 2, 3, 2);
            btnSalirMc.Name = "btnSalirMc";
            btnSalirMc.Size = new Size(100, 43);
            btnSalirMc.TabIndex = 41;
            btnSalirMc.Text = "Salir";
            btnSalirMc.UseVisualStyleBackColor = true;
            // 
            // btnDesahabilitarMP
            // 
            btnDesahabilitarMP.Location = new Point(541, 210);
            btnDesahabilitarMP.Margin = new Padding(3, 2, 3, 2);
            btnDesahabilitarMP.Name = "btnDesahabilitarMP";
            btnDesahabilitarMP.Size = new Size(100, 43);
            btnDesahabilitarMP.TabIndex = 37;
            btnDesahabilitarMP.Text = "Desahabilitar";
            btnDesahabilitarMP.UseVisualStyleBackColor = true;
            btnDesahabilitarMP.Click += btnDesahabilitarMP_Click;
            // 
            // btnEditarMP
            // 
            btnEditarMP.Location = new Point(428, 210);
            btnEditarMP.Margin = new Padding(3, 2, 3, 2);
            btnEditarMP.Name = "btnEditarMP";
            btnEditarMP.Size = new Size(100, 43);
            btnEditarMP.TabIndex = 39;
            btnEditarMP.Text = "Editar";
            btnEditarMP.UseVisualStyleBackColor = true;
            btnEditarMP.Click += btnEditarMP_Click;
            // 
            // dgvMP
            // 
            dgvMP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMP.Location = new Point(315, 29);
            dgvMP.Margin = new Padding(3, 2, 3, 2);
            dgvMP.Name = "dgvMP";
            dgvMP.RowHeadersWidth = 51;
            dgvMP.Size = new Size(481, 158);
            dgvMP.TabIndex = 36;
            // 
            // Planificacion
            // 
            Planificacion.Controls.Add(comboBox1);
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
            Planificacion.Location = new Point(5, 17);
            Planificacion.Margin = new Padding(3, 2, 3, 2);
            Planificacion.Name = "Planificacion";
            Planificacion.Padding = new Padding(3, 2, 3, 2);
            Planificacion.Size = new Size(280, 481);
            Planificacion.TabIndex = 40;
            Planificacion.TabStop = false;
            Planificacion.Text = "Planificación";
            // 
            // cbHorario
            // 
            cbHorario.FormattingEnabled = true;
            cbHorario.Location = new Point(9, 258);
            cbHorario.Margin = new Padding(3, 2, 3, 2);
            cbHorario.Name = "cbHorario";
            cbHorario.Size = new Size(248, 23);
            cbHorario.TabIndex = 18;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(9, 235);
            label10.Name = "label10";
            label10.Size = new Size(50, 15);
            label10.TabIndex = 17;
            label10.Text = "Horario:";
            // 
            // cbPrioridad
            // 
            cbPrioridad.FormattingEnabled = true;
            cbPrioridad.Location = new Point(141, 147);
            cbPrioridad.Name = "cbPrioridad";
            cbPrioridad.Size = new Size(116, 23);
            cbPrioridad.TabIndex = 16;
            // 
            // cbRecurso
            // 
            cbRecurso.FormattingEnabled = true;
            cbRecurso.Location = new Point(141, 204);
            cbRecurso.Margin = new Padding(3, 2, 3, 2);
            cbRecurso.Name = "cbRecurso";
            cbRecurso.Size = new Size(116, 23);
            cbRecurso.TabIndex = 15;
            // 
            // cbPersonal
            // 
            cbPersonal.FormattingEnabled = true;
            cbPersonal.Location = new Point(9, 204);
            cbPersonal.Margin = new Padding(3, 2, 3, 2);
            cbPersonal.Name = "cbPersonal";
            cbPersonal.Size = new Size(114, 23);
            cbPersonal.TabIndex = 14;
            // 
            // btnCancelarMP
            // 
            btnCancelarMP.Location = new Point(84, 366);
            btnCancelarMP.Margin = new Padding(3, 2, 3, 2);
            btnCancelarMP.Name = "btnCancelarMP";
            btnCancelarMP.Size = new Size(100, 35);
            btnCancelarMP.TabIndex = 12;
            btnCancelarMP.Text = "Cancelar";
            btnCancelarMP.UseVisualStyleBackColor = true;
            btnCancelarMP.Click += btnCancelarMP_Click;
            // 
            // btnModificarMP
            // 
            btnModificarMP.Location = new Point(162, 323);
            btnModificarMP.Margin = new Padding(3, 2, 3, 2);
            btnModificarMP.Name = "btnModificarMP";
            btnModificarMP.Size = new Size(95, 35);
            btnModificarMP.TabIndex = 11;
            btnModificarMP.Text = "Modificar";
            btnModificarMP.UseVisualStyleBackColor = true;
            btnModificarMP.Click += btnModificarMP_Click;
            // 
            // btnRegistrarMP
            // 
            btnRegistrarMP.Location = new Point(6, 323);
            btnRegistrarMP.Margin = new Padding(3, 2, 3, 2);
            btnRegistrarMP.Name = "btnRegistrarMP";
            btnRegistrarMP.Size = new Size(100, 35);
            btnRegistrarMP.TabIndex = 9;
            btnRegistrarMP.Text = "Registrar";
            btnRegistrarMP.UseVisualStyleBackColor = true;
            btnRegistrarMP.Click += btnRegistrarMP_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(141, 187);
            label7.Name = "label7";
            label7.Size = new Size(52, 15);
            label7.TabIndex = 8;
            label7.Text = "Recurso:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 187);
            label6.Name = "label6";
            label6.Size = new Size(50, 15);
            label6.TabIndex = 7;
            label6.Text = "Tecnico:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(141, 129);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 6;
            label5.Text = "Prioridad";
            // 
            // dtPickerFechaMantenimiento
            // 
            dtPickerFechaMantenimiento.Location = new Point(9, 91);
            dtPickerFechaMantenimiento.Margin = new Padding(3, 2, 3, 2);
            dtPickerFechaMantenimiento.Name = "dtPickerFechaMantenimiento";
            dtPickerFechaMantenimiento.Size = new Size(248, 23);
            dtPickerFechaMantenimiento.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 74);
            label4.Name = "label4";
            label4.Size = new Size(139, 15);
            label4.TabIndex = 4;
            label4.Text = "Fecha de Mantenimiento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 91);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 3;
            // 
            // txtIdMP
            // 
            txtIdMP.Location = new Point(9, 43);
            txtIdMP.Margin = new Padding(3, 2, 3, 2);
            txtIdMP.Name = "txtIdMP";
            txtIdMP.Size = new Size(97, 23);
            txtIdMP.TabIndex = 1;
            txtIdMP.KeyDown += txtIdMP_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 26);
            label1.Name = "label1";
            label1.Size = new Size(114, 15);
            label1.TabIndex = 0;
            label1.Text = "Nro de Planificación";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(315, 0);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 35;
            label2.Text = "Planificación";
            // 
            // btnNuevoMP
            // 
            btnNuevoMP.Location = new Point(315, 210);
            btnNuevoMP.Margin = new Padding(3, 2, 3, 2);
            btnNuevoMP.Name = "btnNuevoMP";
            btnNuevoMP.Size = new Size(100, 43);
            btnNuevoMP.TabIndex = 38;
            btnNuevoMP.Text = "Nuevo";
            btnNuevoMP.UseVisualStyleBackColor = true;
            btnNuevoMP.Click += btnNuevoMP_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(9, 129);
            label11.Name = "label11";
            label11.Size = new Size(101, 15);
            label11.TabIndex = 19;
            label11.Text = "T. Mantenimiento";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(9, 147);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(114, 23);
            comboBox1.TabIndex = 20;
            // 
            // MantenimientoPlanificacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(877, 524);
            Controls.Add(groupBox1);
            Controls.Add(btnSalirMc);
            Controls.Add(btnDesahabilitarMP);
            Controls.Add(btnEditarMP);
            Controls.Add(dgvMP);
            Controls.Add(Planificacion);
            Controls.Add(label2);
            Controls.Add(btnNuevoMP);
            FormBorderStyle = FormBorderStyle.None;
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
        private Button btnSalirMc;
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
        private ComboBox comboBox1;
        private Label label11;
    }
}