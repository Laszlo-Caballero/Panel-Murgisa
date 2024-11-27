namespace CapaPresentacion.Personal_Forms
{
    partial class Departamento
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
            txtDepartamento = new TextBox();
            label1 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            txtDesc = new TextBox();
            label3 = new Label();
            txtBuscar = new TextBox();
            label4 = new Label();
            checkBox1 = new CheckBox();
            btnBuscar = new Button();
            dgvDepartamento = new DataGridView();
            btnAgregar = new Button();
            btnEditar = new Button();
            btnDeshabilitar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDepartamento).BeginInit();
            SuspendLayout();
            // 
            // txtDepartamento
            // 
            txtDepartamento.Location = new Point(277, 45);
            txtDepartamento.Margin = new Padding(6, 6, 6, 6);
            txtDepartamento.Name = "txtDepartamento";
            txtDepartamento.Size = new Size(229, 39);
            txtDepartamento.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 51);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(225, 32);
            label1.TabIndex = 4;
            label1.Text = "DEPARTAMENTO ID:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(199, 145);
            txtNombre.Margin = new Padding(6, 6, 6, 6);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(229, 39);
            txtNombre.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 151);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(112, 32);
            label2.TabIndex = 6;
            label2.Text = "NOMBRE";
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(722, 51);
            txtDesc.Margin = new Padding(6, 6, 6, 6);
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(658, 39);
            txtDesc.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(552, 58);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(161, 32);
            label3.TabIndex = 8;
            label3.Text = "DESCRIPCION";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(862, 145);
            txtBuscar.Margin = new Padding(6, 6, 6, 6);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(229, 39);
            txtBuscar.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(722, 156);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(112, 32);
            label4.TabIndex = 10;
            label4.Text = "CRITERIO";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(518, 154);
            checkBox1.Margin = new Padding(6, 6, 6, 6);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(132, 36);
            checkBox1.TabIndex = 12;
            checkBox1.Text = "ESTADO";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(1146, 132);
            btnBuscar.Margin = new Padding(6, 6, 6, 6);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(154, 77);
            btnBuscar.TabIndex = 13;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // dgvDepartamento
            // 
            dgvDepartamento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDepartamento.Location = new Point(59, 267);
            dgvDepartamento.Margin = new Padding(6, 6, 6, 6);
            dgvDepartamento.Name = "dgvDepartamento";
            dgvDepartamento.RowHeadersWidth = 82;
            dgvDepartamento.Size = new Size(912, 518);
            dgvDepartamento.TabIndex = 14;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(1010, 320);
            btnAgregar.Margin = new Padding(6, 6, 6, 6);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(199, 77);
            btnAgregar.TabIndex = 15;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(1010, 461);
            btnEditar.Margin = new Padding(6, 6, 6, 6);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(199, 77);
            btnEditar.TabIndex = 16;
            btnEditar.Text = "EDITAR";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnDeshabilitar
            // 
            btnDeshabilitar.Location = new Point(1010, 606);
            btnDeshabilitar.Margin = new Padding(6, 6, 6, 6);
            btnDeshabilitar.Name = "btnDeshabilitar";
            btnDeshabilitar.Size = new Size(199, 77);
            btnDeshabilitar.TabIndex = 17;
            btnDeshabilitar.Text = "DESHABILITAR";
            btnDeshabilitar.UseVisualStyleBackColor = true;
            // 
            // Departamento
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1486, 960);
            Controls.Add(btnDeshabilitar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Controls.Add(dgvDepartamento);
            Controls.Add(btnBuscar);
            Controls.Add(checkBox1);
            Controls.Add(txtBuscar);
            Controls.Add(label4);
            Controls.Add(txtDesc);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(txtDepartamento);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6, 6, 6, 6);
            Name = "Departamento";
            Text = "Departamento";
            ((System.ComponentModel.ISupportInitialize)dgvDepartamento).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDepartamento;
        private Label label1;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtDesc;
        private Label label3;
        private TextBox txtBuscar;
        private Label label4;
        private CheckBox checkBox1;
        private Button btnBuscar;
        private DataGridView dgvDepartamento;
        private Button btnAgregar;
        private Button btnEditar;
        private Button btnDeshabilitar;
    }
}