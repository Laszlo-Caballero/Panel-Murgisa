namespace CapaPresentacion.Personal_Forms
{
    partial class Cargo
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
            txtCargo = new TextBox();
            txtNombre = new TextBox();
            label2 = new Label();
            txtDesc = new TextBox();
            label3 = new Label();
            cbkEstado = new CheckBox();
            dgvCargo = new DataGridView();
            txtCriterio = new TextBox();
            label5 = new Label();
            btnBuscar = new Button();
            btnAgregar = new Button();
            btnEditar = new Button();
            btnDeshabilitar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCargo).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 28);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 0;
            label1.Text = "CARGOID:";
            // 
            // txtCargo
            // 
            txtCargo.Enabled = false;
            txtCargo.Location = new Point(114, 24);
            txtCargo.Margin = new Padding(3, 4, 3, 4);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(142, 27);
            txtCargo.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(114, 84);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(142, 27);
            txtNombre.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 88);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 2;
            label2.Text = "NOMBRE:";
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(426, 24);
            txtDesc.Margin = new Padding(3, 4, 3, 4);
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(415, 27);
            txtDesc.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(323, 32);
            label3.Name = "label3";
            label3.Size = new Size(104, 20);
            label3.TabIndex = 4;
            label3.Text = "DESCRIPCION:";
            // 
            // cbkEstado
            // 
            cbkEstado.AutoSize = true;
            cbkEstado.Location = new Point(323, 84);
            cbkEstado.Margin = new Padding(3, 4, 3, 4);
            cbkEstado.Name = "cbkEstado";
            cbkEstado.Size = new Size(86, 24);
            cbkEstado.TabIndex = 8;
            cbkEstado.Text = "ESTADO";
            cbkEstado.UseVisualStyleBackColor = true;
            // 
            // dgvCargo
            // 
            dgvCargo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCargo.Location = new Point(14, 192);
            dgvCargo.Margin = new Padding(3, 4, 3, 4);
            dgvCargo.Name = "dgvCargo";
            dgvCargo.ReadOnly = true;
            dgvCargo.RowHeadersWidth = 82;
            dgvCargo.Size = new Size(703, 321);
            dgvCargo.TabIndex = 9;
            dgvCargo.CellDoubleClick += dgvCargo_CellDoubleClick;
            // 
            // txtCriterio
            // 
            txtCriterio.Location = new Point(114, 140);
            txtCriterio.Margin = new Padding(3, 4, 3, 4);
            txtCriterio.Name = "txtCriterio";
            txtCriterio.Size = new Size(142, 27);
            txtCriterio.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 144);
            label5.Name = "label5";
            label5.Size = new Size(71, 20);
            label5.TabIndex = 10;
            label5.Text = "CRITERIO";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(317, 128);
            btnBuscar.Margin = new Padding(3, 4, 3, 4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(103, 51);
            btnBuscar.TabIndex = 12;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(735, 227);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(136, 51);
            btnAgregar.TabIndex = 13;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(735, 312);
            btnEditar.Margin = new Padding(3, 4, 3, 4);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(136, 51);
            btnEditar.TabIndex = 14;
            btnEditar.Text = "EDITAR";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnDeshabilitar
            // 
            btnDeshabilitar.Location = new Point(735, 388);
            btnDeshabilitar.Margin = new Padding(3, 4, 3, 4);
            btnDeshabilitar.Name = "btnDeshabilitar";
            btnDeshabilitar.Size = new Size(136, 51);
            btnDeshabilitar.TabIndex = 15;
            btnDeshabilitar.Text = "DESHABILITAR";
            btnDeshabilitar.UseVisualStyleBackColor = true;
            btnDeshabilitar.Click += btnDeshabilitar_Click;
            // 
            // Cargo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(883, 541);
            Controls.Add(btnDeshabilitar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Controls.Add(btnBuscar);
            Controls.Add(txtCriterio);
            Controls.Add(label5);
            Controls.Add(dgvCargo);
            Controls.Add(cbkEstado);
            Controls.Add(txtDesc);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(txtCargo);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Cargo";
            Text = "Cargo";
            ((System.ComponentModel.ISupportInitialize)dgvCargo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCargo;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtDesc;
        private Label label3;
        private CheckBox cbkEstado;
        private DataGridView dgvCargo;
        private TextBox txtCriterio;
        private Label label5;
        private Button btnBuscar;
        private Button btnAgregar;
        private Button btnEditar;
        private Button btnDeshabilitar;
    }
}