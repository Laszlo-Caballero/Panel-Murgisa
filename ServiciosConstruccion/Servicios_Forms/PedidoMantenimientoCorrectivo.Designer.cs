namespace CapaPresentacion.Mantenimiento_Forms
{
    partial class PedidoMantenimientoCorrectivo
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
            dgvpedido = new DataGridView();
            txtRegistrar = new Button();
            txtDeshabilitar = new Button();
            cbMaquinaria = new ComboBox();
            label3 = new Label();
            dtpFecha = new DateTimePicker();
            cbEstado = new CheckBox();
            label5 = new Label();
            txtPedido = new TextBox();
            listaDetalle = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            btnAñadir = new Button();
            label6 = new Label();
            cbMantenimiento = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvpedido).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(295, 324);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 0;
            label1.Text = "Maquinaria:";
            // 
            // dgvpedido
            // 
            dgvpedido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvpedido.Location = new Point(37, 16);
            dgvpedido.Margin = new Padding(3, 4, 3, 4);
            dgvpedido.Name = "dgvpedido";
            dgvpedido.RowHeadersWidth = 82;
            dgvpedido.Size = new Size(514, 249);
            dgvpedido.TabIndex = 1;
            dgvpedido.CellDoubleClick += dgvpedido_CellDoubleClick;
            // 
            // txtRegistrar
            // 
            txtRegistrar.Location = new Point(633, 370);
            txtRegistrar.Margin = new Padding(3, 4, 3, 4);
            txtRegistrar.Name = "txtRegistrar";
            txtRegistrar.Size = new Size(119, 49);
            txtRegistrar.TabIndex = 2;
            txtRegistrar.Text = "REGISTRAR";
            txtRegistrar.UseVisualStyleBackColor = true;
            txtRegistrar.Click += txtRegistrar_Click;
            // 
            // txtDeshabilitar
            // 
            txtDeshabilitar.Location = new Point(758, 369);
            txtDeshabilitar.Margin = new Padding(3, 4, 3, 4);
            txtDeshabilitar.Name = "txtDeshabilitar";
            txtDeshabilitar.Size = new Size(119, 49);
            txtDeshabilitar.TabIndex = 3;
            txtDeshabilitar.Text = "DESHABILITAR";
            txtDeshabilitar.UseVisualStyleBackColor = true;
            txtDeshabilitar.Click += txtDeshabilitar_Click;
            // 
            // cbMaquinaria
            // 
            cbMaquinaria.FormattingEnabled = true;
            cbMaquinaria.Location = new Point(401, 320);
            cbMaquinaria.Margin = new Padding(3, 4, 3, 4);
            cbMaquinaria.Name = "cbMaquinaria";
            cbMaquinaria.Size = new Size(138, 28);
            cbMaquinaria.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 384);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 7;
            label3.Text = "Fecha";
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(107, 379);
            dtpFecha.Margin = new Padding(3, 4, 3, 4);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(238, 27);
            dtpFecha.TabIndex = 8;
            // 
            // cbEstado
            // 
            cbEstado.AutoSize = true;
            cbEstado.Location = new Point(401, 383);
            cbEstado.Margin = new Padding(3, 4, 3, 4);
            cbEstado.Name = "cbEstado";
            cbEstado.Size = new Size(76, 24);
            cbEstado.TabIndex = 11;
            cbEstado.Text = "Estado";
            cbEstado.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 324);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 12;
            label5.Text = "Pedido Id";
            // 
            // txtPedido
            // 
            txtPedido.Location = new Point(131, 320);
            txtPedido.Margin = new Padding(3, 4, 3, 4);
            txtPedido.Name = "txtPedido";
            txtPedido.Size = new Size(138, 27);
            txtPedido.TabIndex = 13;
            // 
            // listaDetalle
            // 
            listaDetalle.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listaDetalle.Location = new Point(589, 16);
            listaDetalle.Margin = new Padding(3, 4, 3, 4);
            listaDetalle.Name = "listaDetalle";
            listaDetalle.Size = new Size(252, 248);
            listaDetalle.TabIndex = 15;
            listaDetalle.UseCompatibleStateImageBehavior = false;
            listaDetalle.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Mantenimiento";
            columnHeader2.Width = 150;
            // 
            // btnAñadir
            // 
            btnAñadir.Location = new Point(524, 370);
            btnAñadir.Margin = new Padding(2, 1, 2, 1);
            btnAñadir.Name = "btnAñadir";
            btnAñadir.Size = new Size(101, 49);
            btnAñadir.TabIndex = 16;
            btnAñadir.Text = "AÑADIR";
            btnAñadir.UseVisualStyleBackColor = true;
            btnAñadir.Click += btnAñadir_Click_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(600, 320);
            label6.Name = "label6";
            label6.Size = new Size(110, 20);
            label6.TabIndex = 17;
            label6.Text = "Mantenimiento";
            // 
            // cbMantenimiento
            // 
            cbMantenimiento.FormattingEnabled = true;
            cbMantenimiento.Location = new Point(723, 313);
            cbMantenimiento.Margin = new Padding(3, 4, 3, 4);
            cbMantenimiento.Name = "cbMantenimiento";
            cbMantenimiento.Size = new Size(138, 28);
            cbMantenimiento.TabIndex = 18;
            // 
            // PedidoMantenimientoCorrectivo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(929, 520);
            Controls.Add(cbMantenimiento);
            Controls.Add(label6);
            Controls.Add(btnAñadir);
            Controls.Add(listaDetalle);
            Controls.Add(txtPedido);
            Controls.Add(label5);
            Controls.Add(cbEstado);
            Controls.Add(dtpFecha);
            Controls.Add(label3);
            Controls.Add(cbMaquinaria);
            Controls.Add(txtDeshabilitar);
            Controls.Add(txtRegistrar);
            Controls.Add(dgvpedido);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "PedidoMantenimientoCorrectivo";
            Text = "PedidoMantenimientoCorrectivo";
            ((System.ComponentModel.ISupportInitialize)dgvpedido).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvpedido;
        private Button txtRegistrar;
        private Button txtDeshabilitar;
        private ComboBox cbMaquinaria;
        private Label label3;
        private DateTimePicker dtpFecha;
        private CheckBox cbEstado;
        private Label label5;
        private TextBox txtPedido;
        private ListView listaDetalle;
        private Button btnAñadir;
        private Label label6;
        private ComboBox cbMantenimiento;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
    }
}