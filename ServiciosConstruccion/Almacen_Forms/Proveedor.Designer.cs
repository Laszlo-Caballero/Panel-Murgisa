namespace CapaPresentacion.Almacen_Forms
{
    partial class Proveedor
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
            bttnDeshabilitar = new Button();
            bttnSalir = new Button();
            btnEditar = new Button();
            btnNuevo = new Button();
            dgvProveedor = new DataGridView();
            label3 = new Label();
            gbProveedor = new GroupBox();
            dtpProveedor = new DateTimePicker();
            label6 = new Label();
            cbkEstado = new CheckBox();
            txtCodigo = new TextBox();
            label5 = new Label();
            bttnCancelar = new Button();
            bttnModificar = new Button();
            bttnAgregar = new Button();
            txtRuc = new TextBox();
            label2 = new Label();
            txtRazSocial = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProveedor).BeginInit();
            gbProveedor.SuspendLayout();
            SuspendLayout();
            // 
            // bttnDeshabilitar
            // 
            bttnDeshabilitar.Location = new Point(572, 309);
            bttnDeshabilitar.Name = "bttnDeshabilitar";
            bttnDeshabilitar.Size = new Size(91, 33);
            bttnDeshabilitar.TabIndex = 13;
            bttnDeshabilitar.Text = "Deshabilitar";
            bttnDeshabilitar.UseVisualStyleBackColor = true;
            // 
            // bttnSalir
            // 
            bttnSalir.Location = new Point(572, 348);
            bttnSalir.Name = "bttnSalir";
            bttnSalir.Size = new Size(91, 33);
            bttnSalir.TabIndex = 12;
            bttnSalir.Text = "Salir";
            bttnSalir.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(572, 270);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(91, 33);
            btnEditar.TabIndex = 11;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(572, 231);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(91, 33);
            btnNuevo.TabIndex = 10;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // dgvProveedor
            // 
            dgvProveedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProveedor.Location = new Point(12, 205);
            dgvProveedor.Name = "dgvProveedor";
            dgvProveedor.Size = new Size(540, 219);
            dgvProveedor.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            label3.Location = new Point(301, 5);
            label3.Name = "label3";
            label3.Size = new Size(126, 32);
            label3.TabIndex = 8;
            label3.Text = "Proveedor";
            // 
            // gbProveedor
            // 
            gbProveedor.Controls.Add(dtpProveedor);
            gbProveedor.Controls.Add(label6);
            gbProveedor.Controls.Add(cbkEstado);
            gbProveedor.Controls.Add(txtCodigo);
            gbProveedor.Controls.Add(label5);
            gbProveedor.Controls.Add(bttnCancelar);
            gbProveedor.Controls.Add(bttnModificar);
            gbProveedor.Controls.Add(bttnAgregar);
            gbProveedor.Controls.Add(txtRuc);
            gbProveedor.Controls.Add(label2);
            gbProveedor.Controls.Add(txtRazSocial);
            gbProveedor.Controls.Add(label1);
            gbProveedor.Location = new Point(12, 40);
            gbProveedor.Name = "gbProveedor";
            gbProveedor.Size = new Size(693, 159);
            gbProveedor.TabIndex = 7;
            gbProveedor.TabStop = false;
            gbProveedor.Text = "Datos Proveedor";
            // 
            // dtpProveedor
            // 
            dtpProveedor.Location = new Point(121, 114);
            dtpProveedor.Name = "dtpProveedor";
            dtpProveedor.Size = new Size(200, 23);
            dtpProveedor.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 114);
            label6.Name = "label6";
            label6.Size = new Size(84, 15);
            label6.TabIndex = 12;
            label6.Text = "Fecha Registro";
            // 
            // cbkEstado
            // 
            cbkEstado.AutoSize = true;
            cbkEstado.Location = new Point(398, 113);
            cbkEstado.Name = "cbkEstado";
            cbkEstado.Size = new Size(107, 19);
            cbkEstado.TabIndex = 11;
            cbkEstado.Text = "Estado Material";
            cbkEstado.UseVisualStyleBackColor = true;
            // 
            // txtCodigo
            // 
            txtCodigo.Enabled = false;
            txtCodigo.Location = new Point(336, 33);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(143, 23);
            txtCodigo.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(272, 36);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 9;
            label5.Text = "Codigo:";
            // 
            // bttnCancelar
            // 
            bttnCancelar.Location = new Point(543, 114);
            bttnCancelar.Name = "bttnCancelar";
            bttnCancelar.Size = new Size(96, 32);
            bttnCancelar.TabIndex = 8;
            bttnCancelar.Text = "Cancelar";
            bttnCancelar.UseVisualStyleBackColor = true;
            // 
            // bttnModificar
            // 
            bttnModificar.Location = new Point(543, 71);
            bttnModificar.Name = "bttnModificar";
            bttnModificar.Size = new Size(96, 32);
            bttnModificar.TabIndex = 7;
            bttnModificar.Text = "Modificar";
            bttnModificar.UseVisualStyleBackColor = true;
            // 
            // bttnAgregar
            // 
            bttnAgregar.Location = new Point(543, 26);
            bttnAgregar.Name = "bttnAgregar";
            bttnAgregar.Size = new Size(96, 32);
            bttnAgregar.TabIndex = 6;
            bttnAgregar.Text = "Agregar";
            bttnAgregar.UseVisualStyleBackColor = true;
            // 
            // txtRuc
            // 
            txtRuc.Location = new Point(105, 71);
            txtRuc.Name = "txtRuc";
            txtRuc.Size = new Size(143, 23);
            txtRuc.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 74);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 2;
            label2.Text = "Ruc:";
            // 
            // txtRazSocial
            // 
            txtRazSocial.Location = new Point(105, 35);
            txtRazSocial.Name = "txtRazSocial";
            txtRazSocial.Size = new Size(143, 23);
            txtRazSocial.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 35);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 0;
            label1.Text = "Razon Social:";
            // 
            // Proveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(733, 450);
            Controls.Add(bttnDeshabilitar);
            Controls.Add(bttnSalir);
            Controls.Add(btnEditar);
            Controls.Add(btnNuevo);
            Controls.Add(dgvProveedor);
            Controls.Add(label3);
            Controls.Add(gbProveedor);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Proveedor";
            Text = "Proveedor";
            ((System.ComponentModel.ISupportInitialize)dgvProveedor).EndInit();
            gbProveedor.ResumeLayout(false);
            gbProveedor.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bttnDeshabilitar;
        private Button bttnSalir;
        private Button btnEditar;
        private Button btnNuevo;
        private DataGridView dgvProveedor;
        private Label label3;
        private GroupBox gbProveedor;
        private DateTimePicker dtpProveedor;
        private Label label6;
        private CheckBox cbkEstado;
        private TextBox txtCodigo;
        private Label label5;
        private Button bttnCancelar;
        private Button bttnModificar;
        private Button bttnAgregar;
        private TextBox txtRuc;
        private Label label2;
        private TextBox txtRazSocial;
        private Label label1;
    }
}