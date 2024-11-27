namespace CapaPresentacion.Personal_Forms
{
    partial class Personal
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
            txtPersonal = new TextBox();
            cbkEstado = new CheckBox();
            bttnAgregar = new Button();
            cbCargo = new ComboBox();
            txtPaterno = new TextBox();
            label2 = new Label();
            txtNombre = new TextBox();
            label3 = new Label();
            txtMaterno = new TextBox();
            label4 = new Label();
            txtSueldo = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            cbProfesion = new ComboBox();
            label8 = new Label();
            cbDepartamento = new ComboBox();
            bttnEditar = new Button();
            bttnDeshabilitar = new Button();
            bttnBuscar = new Button();
            dgvPersonal = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvPersonal).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 0;
            label1.Text = "PERSONAL ID:";
            // 
            // txtPersonal
            // 
            txtPersonal.Location = new Point(100, 13);
            txtPersonal.Name = "txtPersonal";
            txtPersonal.Size = new Size(121, 23);
            txtPersonal.TabIndex = 1;
            // 
            // cbkEstado
            // 
            cbkEstado.AutoSize = true;
            cbkEstado.Location = new Point(590, 66);
            cbkEstado.Name = "cbkEstado";
            cbkEstado.Size = new Size(68, 19);
            cbkEstado.TabIndex = 2;
            cbkEstado.Text = "ESTADO";
            cbkEstado.UseVisualStyleBackColor = true;
            // 
            // bttnAgregar
            // 
            bttnAgregar.Location = new Point(671, 227);
            bttnAgregar.Name = "bttnAgregar";
            bttnAgregar.Size = new Size(103, 34);
            bttnAgregar.TabIndex = 3;
            bttnAgregar.Text = "AGREGAR";
            bttnAgregar.UseVisualStyleBackColor = true;
            // 
            // cbCargo
            // 
            cbCargo.FormattingEnabled = true;
            cbCargo.Location = new Point(76, 114);
            cbCargo.Name = "cbCargo";
            cbCargo.Size = new Size(121, 23);
            cbCargo.TabIndex = 4;
            // 
            // txtPaterno
            // 
            txtPaterno.Location = new Point(131, 64);
            txtPaterno.Name = "txtPaterno";
            txtPaterno.Size = new Size(121, 23);
            txtPaterno.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 67);
            label2.Name = "label2";
            label2.Size = new Size(113, 15);
            label2.TabIndex = 5;
            label2.Text = "APELLIDO PATERNO";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(361, 17);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(121, 23);
            txtNombre.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(273, 20);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 7;
            label3.Text = "NOMBRE:";
            // 
            // txtMaterno
            // 
            txtMaterno.Location = new Point(406, 64);
            txtMaterno.Name = "txtMaterno";
            txtMaterno.Size = new Size(121, 23);
            txtMaterno.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(282, 67);
            label4.Name = "label4";
            label4.Size = new Size(118, 15);
            label4.TabIndex = 9;
            label4.Text = "APELLIDO MATERNO";
            // 
            // txtSueldo
            // 
            txtSueldo.Location = new Point(621, 18);
            txtSueldo.Name = "txtSueldo";
            txtSueldo.Size = new Size(121, 23);
            txtSueldo.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(555, 21);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 11;
            label5.Text = "SUELDO";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 117);
            label6.Name = "label6";
            label6.Size = new Size(47, 15);
            label6.TabIndex = 13;
            label6.Text = "CARGO";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(242, 117);
            label7.Name = "label7";
            label7.Size = new Size(69, 15);
            label7.TabIndex = 15;
            label7.Text = "PROFESION";
            // 
            // cbProfesion
            // 
            cbProfesion.FormattingEnabled = true;
            cbProfesion.Location = new Point(317, 114);
            cbProfesion.Name = "cbProfesion";
            cbProfesion.Size = new Size(121, 23);
            cbProfesion.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(490, 117);
            label8.Name = "label8";
            label8.Size = new Size(94, 15);
            label8.TabIndex = 17;
            label8.Text = "DEPARTAMENTO";
            // 
            // cbDepartamento
            // 
            cbDepartamento.FormattingEnabled = true;
            cbDepartamento.Location = new Point(590, 114);
            cbDepartamento.Name = "cbDepartamento";
            cbDepartamento.Size = new Size(121, 23);
            cbDepartamento.TabIndex = 16;
            // 
            // bttnEditar
            // 
            bttnEditar.Location = new Point(671, 279);
            bttnEditar.Name = "bttnEditar";
            bttnEditar.Size = new Size(103, 34);
            bttnEditar.TabIndex = 18;
            bttnEditar.Text = "EDITAR";
            bttnEditar.UseVisualStyleBackColor = true;
            // 
            // bttnDeshabilitar
            // 
            bttnDeshabilitar.Location = new Point(671, 329);
            bttnDeshabilitar.Name = "bttnDeshabilitar";
            bttnDeshabilitar.Size = new Size(103, 34);
            bttnDeshabilitar.TabIndex = 19;
            bttnDeshabilitar.Text = "DESHABILITAR";
            bttnDeshabilitar.UseVisualStyleBackColor = true;
            // 
            // bttnBuscar
            // 
            bttnBuscar.Location = new Point(671, 176);
            bttnBuscar.Name = "bttnBuscar";
            bttnBuscar.Size = new Size(103, 34);
            bttnBuscar.TabIndex = 20;
            bttnBuscar.Text = "BUSCAR";
            bttnBuscar.UseVisualStyleBackColor = true;
            // 
            // dgvPersonal
            // 
            dgvPersonal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPersonal.Location = new Point(23, 163);
            dgvPersonal.Name = "dgvPersonal";
            dgvPersonal.RowHeadersWidth = 82;
            dgvPersonal.Size = new Size(622, 251);
            dgvPersonal.TabIndex = 21;
            // 
            // Personal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(813, 437);
            Controls.Add(dgvPersonal);
            Controls.Add(bttnBuscar);
            Controls.Add(bttnDeshabilitar);
            Controls.Add(bttnEditar);
            Controls.Add(label8);
            Controls.Add(cbDepartamento);
            Controls.Add(label7);
            Controls.Add(cbProfesion);
            Controls.Add(label6);
            Controls.Add(txtSueldo);
            Controls.Add(label5);
            Controls.Add(txtMaterno);
            Controls.Add(label4);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(txtPaterno);
            Controls.Add(label2);
            Controls.Add(cbCargo);
            Controls.Add(bttnAgregar);
            Controls.Add(cbkEstado);
            Controls.Add(txtPersonal);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Personal";
            Text = "Personal";
            ((System.ComponentModel.ISupportInitialize)dgvPersonal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPersonal;
        private CheckBox cbkEstado;
        private Button bttnAgregar;
        private ComboBox cbCargo;
        private TextBox txtPaterno;
        private Label label2;
        private TextBox txtNombre;
        private Label label3;
        private TextBox txtMaterno;
        private Label label4;
        private TextBox txtSueldo;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox cbProfesion;
        private Label label8;
        private ComboBox cbDepartamento;
        private Button bttnEditar;
        private Button bttnDeshabilitar;
        private Button bttnBuscar;
        private DataGridView dgvPersonal;
    }
}