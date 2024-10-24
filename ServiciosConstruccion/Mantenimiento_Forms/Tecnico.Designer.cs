namespace CapaPresentacion.Mantenimiento_Forms
{
    partial class Tecnico
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            dgvTecnico = new DataGridView();
            txtNombreTecnico = new TextBox();
            txtTelefonoTecnico = new TextBox();
            dtPickerIngresoTecnico = new DateTimePicker();
            cbkDisponible = new CheckBox();
            cbkNoDisponible = new CheckBox();
            cbEspecialidadTecnico = new ComboBox();
            btnAgregarTecnico = new Button();
            btnModificarTecnico = new Button();
            btnCancelarTecnico = new Button();
            btnNuevoTecnico = new Button();
            btnDesahabilitarTecnico = new Button();
            btnSalirT = new Button();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvTecnico).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(351, 28);
            label1.Name = "label1";
            label1.Size = new Size(117, 20);
            label1.TabIndex = 0;
            label1.Text = "Agregar Tecnico";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 32);
            label2.Name = "label2";
            label2.Size = new Size(134, 20);
            label2.TabIndex = 1;
            label2.Text = "Nombre Completo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 116);
            label3.Name = "label3";
            label3.Size = new Size(93, 20);
            label3.TabIndex = 2;
            label3.Text = "Especialidad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 206);
            label4.Name = "label4";
            label4.Size = new Size(107, 20);
            label4.TabIndex = 3;
            label4.Text = "Disponibilidad";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 277);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 4;
            label5.Text = "Telefono";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 362);
            label6.Name = "label6";
            label6.Size = new Size(121, 20);
            label6.TabIndex = 5;
            label6.Text = "Fecha de Ingreso";
            // 
            // dgvTecnico
            // 
            dgvTecnico.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTecnico.Location = new Point(319, 77);
            dgvTecnico.Name = "dgvTecnico";
            dgvTecnico.RowHeadersWidth = 51;
            dgvTecnico.Size = new Size(590, 230);
            dgvTecnico.TabIndex = 6;
            // 
            // txtNombreTecnico
            // 
            txtNombreTecnico.Location = new Point(20, 65);
            txtNombreTecnico.Name = "txtNombreTecnico";
            txtNombreTecnico.Size = new Size(191, 27);
            txtNombreTecnico.TabIndex = 7;
            // 
            // txtTelefonoTecnico
            // 
            txtTelefonoTecnico.Location = new Point(25, 316);
            txtTelefonoTecnico.Name = "txtTelefonoTecnico";
            txtTelefonoTecnico.Size = new Size(191, 27);
            txtTelefonoTecnico.TabIndex = 8;
            // 
            // dtPickerIngresoTecnico
            // 
            dtPickerIngresoTecnico.Location = new Point(27, 397);
            dtPickerIngresoTecnico.Name = "dtPickerIngresoTecnico";
            dtPickerIngresoTecnico.Size = new Size(193, 27);
            dtPickerIngresoTecnico.TabIndex = 9;
            // 
            // cbkDisponible
            // 
            cbkDisponible.AutoSize = true;
            cbkDisponible.Location = new Point(31, 241);
            cbkDisponible.Name = "cbkDisponible";
            cbkDisponible.Size = new Size(103, 24);
            cbkDisponible.TabIndex = 10;
            cbkDisponible.Text = "Disponible";
            cbkDisponible.UseVisualStyleBackColor = true;
            // 
            // cbkNoDisponible
            // 
            cbkNoDisponible.AutoSize = true;
            cbkNoDisponible.Location = new Point(152, 242);
            cbkNoDisponible.Name = "cbkNoDisponible";
            cbkNoDisponible.Size = new Size(127, 24);
            cbkNoDisponible.TabIndex = 11;
            cbkNoDisponible.Text = "No Disponible";
            cbkNoDisponible.UseVisualStyleBackColor = true;
            // 
            // cbEspecialidadTecnico
            // 
            cbEspecialidadTecnico.FormattingEnabled = true;
            cbEspecialidadTecnico.Location = new Point(24, 149);
            cbEspecialidadTecnico.Name = "cbEspecialidadTecnico";
            cbEspecialidadTecnico.Size = new Size(194, 28);
            cbEspecialidadTecnico.TabIndex = 12;
            // 
            // btnAgregarTecnico
            // 
            btnAgregarTecnico.Location = new Point(28, 447);
            btnAgregarTecnico.Name = "btnAgregarTecnico";
            btnAgregarTecnico.Size = new Size(188, 38);
            btnAgregarTecnico.TabIndex = 13;
            btnAgregarTecnico.Text = "Agregar Tecnico";
            btnAgregarTecnico.UseVisualStyleBackColor = true;
            // 
            // btnModificarTecnico
            // 
            btnModificarTecnico.Location = new Point(31, 497);
            btnModificarTecnico.Name = "btnModificarTecnico";
            btnModificarTecnico.Size = new Size(185, 38);
            btnModificarTecnico.TabIndex = 14;
            btnModificarTecnico.Text = "Modificar";
            btnModificarTecnico.UseVisualStyleBackColor = true;
            // 
            // btnCancelarTecnico
            // 
            btnCancelarTecnico.Location = new Point(31, 541);
            btnCancelarTecnico.Name = "btnCancelarTecnico";
            btnCancelarTecnico.Size = new Size(180, 38);
            btnCancelarTecnico.TabIndex = 15;
            btnCancelarTecnico.Text = "Cancelar";
            btnCancelarTecnico.UseVisualStyleBackColor = true;
            // 
            // btnNuevoTecnico
            // 
            btnNuevoTecnico.Location = new Point(319, 338);
            btnNuevoTecnico.Name = "btnNuevoTecnico";
            btnNuevoTecnico.Size = new Size(123, 38);
            btnNuevoTecnico.TabIndex = 16;
            btnNuevoTecnico.Text = "Nuevo";
            btnNuevoTecnico.UseVisualStyleBackColor = true;
            // 
            // btnDesahabilitarTecnico
            // 
            btnDesahabilitarTecnico.Location = new Point(461, 338);
            btnDesahabilitarTecnico.Name = "btnDesahabilitarTecnico";
            btnDesahabilitarTecnico.Size = new Size(123, 38);
            btnDesahabilitarTecnico.TabIndex = 17;
            btnDesahabilitarTecnico.Text = "Desahabilitar";
            btnDesahabilitarTecnico.UseVisualStyleBackColor = true;
            // 
            // btnSalirT
            // 
            btnSalirT.Location = new Point(606, 338);
            btnSalirT.Name = "btnSalirT";
            btnSalirT.Size = new Size(123, 38);
            btnSalirT.TabIndex = 18;
            btnSalirT.Text = "Salir";
            btnSalirT.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCancelarTecnico);
            groupBox1.Controls.Add(btnModificarTecnico);
            groupBox1.Controls.Add(btnAgregarTecnico);
            groupBox1.Controls.Add(cbEspecialidadTecnico);
            groupBox1.Controls.Add(cbkNoDisponible);
            groupBox1.Controls.Add(cbkDisponible);
            groupBox1.Controls.Add(dtPickerIngresoTecnico);
            groupBox1.Controls.Add(txtTelefonoTecnico);
            groupBox1.Controls.Add(txtNombreTecnico);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(10, 42);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(296, 596);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tecnico";
            // 
            // Tecnico
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1023, 659);
            Controls.Add(groupBox1);
            Controls.Add(btnSalirT);
            Controls.Add(btnDesahabilitarTecnico);
            Controls.Add(btnNuevoTecnico);
            Controls.Add(dgvTecnico);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Tecnico";
            Text = "Tecnico";
            ((System.ComponentModel.ISupportInitialize)dgvTecnico).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private DataGridView dgvTecnico;
        private TextBox txtNombreTecnico;
        private TextBox txtTelefonoTecnico;
        private DateTimePicker dtPickerIngresoTecnico;
        private CheckBox cbkDisponible;
        private CheckBox cbkNoDisponible;
        private ComboBox cbEspecialidadTecnico;
        private Button btnAgregarTecnico;
        private Button btnModificarTecnico;
        private Button btnCancelarTecnico;
        private Button btnNuevoTecnico;
        private Button btnDesahabilitarTecnico;
        private Button btnSalirT;
        private GroupBox groupBox1;
    }
}