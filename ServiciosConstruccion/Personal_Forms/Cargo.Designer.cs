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
            label1.Location = new Point(24, 21);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 0;
            label1.Text = "CARGOID:";
            // 
            // txtCargo
            // 
            txtCargo.Location = new Point(100, 18);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(125, 23);
            txtCargo.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(100, 63);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 23);
            txtNombre.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 66);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 2;
            label2.Text = "NOMBRE:";
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(373, 18);
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(364, 23);
            txtDesc.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(283, 24);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 4;
            label3.Text = "DESCRIPCION:";
            // 
            // cbkEstado
            // 
            cbkEstado.AutoSize = true;
            cbkEstado.Location = new Point(283, 63);
            cbkEstado.Name = "cbkEstado";
            cbkEstado.Size = new Size(68, 19);
            cbkEstado.TabIndex = 8;
            cbkEstado.Text = "ESTADO";
            cbkEstado.UseVisualStyleBackColor = true;
            // 
            // dgvCargo
            // 
            dgvCargo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCargo.Location = new Point(12, 144);
            dgvCargo.Name = "dgvCargo";
            dgvCargo.ReadOnly = true;
            dgvCargo.RowHeadersWidth = 82;
            dgvCargo.Size = new Size(615, 241);
            dgvCargo.TabIndex = 9;
            dgvCargo.CellContentDoubleClick += dgvCargo_CellContentDoubleClick;
            // 
            // txtCriterio
            // 
            txtCriterio.Location = new Point(100, 105);
            txtCriterio.Name = "txtCriterio";
            txtCriterio.Size = new Size(125, 23);
            txtCriterio.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 108);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 10;
            label5.Text = "CRITERIO";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(277, 96);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(90, 38);
            btnBuscar.TabIndex = 12;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(643, 170);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(100, 38);
            btnAgregar.TabIndex = 13;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(643, 234);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(100, 38);
            btnEditar.TabIndex = 14;
            btnEditar.Text = "EDITAR";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnDeshabilitar
            // 
            btnDeshabilitar.Location = new Point(643, 291);
            btnDeshabilitar.Name = "btnDeshabilitar";
            btnDeshabilitar.Size = new Size(100, 38);
            btnDeshabilitar.TabIndex = 15;
            btnDeshabilitar.Text = "DESHABILITAR";
            btnDeshabilitar.UseVisualStyleBackColor = true;
            btnDeshabilitar.Click += btnDeshabilitar_Click;
            // 
            // Cargo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(755, 406);
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