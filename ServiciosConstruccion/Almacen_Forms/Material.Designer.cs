﻿namespace CapaPresentacion.Almacen_Forms
{
    partial class Material
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
            gbMaterial = new GroupBox();
            dtpMaterial = new DateTimePicker();
            label6 = new Label();
            cbkEstado = new CheckBox();
            txtCodigo = new TextBox();
            label5 = new Label();
            bttnCancelar = new Button();
            bttnModificar = new Button();
            bttnAgregar = new Button();
            txtPrecio = new TextBox();
            label4 = new Label();
            cbMaterial = new ComboBox();
            label2 = new Label();
            txtNombre = new TextBox();
            label1 = new Label();
            label3 = new Label();
            dgvMaterial = new DataGridView();
            btnNuevo = new Button();
            btnEditar = new Button();
            bttnSalir = new Button();
            bttnDeshabilitar = new Button();
            gbMaterial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMaterial).BeginInit();
            SuspendLayout();
            // 
            // gbMaterial
            // 
            gbMaterial.Controls.Add(dtpMaterial);
            gbMaterial.Controls.Add(label6);
            gbMaterial.Controls.Add(cbkEstado);
            gbMaterial.Controls.Add(txtCodigo);
            gbMaterial.Controls.Add(label5);
            gbMaterial.Controls.Add(bttnCancelar);
            gbMaterial.Controls.Add(bttnModificar);
            gbMaterial.Controls.Add(bttnAgregar);
            gbMaterial.Controls.Add(txtPrecio);
            gbMaterial.Controls.Add(label4);
            gbMaterial.Controls.Add(cbMaterial);
            gbMaterial.Controls.Add(label2);
            gbMaterial.Controls.Add(txtNombre);
            gbMaterial.Controls.Add(label1);
            gbMaterial.Location = new Point(12, 49);
            gbMaterial.Name = "gbMaterial";
            gbMaterial.Size = new Size(693, 159);
            gbMaterial.TabIndex = 0;
            gbMaterial.TabStop = false;
            gbMaterial.Text = "Datos Material";
            // 
            // dtpMaterial
            // 
            dtpMaterial.Location = new Point(272, 108);
            dtpMaterial.Name = "dtpMaterial";
            dtpMaterial.Size = new Size(200, 23);
            dtpMaterial.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(272, 77);
            label6.Name = "label6";
            label6.Size = new Size(84, 15);
            label6.TabIndex = 12;
            label6.Text = "Fecha Registro";
            // 
            // cbkEstado
            // 
            cbkEstado.AutoSize = true;
            cbkEstado.Location = new Point(414, 75);
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
            // txtPrecio
            // 
            txtPrecio.Location = new Point(105, 111);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(143, 23);
            txtPrecio.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 114);
            label4.Name = "label4";
            label4.Size = new Size(78, 15);
            label4.TabIndex = 4;
            label4.Text = "Precio Venta: ";
            // 
            // cbMaterial
            // 
            cbMaterial.FormattingEnabled = true;
            cbMaterial.Location = new Point(105, 71);
            cbMaterial.Name = "cbMaterial";
            cbMaterial.Size = new Size(143, 23);
            cbMaterial.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 74);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 2;
            label2.Text = "Proveedor:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(105, 35);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(143, 23);
            txtNombre.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 35);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            label3.Location = new Point(301, 14);
            label3.Name = "label3";
            label3.Size = new Size(128, 32);
            label3.TabIndex = 1;
            label3.Text = "Materiales";
            // 
            // dgvMaterial
            // 
            dgvMaterial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMaterial.Location = new Point(12, 214);
            dgvMaterial.Name = "dgvMaterial";
            dgvMaterial.Size = new Size(540, 219);
            dgvMaterial.TabIndex = 2;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(572, 240);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(91, 33);
            btnNuevo.TabIndex = 3;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(572, 279);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(91, 33);
            btnEditar.TabIndex = 4;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // bttnSalir
            // 
            bttnSalir.Location = new Point(572, 357);
            bttnSalir.Name = "bttnSalir";
            bttnSalir.Size = new Size(91, 33);
            bttnSalir.TabIndex = 5;
            bttnSalir.Text = "Salir";
            bttnSalir.UseVisualStyleBackColor = true;
            // 
            // bttnDeshabilitar
            // 
            bttnDeshabilitar.Location = new Point(572, 318);
            bttnDeshabilitar.Name = "bttnDeshabilitar";
            bttnDeshabilitar.Size = new Size(91, 33);
            bttnDeshabilitar.TabIndex = 6;
            bttnDeshabilitar.Text = "Deshabilitar";
            bttnDeshabilitar.UseVisualStyleBackColor = true;
            // 
            // Material
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(747, 445);
            Controls.Add(bttnDeshabilitar);
            Controls.Add(bttnSalir);
            Controls.Add(btnEditar);
            Controls.Add(btnNuevo);
            Controls.Add(dgvMaterial);
            Controls.Add(label3);
            Controls.Add(gbMaterial);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Material";
            Text = "Material";
            gbMaterial.ResumeLayout(false);
            gbMaterial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMaterial).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbMaterial;
        private ComboBox cbMaterial;
        private Label label2;
        private TextBox txtNombre;
        private Label label1;
        private Label label3;
        private TextBox txtPrecio;
        private Label label4;
        private Button bttnCancelar;
        private Button bttnModificar;
        private Button bttnAgregar;
        private TextBox txtCodigo;
        private Label label5;
        private DataGridView dgvMaterial;
        private Button btnNuevo;
        private Button btnEditar;
        private Button bttnSalir;
        private Button bttnDeshabilitar;
        private DateTimePicker dtpMaterial;
        private Label label6;
        private CheckBox cbkEstado;
    }
}