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
            checkBox1 = new CheckBox();
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
            label1.Location = new Point(479, 518);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(139, 32);
            label1.TabIndex = 0;
            label1.Text = "Maquinaria:";
            // 
            // dgvpedido
            // 
            dgvpedido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvpedido.Location = new Point(41, 26);
            dgvpedido.Margin = new Padding(6, 6, 6, 6);
            dgvpedido.Name = "dgvpedido";
            dgvpedido.RowHeadersWidth = 82;
            dgvpedido.Size = new Size(836, 399);
            dgvpedido.TabIndex = 1;
            // 
            // txtRegistrar
            // 
            button1.Location = new Point(1044, 591);
            button1.Margin = new Padding(6, 6, 6, 6);
            button1.Name = "button1";
            button1.Size = new Size(193, 79);
            button1.TabIndex = 2;
            button1.Text = "REGISTRAR";
            button1.UseVisualStyleBackColor = true;
            // 
            // txtDeshabilitar
            // 
            button2.Location = new Point(1294, 591);
            button2.Margin = new Padding(6, 6, 6, 6);
            button2.Name = "button2";
            button2.Size = new Size(193, 79);
            button2.TabIndex = 3;
            button2.Text = "DESHABILITAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // cbMaquinaria
            // 
            cbMaquinaria.FormattingEnabled = true;
            cbMaquinaria.Location = new Point(652, 512);
            cbMaquinaria.Margin = new Padding(6, 6, 6, 6);
            cbMaquinaria.Name = "cbMaquinaria";
            cbMaquinaria.Size = new Size(221, 40);
            cbMaquinaria.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 614);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(76, 32);
            label3.TabIndex = 7;
            label3.Text = "Fecha";
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(175, 606);
            dtpFecha.Margin = new Padding(6, 6, 6, 6);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(385, 39);
            dtpFecha.TabIndex = 8;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(650, 610);
            checkBox1.Margin = new Padding(6, 6, 6, 6);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(116, 36);
            checkBox1.TabIndex = 11;
            checkBox1.Text = "Estado";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(46, 518);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(114, 32);
            label5.TabIndex = 12;
            label5.Text = "Pedido Id";
            // 
            // txtPedido
            // 
            txtPedido.Location = new Point(214, 512);
            txtPedido.Margin = new Padding(6, 6, 6, 6);
            txtPedido.Name = "txtPedido";
            txtPedido.Size = new Size(221, 39);
            txtPedido.TabIndex = 13;
            // 
            // listaDetalle
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listView1.Location = new Point(956, 26);
            listView1.Margin = new Padding(6, 6, 6, 6);
            listView1.Name = "listView1";
            listView1.Size = new Size(407, 394);
            listView1.TabIndex = 15;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
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
            button3.Location = new Point(429, 277);
            button3.Name = "button3";
            button3.Size = new Size(101, 37);
            button3.TabIndex = 16;
            button3.Text = "AÑADIR";
            button3.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(975, 512);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(179, 32);
            label6.TabIndex = 17;
            label6.Text = "Mantenimiento";
            // 
            // cbMantenimiento
            // 
            cbMantenimiento.FormattingEnabled = true;
            cbMantenimiento.Location = new Point(1176, 501);
            cbMantenimiento.Margin = new Padding(6, 6, 6, 6);
            cbMantenimiento.Name = "cbMantenimiento";
            cbMantenimiento.Size = new Size(221, 40);
            cbMantenimiento.TabIndex = 18;
            // 
            // PedidoMantenimientoCorrectivo
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1510, 832);
            Controls.Add(cbMantenimiento);
            Controls.Add(label6);
            Controls.Add(button3);
            Controls.Add(listaDetalle);
            Controls.Add(txtPedido);
            Controls.Add(label5);
            Controls.Add(checkBox1);
            Controls.Add(dtpFecha);
            Controls.Add(label3);
            Controls.Add(cbMaquinaria);
            Controls.Add(txtDeshabilitar);
            Controls.Add(txtRegistrar);
            Controls.Add(dgvpedido);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6, 6, 6, 6);
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
        private CheckBox checkBox1;
        private Label label5;
        private TextBox txtPedido;
        private ListView listaDetalle;
        private Button button3;
        private Label label6;
        private ComboBox cbMantenimiento;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
    }
}