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
            txtDepartamento.Location = new Point(138, 27);
            txtDepartamento.Name = "txtDepartamento";
            txtDepartamento.Size = new Size(125, 23);
            txtDepartamento.TabIndex = 5;
            txtDepartamento.TextChanged += txtDepartamento_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 30);
            label1.Name = "label1";
            label1.Size = new Size(111, 15);
            label1.TabIndex = 4;
            label1.Text = "DEPARTAMENTO ID:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(96, 74);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 23);
            txtNombre.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 77);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 6;
            label2.Text = "NOMBRE";
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(378, 30);
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(356, 23);
            txtDesc.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(286, 33);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 8;
            label3.Text = "DESCRIPCION";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(453, 74);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(125, 23);
            txtBuscar.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(378, 79);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 10;
            label4.Text = "CRITERIO";
            // 
            // cbkEstado
            // 
            cbkEstado.AutoSize = true;
            cbkEstado.Location = new Point(268, 78);
            cbkEstado.Name = "cbkEstado";
            cbkEstado.Size = new Size(68, 19);
            cbkEstado.TabIndex = 12;
            cbkEstado.Text = "ESTADO";
            cbkEstado.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(606, 68);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(83, 36);
            btnBuscar.TabIndex = 13;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // dgvDepartamento
            // 
            dgvDepartamento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDepartamento.Location = new Point(32, 125);
            dgvDepartamento.Name = "dgvDepartamento";
            dgvDepartamento.RowHeadersWidth = 82;
            dgvDepartamento.Size = new Size(456, 223);
            dgvDepartamento.TabIndex = 14;
            dgvDepartamento.CellDoubleClick += dgvDepartamento_CellDoubleClick;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(503, 142);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(107, 36);
            btnAgregar.TabIndex = 15;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(503, 208);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(107, 36);
            btnEditar.TabIndex = 16;
            btnEditar.Text = "EDITAR";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnDeshabilitar
            // 
            btnDeshabilitar.Location = new Point(503, 276);
            btnDeshabilitar.Name = "btnDeshabilitar";
            btnDeshabilitar.Size = new Size(107, 36);
            btnDeshabilitar.TabIndex = 17;
            btnDeshabilitar.Text = "DESHABILITAR";
            btnDeshabilitar.UseVisualStyleBackColor = true;
            btnDeshabilitar.Click += btnDeshabilitar_Click;
            // 
            // Departamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(752, 373);
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