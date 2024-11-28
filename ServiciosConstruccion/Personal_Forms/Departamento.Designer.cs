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
            cbkEstado = new CheckBox();
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
            txtDepartamento.Enabled = false;
            txtDepartamento.Location = new Point(158, 36);
            txtDepartamento.Margin = new Padding(3, 4, 3, 4);
            txtDepartamento.Name = "txtDepartamento";
            txtDepartamento.Size = new Size(142, 27);
            txtDepartamento.TabIndex = 5;
            txtDepartamento.TextChanged += txtDepartamento_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 40);
            label1.Name = "label1";
            label1.Size = new Size(142, 20);
            label1.TabIndex = 4;
            label1.Text = "DEPARTAMENTO ID:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(110, 99);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(142, 27);
            txtNombre.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 103);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 6;
            label2.Text = "NOMBRE";
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(432, 40);
            txtDesc.Margin = new Padding(3, 4, 3, 4);
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(406, 27);
            txtDesc.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(327, 44);
            label3.Name = "label3";
            label3.Size = new Size(101, 20);
            label3.TabIndex = 8;
            label3.Text = "DESCRIPCION";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(518, 99);
            txtBuscar.Margin = new Padding(3, 4, 3, 4);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(142, 27);
            txtBuscar.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(432, 105);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 10;
            label4.Text = "CRITERIO";
            // 
            // cbkEstado
            // 
            cbkEstado.AutoSize = true;
            cbkEstado.Location = new Point(306, 104);
            cbkEstado.Margin = new Padding(3, 4, 3, 4);
            cbkEstado.Name = "cbkEstado";
            cbkEstado.Size = new Size(86, 24);
            cbkEstado.TabIndex = 12;
            cbkEstado.Text = "ESTADO";
            cbkEstado.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(693, 91);
            btnBuscar.Margin = new Padding(3, 4, 3, 4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(95, 48);
            btnBuscar.TabIndex = 13;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // dgvDepartamento
            // 
            dgvDepartamento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDepartamento.Location = new Point(37, 167);
            dgvDepartamento.Margin = new Padding(3, 4, 3, 4);
            dgvDepartamento.Name = "dgvDepartamento";
            dgvDepartamento.RowHeadersWidth = 82;
            dgvDepartamento.Size = new Size(521, 297);
            dgvDepartamento.TabIndex = 14;
            dgvDepartamento.CellDoubleClick += dgvDepartamento_CellDoubleClick;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(605, 184);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(122, 48);
            btnAgregar.TabIndex = 15;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(605, 271);
            btnEditar.Margin = new Padding(3, 4, 3, 4);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(122, 48);
            btnEditar.TabIndex = 16;
            btnEditar.Text = "EDITAR";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnDeshabilitar
            // 
            btnDeshabilitar.Location = new Point(605, 358);
            btnDeshabilitar.Margin = new Padding(3, 4, 3, 4);
            btnDeshabilitar.Name = "btnDeshabilitar";
            btnDeshabilitar.Size = new Size(122, 48);
            btnDeshabilitar.TabIndex = 17;
            btnDeshabilitar.Text = "DESHABILITAR";
            btnDeshabilitar.UseVisualStyleBackColor = true;
            btnDeshabilitar.Click += btnDeshabilitar_Click;
            // 
            // Departamento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 497);
            Controls.Add(btnDeshabilitar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Controls.Add(dgvDepartamento);
            Controls.Add(btnBuscar);
            Controls.Add(cbkEstado);
            Controls.Add(txtBuscar);
            Controls.Add(label4);
            Controls.Add(txtDesc);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(txtDepartamento);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
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
        private CheckBox cbkEstado;
        private Button btnBuscar;
        private DataGridView dgvDepartamento;
        private Button btnAgregar;
        private Button btnEditar;
        private Button btnDeshabilitar;
    }
}