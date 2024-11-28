namespace CapaPresentacion.Servicios_Forms
{
    partial class RecursosFormServicio
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
            btnEditar = new Button();
            btnNuevo = new Button();
            dgvRecursos = new DataGridView();
            cbkEstado = new CheckBox();
            txtCodigo = new TextBox();
            bttnSalir = new Button();
            label5 = new Label();
            bttnCancelar = new Button();
            bttnModificar = new Button();
            bttnAgregar = new Button();
            label4 = new Label();
            cbProveedor = new ComboBox();
            label2 = new Label();
            txtNombre = new TextBox();
            label1 = new Label();
            gbMaterial = new GroupBox();
            cbDisponibilidad = new ComboBox();
            label8 = new Label();
            cbCondicion = new ComboBox();
            label7 = new Label();
            cbTipoRecurso = new ComboBox();
            label6 = new Label();
            txtPrecio = new TextBox();
            label3 = new Label();
            btnDisponibilidad = new Button();
            btnTipoRecurso = new Button();
            btnCondición = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRecursos).BeginInit();
            gbMaterial.SuspendLayout();
            SuspendLayout();
            // 
            // bttnDeshabilitar
            // 
            bttnDeshabilitar.Location = new Point(684, 469);
            bttnDeshabilitar.Margin = new Padding(4, 4, 4, 4);
            bttnDeshabilitar.Name = "bttnDeshabilitar";
            bttnDeshabilitar.Size = new Size(117, 44);
            bttnDeshabilitar.TabIndex = 13;
            bttnDeshabilitar.Text = "Deshabilitar";
            bttnDeshabilitar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(684, 418);
            btnEditar.Margin = new Padding(4, 4, 4, 4);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(117, 43);
            btnEditar.TabIndex = 11;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(684, 367);
            btnNuevo.Margin = new Padding(4, 4, 4, 4);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(117, 43);
            btnNuevo.TabIndex = 10;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // dgvRecursos
            // 
            dgvRecursos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecursos.Location = new Point(44, 332);
            dgvRecursos.Margin = new Padding(4, 4, 4, 4);
            dgvRecursos.Name = "dgvRecursos";
            dgvRecursos.RowHeadersWidth = 82;
            dgvRecursos.Size = new Size(617, 266);
            dgvRecursos.TabIndex = 9;
            // 
            // cbkEstado
            // 
            cbkEstado.AutoSize = true;
            cbkEstado.Location = new Point(311, 87);
            cbkEstado.Margin = new Padding(4, 4, 4, 4);
            cbkEstado.Name = "cbkEstado";
            cbkEstado.Size = new Size(128, 24);
            cbkEstado.TabIndex = 11;
            cbkEstado.Text = "Estado recurso";
            cbkEstado.UseVisualStyleBackColor = true;
            // 
            // txtCodigo
            // 
            txtCodigo.Enabled = false;
            txtCodigo.Location = new Point(425, 46);
            txtCodigo.Margin = new Padding(4, 4, 4, 4);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(150, 27);
            txtCodigo.TabIndex = 10;
            // 
            // bttnSalir
            // 
            bttnSalir.Location = new Point(684, 521);
            bttnSalir.Margin = new Padding(4, 4, 4, 4);
            bttnSalir.Name = "bttnSalir";
            bttnSalir.Size = new Size(117, 43);
            bttnSalir.TabIndex = 12;
            bttnSalir.Text = "Salir";
            bttnSalir.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(311, 48);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(61, 20);
            label5.TabIndex = 9;
            label5.Text = "Codigo:";
            // 
            // bttnCancelar
            // 
            bttnCancelar.Location = new Point(707, 147);
            bttnCancelar.Margin = new Padding(4, 4, 4, 4);
            bttnCancelar.Name = "bttnCancelar";
            bttnCancelar.Size = new Size(110, 42);
            bttnCancelar.TabIndex = 8;
            bttnCancelar.Text = "Cancelar";
            bttnCancelar.UseVisualStyleBackColor = true;
            // 
            // bttnModificar
            // 
            bttnModificar.Location = new Point(707, 94);
            bttnModificar.Margin = new Padding(4, 4, 4, 4);
            bttnModificar.Name = "bttnModificar";
            bttnModificar.Size = new Size(110, 42);
            bttnModificar.TabIndex = 7;
            bttnModificar.Text = "Modificar";
            bttnModificar.UseVisualStyleBackColor = true;
            // 
            // bttnAgregar
            // 
            bttnAgregar.Location = new Point(707, 34);
            bttnAgregar.Margin = new Padding(4, 4, 4, 4);
            bttnAgregar.Name = "bttnAgregar";
            bttnAgregar.Size = new Size(110, 42);
            bttnAgregar.TabIndex = 6;
            bttnAgregar.Text = "Agregar";
            bttnAgregar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 163);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(98, 20);
            label4.TabIndex = 4;
            label4.Text = "Precio Venta: ";
            // 
            // cbProveedor
            // 
            cbProveedor.FormattingEnabled = true;
            cbProveedor.Location = new Point(126, 118);
            cbProveedor.Margin = new Padding(4, 4, 4, 4);
            cbProveedor.Name = "cbProveedor";
            cbProveedor.Size = new Size(163, 28);
            cbProveedor.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 122);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 2;
            label2.Text = "Proveedor:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(126, 41);
            txtNombre.Margin = new Padding(4, 4, 4, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(163, 27);
            txtNombre.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 41);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // gbMaterial
            // 
            gbMaterial.Controls.Add(cbDisponibilidad);
            gbMaterial.Controls.Add(label8);
            gbMaterial.Controls.Add(cbCondicion);
            gbMaterial.Controls.Add(label7);
            gbMaterial.Controls.Add(cbTipoRecurso);
            gbMaterial.Controls.Add(label6);
            gbMaterial.Controls.Add(cbkEstado);
            gbMaterial.Controls.Add(txtCodigo);
            gbMaterial.Controls.Add(label5);
            gbMaterial.Controls.Add(bttnCancelar);
            gbMaterial.Controls.Add(bttnModificar);
            gbMaterial.Controls.Add(bttnAgregar);
            gbMaterial.Controls.Add(txtPrecio);
            gbMaterial.Controls.Add(label4);
            gbMaterial.Controls.Add(cbProveedor);
            gbMaterial.Controls.Add(label2);
            gbMaterial.Controls.Add(txtNombre);
            gbMaterial.Controls.Add(label1);
            gbMaterial.Location = new Point(44, 60);
            gbMaterial.Margin = new Padding(4, 4, 4, 4);
            gbMaterial.Name = "gbMaterial";
            gbMaterial.Padding = new Padding(4, 4, 4, 4);
            gbMaterial.Size = new Size(824, 198);
            gbMaterial.TabIndex = 7;
            gbMaterial.TabStop = false;
            gbMaterial.Text = "Datos Recursos";
            // 
            // cbDisponibilidad
            // 
            cbDisponibilidad.FormattingEnabled = true;
            cbDisponibilidad.Location = new Point(425, 147);
            cbDisponibilidad.Margin = new Padding(2, 2, 2, 2);
            cbDisponibilidad.Name = "cbDisponibilidad";
            cbDisponibilidad.Size = new Size(150, 28);
            cbDisponibilidad.TabIndex = 23;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(311, 152);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(110, 20);
            label8.TabIndex = 22;
            label8.Text = "Disponibilidad:";
            // 
            // cbCondicion
            // 
            cbCondicion.FormattingEnabled = true;
            cbCondicion.Location = new Point(425, 112);
            cbCondicion.Margin = new Padding(2, 2, 2, 2);
            cbCondicion.Name = "cbCondicion";
            cbCondicion.Size = new Size(150, 28);
            cbCondicion.TabIndex = 21;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(311, 119);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(79, 20);
            label7.TabIndex = 20;
            label7.Text = "Condición:";
            // 
            // cbTipoRecurso
            // 
            cbTipoRecurso.FormattingEnabled = true;
            cbTipoRecurso.Location = new Point(126, 82);
            cbTipoRecurso.Margin = new Padding(4, 4, 4, 4);
            cbTipoRecurso.Name = "cbTipoRecurso";
            cbTipoRecurso.Size = new Size(163, 28);
            cbTipoRecurso.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 82);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(119, 20);
            label6.TabIndex = 18;
            label6.Text = "Tipo de Recurso:";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(126, 159);
            txtPrecio.Margin = new Padding(4, 4, 4, 4);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(163, 27);
            txtPrecio.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            label3.Location = new Point(375, 13);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(139, 41);
            label3.TabIndex = 8;
            label3.Text = "Recursos";
            // 
            // btnDisponibilidad
            // 
            btnDisponibilidad.Location = new Point(346, 272);
            btnDisponibilidad.Margin = new Padding(2, 2, 2, 2);
            btnDisponibilidad.Name = "btnDisponibilidad";
            btnDisponibilidad.Size = new Size(132, 41);
            btnDisponibilidad.TabIndex = 16;
            btnDisponibilidad.Text = "Disponibilidad";
            btnDisponibilidad.UseVisualStyleBackColor = true;
            // 
            // btnTipoRecurso
            // 
            btnTipoRecurso.Location = new Point(529, 272);
            btnTipoRecurso.Margin = new Padding(2, 2, 2, 2);
            btnTipoRecurso.Name = "btnTipoRecurso";
            btnTipoRecurso.Size = new Size(132, 41);
            btnTipoRecurso.TabIndex = 17;
            btnTipoRecurso.Text = "Tipo de Recurso";
            btnTipoRecurso.UseVisualStyleBackColor = true;
            // 
            // btnCondición
            // 
            btnCondición.Location = new Point(177, 272);
            btnCondición.Margin = new Padding(2, 2, 2, 2);
            btnCondición.Name = "btnCondición";
            btnCondición.Size = new Size(132, 41);
            btnCondición.TabIndex = 24;
            btnCondición.Text = "Condición";
            btnCondición.UseVisualStyleBackColor = true;
            // 
            // RecursosFormServicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(914, 631);
            Controls.Add(btnCondición);
            Controls.Add(bttnDeshabilitar);
            Controls.Add(btnEditar);
            Controls.Add(btnNuevo);
            Controls.Add(dgvRecursos);
            Controls.Add(bttnSalir);
            Controls.Add(gbMaterial);
            Controls.Add(label3);
            Controls.Add(btnTipoRecurso);
            Controls.Add(btnDisponibilidad);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 4, 4, 4);
            Name = "RecursosFormServicio";
            Text = "MaterialFormServicio";
            ((System.ComponentModel.ISupportInitialize)dgvRecursos).EndInit();
            gbMaterial.ResumeLayout(false);
            gbMaterial.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bttnDeshabilitar;
        private Button btnEditar;
        private Button btnNuevo;
        private DataGridView dgvRecursos;
        private CheckBox cbkEstado;
        private TextBox txtCodigo;
        private Button bttnSalir;
        private Label label5;
        private Button bttnCancelar;
        private Button bttnModificar;
        private Button bttnAgregar;
        private Label label4;
        private ComboBox cbProveedor;
        private Label label2;
        private TextBox txtNombre;
        private Label label1;
        private GroupBox gbMaterial;
        private TextBox txtPrecio;
        private Label label3;
        private Button btnTipoRecurso;
        private Button btnDisponibilidad;
        private ComboBox cbTipoRecurso;
        private Label label6;
        private Label label7;
        private Button btnCondición;
        private ComboBox cbDisponibilidad;
        private Label label8;
        private ComboBox cbCondicion;
    }
}