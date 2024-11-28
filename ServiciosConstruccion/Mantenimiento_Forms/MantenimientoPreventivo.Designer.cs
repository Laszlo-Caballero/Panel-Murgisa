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
            txtId = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dtPickerFechaMantenimiento = new DateTimePicker();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btnRegistrarMp = new Button();
            btnModificarMp = new Button();
            btnConsultarMp = new Button();
            label8 = new Label();
            dtPickerFechaMp = new DateTimePicker();
            label9 = new Label();
            Planificacion = new GroupBox();
            txtComentarios = new TextBox();
            label11 = new Label();
            txtDuracionEstimada = new TextBox();
            txtRequerimientosEspeciales = new TextBox();
            label10 = new Label();
            txtResultadoEjecucion = new TextBox();
            cbPlanificacion = new ComboBox();
            btnCancelarMp = new Button();
            dgvMP = new DataGridView();
            btnNuevoMp = new Button();
            btnEditarMp = new Button();
            btnDesahabilitarMp = new Button();
            btnSalirMp = new Button();
            txtIDSearch = new TextBox();
            Planificacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMP).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 28);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 0;
            label1.Text = "Nro:";
            // 
            // txtId
            // 
            txtId.Location = new Point(6, 53);
            txtId.Margin = new Padding(3, 2, 3, 2);
            txtId.Name = "txtId";
            txtId.Size = new Size(177, 23);
            txtId.TabIndex = 1;
            txtId.KeyDown += txtId_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(349, 31);
            label2.Name = "label2";
            label2.Size = new Size(172, 15);
            label2.TabIndex = 2;
            label2.Text = "MANTENIMIENTO PREVENTIVO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 92);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 139);
            label4.Name = "label4";
            label4.Size = new Size(78, 15);
            label4.TabIndex = 4;
            label4.Text = "Fecha de MP:";
            // 
            // dtPickerFechaMantenimiento
            // 
            dtPickerFechaMantenimiento.Location = new Point(9, 156);
            dtPickerFechaMantenimiento.Margin = new Padding(3, 2, 3, 2);
            dtPickerFechaMantenimiento.Name = "dtPickerFechaMantenimiento";
            dtPickerFechaMantenimiento.Size = new Size(282, 23);
            dtPickerFechaMantenimiento.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 84);
            label5.Name = "label5";
            label5.Size = new Size(85, 15);
            label5.TabIndex = 6;
            label5.Text = "IdPlanificación";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 190);
            label6.Name = "label6";
            label6.Size = new Size(113, 15);
            label6.TabIndex = 7;
            label6.Text = "Resultado Ejecución";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(164, 244);
            label7.Name = "label7";
            label7.Size = new Size(55, 15);
            label7.TabIndex = 8;
            label7.Text = "Duración";
            // 
            // btnRegistrarMp
            // 
            btnRegistrarMp.Location = new Point(6, 330);
            btnRegistrarMp.Margin = new Padding(3, 2, 3, 2);
            btnRegistrarMp.Name = "btnRegistrarMp";
            btnRegistrarMp.Size = new Size(97, 28);
            btnRegistrarMp.TabIndex = 9;
            btnRegistrarMp.Text = "Registrar";
            btnRegistrarMp.UseVisualStyleBackColor = true;
            btnRegistrarMp.Click += btnRegistrarMp_Click;
            // 
            // btnModificarMp
            // 
            btnModificarMp.Location = new Point(109, 330);
            btnModificarMp.Margin = new Padding(3, 2, 3, 2);
            btnModificarMp.Name = "btnModificarMp";
            btnModificarMp.Size = new Size(97, 26);
            btnModificarMp.TabIndex = 11;
            btnModificarMp.Text = "Modificar";
            btnModificarMp.UseVisualStyleBackColor = true;
            btnModificarMp.Click += btnModificarMp_Click;
            // 
            // btnConsultarMp
            // 
            btnConsultarMp.Location = new Point(718, 367);
            btnConsultarMp.Margin = new Padding(3, 2, 3, 2);
            btnConsultarMp.Name = "btnConsultarMp";
            btnConsultarMp.Size = new Size(100, 43);
            btnConsultarMp.TabIndex = 14;
            btnConsultarMp.Text = "Consultar";
            btnConsultarMp.UseVisualStyleBackColor = true;
            btnConsultarMp.Click += btnConsultarMp_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(352, 318);
            label8.Name = "label8";
            label8.Size = new Size(41, 15);
            label8.TabIndex = 15;
            label8.Text = "Fecha:";
            // 
            // dtPickerFechaMp
            // 
            dtPickerFechaMp.Location = new Point(352, 335);
            dtPickerFechaMp.Margin = new Padding(3, 2, 3, 2);
            dtPickerFechaMp.Name = "dtPickerFechaMp";
            dtPickerFechaMp.Size = new Size(210, 23);
            dtPickerFechaMp.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(599, 314);
            label9.Name = "label9";
            label9.Size = new Size(18, 15);
            label9.TabIndex = 17;
            label9.Text = "ID";
            // 
            // Planificacion
            // 
            Planificacion.Controls.Add(txtComentarios);
            Planificacion.Controls.Add(label11);
            Planificacion.Controls.Add(txtDuracionEstimada);
            Planificacion.Controls.Add(txtRequerimientosEspeciales);
            Planificacion.Controls.Add(label10);
            Planificacion.Controls.Add(txtResultadoEjecucion);
            Planificacion.Controls.Add(cbPlanificacion);
            Planificacion.Controls.Add(btnCancelarMp);
            Planificacion.Controls.Add(btnModificarMp);
            Planificacion.Controls.Add(btnRegistrarMp);
            Planificacion.Controls.Add(label7);
            Planificacion.Controls.Add(label6);
            Planificacion.Controls.Add(label5);
            Planificacion.Controls.Add(dtPickerFechaMantenimiento);
            Planificacion.Controls.Add(label4);
            Planificacion.Controls.Add(label3);
            Planificacion.Controls.Add(txtId);
            Planificacion.Controls.Add(label1);
            Planificacion.Location = new Point(20, 52);
            Planificacion.Margin = new Padding(3, 2, 3, 2);
            Planificacion.Name = "Planificacion";
            Planificacion.Padding = new Padding(3, 2, 3, 2);
            Planificacion.Size = new Size(326, 418);
            Planificacion.TabIndex = 19;
            Planificacion.TabStop = false;
            Planificacion.Text = "Planificacion";
            // 
            // txtComentarios
            // 
            txtComentarios.Location = new Point(164, 208);
            txtComentarios.Name = "txtComentarios";
            txtComentarios.Size = new Size(127, 23);
            txtComentarios.TabIndex = 21;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(162, 190);
            label11.Name = "label11";
            label11.Size = new Size(75, 15);
            label11.TabIndex = 20;
            label11.Text = "Comentarios";
            // 
            // txtDuracionEstimada
            // 
            txtDuracionEstimada.Location = new Point(164, 263);
            txtDuracionEstimada.Name = "txtDuracionEstimada";
            txtDuracionEstimada.Size = new Size(127, 23);
            txtDuracionEstimada.TabIndex = 19;
            // 
            // txtRequerimientosEspeciales
            // 
            txtRequerimientosEspeciales.Location = new Point(8, 262);
            txtRequerimientosEspeciales.Name = "txtRequerimientosEspeciales";
            txtRequerimientosEspeciales.Size = new Size(147, 23);
            txtRequerimientosEspeciales.TabIndex = 18;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(8, 244);
            label10.Name = "label10";
            label10.Size = new Size(130, 15);
            label10.TabIndex = 17;
            label10.Text = "Requerimiento Especial";
            // 
            // txtResultadoEjecucion
            // 
            txtResultadoEjecucion.Location = new Point(11, 208);
            txtResultadoEjecucion.Name = "txtResultadoEjecucion";
            txtResultadoEjecucion.Size = new Size(144, 23);
            txtResultadoEjecucion.TabIndex = 16;
            // 
            // cbPlanificacion
            // 
            cbPlanificacion.FormattingEnabled = true;
            cbPlanificacion.Location = new Point(9, 103);
            cbPlanificacion.Margin = new Padding(3, 2, 3, 2);
            cbPlanificacion.Name = "cbPlanificacion";
            cbPlanificacion.Size = new Size(285, 23);
            cbPlanificacion.TabIndex = 13;
            // 
            // btnCancelarMp
            // 
            btnCancelarMp.Location = new Point(212, 330);
            btnCancelarMp.Margin = new Padding(3, 2, 3, 2);
            btnCancelarMp.Name = "btnCancelarMp";
            btnCancelarMp.Size = new Size(79, 26);
            btnCancelarMp.TabIndex = 12;
            btnCancelarMp.Text = "Cancelar";
            btnCancelarMp.UseVisualStyleBackColor = true;
            // 
            // dgvMP
            // 
            dgvMP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMP.Location = new Point(349, 62);
            dgvMP.Margin = new Padding(3, 2, 3, 2);
            dgvMP.Name = "dgvMP";
            dgvMP.RowHeadersWidth = 51;
            dgvMP.Size = new Size(481, 158);
            dgvMP.TabIndex = 10;
            // 
            // btnNuevoMp
            // 
            btnNuevoMp.Location = new Point(349, 240);
            btnNuevoMp.Margin = new Padding(3, 2, 3, 2);
            btnNuevoMp.Name = "btnNuevoMp";
            btnNuevoMp.Size = new Size(100, 43);
            btnNuevoMp.TabIndex = 12;
            btnNuevoMp.Text = "Nuevo";
            btnNuevoMp.UseVisualStyleBackColor = true;
            btnNuevoMp.Click += btnNuevoMp_Click;
            // 
            // btnEditarMp
            // 
            btnEditarMp.Location = new Point(462, 240);
            btnEditarMp.Margin = new Padding(3, 2, 3, 2);
            btnEditarMp.Name = "btnEditarMp";
            btnEditarMp.Size = new Size(100, 43);
            btnEditarMp.TabIndex = 13;
            btnEditarMp.Text = "Editar";
            btnEditarMp.UseVisualStyleBackColor = true;
            btnEditarMp.Click += btnEditarMp_Click;
            // 
            // btnDesahabilitarMp
            // 
            btnDesahabilitarMp.Location = new Point(575, 240);
            btnDesahabilitarMp.Margin = new Padding(3, 2, 3, 2);
            btnDesahabilitarMp.Name = "btnDesahabilitarMp";
            btnDesahabilitarMp.Size = new Size(100, 43);
            btnDesahabilitarMp.TabIndex = 12;
            btnDesahabilitarMp.Text = "Desahabilitar";
            btnDesahabilitarMp.UseVisualStyleBackColor = true;
            btnDesahabilitarMp.Click += btnDesahabilitarMp_Click;
            // 
            // btnSalirMp
            // 
            btnSalirMp.Location = new Point(679, 240);
            btnSalirMp.Margin = new Padding(3, 2, 3, 2);
            btnSalirMp.Name = "btnSalirMp";
            btnSalirMp.Size = new Size(100, 43);
            btnSalirMp.TabIndex = 21;
            btnSalirMp.Text = "Salir";
            btnSalirMp.UseVisualStyleBackColor = true;
            // 
            // txtIDSearch
            // 
            txtIDSearch.Location = new Point(599, 335);
            txtIDSearch.Name = "txtIDSearch";
            txtIDSearch.Size = new Size(180, 23);
            txtIDSearch.TabIndex = 22;
            // 
            // MantenimientoPreventivo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(842, 495);
            Controls.Add(txtIDSearch);
            Controls.Add(label9);
            Controls.Add(btnConsultarMp);
            Controls.Add(btnSalirMp);
            Controls.Add(dtPickerFechaMp);
            Controls.Add(btnDesahabilitarMp);
            Controls.Add(btnEditarMp);
            Controls.Add(label8);
            Controls.Add(dgvMP);
            Controls.Add(Planificacion);
            Controls.Add(label2);
            Controls.Add(btnNuevoMp);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "MantenimientoPreventivo";
            Text = "MantenimientoPreventivo";
            Load += MantenimientoPreventivo_Load;
            Planificacion.ResumeLayout(false);
            Planificacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMP).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtId;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker dtPickerFechaMantenimiento;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btnRegistrarMp;
        private Button btnModificarMp;
        private Button btnConsultarMp;
        private Label label8;
        private DateTimePicker dtPickerFechaMp;
        private Label label9;
        private GroupBox Planificacion;
        private DataGridView dgvMP;
        private Button btnNuevoMp;
        private Button btnEditarMp;
        private Button btnDesahabilitarMp;
        private Button btnCancelarMp;
        private Button btnSalirMp;
        private ComboBox cbPlanificacion;
        private TextBox txtRequerimientosEspeciales;
        private Label label10;
        private TextBox txtResultadoEjecucion;
        private TextBox txtDuracionEstimada;
        private TextBox txtComentarios;
        private Label label11;
        private TextBox txtIDSearch;
    }
}