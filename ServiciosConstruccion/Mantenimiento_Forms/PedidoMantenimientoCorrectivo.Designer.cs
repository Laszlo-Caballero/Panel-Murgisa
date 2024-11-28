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
            button1 = new Button();
            button2 = new Button();
            cbMaquinaria = new ComboBox();
            label2 = new Label();
            txtProveedor = new TextBox();
            label3 = new Label();
            dtpFecha = new DateTimePicker();
            label4 = new Label();
            checkBox1 = new CheckBox();
            label5 = new Label();
            txtPedido = new TextBox();
            comboBox1 = new ComboBox();
            listView1 = new ListView();
            button3 = new Button();
            label6 = new Label();
            cbMantenimiento = new ComboBox();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)dgvpedido).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(258, 243);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 0;
            label1.Text = "Maquinaria:";
            // 
            // dgvpedido
            // 
            dgvpedido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvpedido.Location = new Point(22, 12);
            dgvpedido.Name = "dgvpedido";
            dgvpedido.Size = new Size(450, 187);
            dgvpedido.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(562, 326);
            button1.Name = "button1";
            button1.Size = new Size(104, 37);
            button1.TabIndex = 2;
            button1.Text = "REGISTRAR";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(697, 326);
            button2.Name = "button2";
            button2.Size = new Size(104, 37);
            button2.TabIndex = 3;
            button2.Text = "DESHABILITAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // cbMaquinaria
            // 
            cbMaquinaria.FormattingEnabled = true;
            cbMaquinaria.Location = new Point(351, 240);
            cbMaquinaria.Name = "cbMaquinaria";
            cbMaquinaria.Size = new Size(121, 23);
            cbMaquinaria.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 286);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 5;
            label2.Text = "Proveedor: ";
            // 
            // txtProveedor
            // 
            txtProveedor.Location = new Point(115, 283);
            txtProveedor.Name = "txtProveedor";
            txtProveedor.Size = new Size(121, 23);
            txtProveedor.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(530, 288);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 7;
            label3.Text = "Fecha";
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(592, 284);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(209, 23);
            dtpFecha.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(264, 290);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 9;
            label4.Text = "Prioridad";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(31, 326);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(61, 19);
            checkBox1.TabIndex = 11;
            checkBox1.Text = "Estado";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 243);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 12;
            label5.Text = "Pedido Id";
            // 
            // txtPedido
            // 
            txtPedido.Location = new Point(115, 240);
            txtPedido.Name = "txtPedido";
            txtPedido.Size = new Size(121, 23);
            txtPedido.TabIndex = 13;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(351, 286);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 14;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listView1.Location = new Point(515, 12);
            listView1.Name = "listView1";
            listView1.Size = new Size(221, 187);
            listView1.TabIndex = 15;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // button3
            // 
            button3.Location = new Point(429, 326);
            button3.Name = "button3";
            button3.Size = new Size(101, 37);
            button3.TabIndex = 16;
            button3.Text = "AÑADIR";
            button3.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(525, 240);
            label6.Name = "label6";
            label6.Size = new Size(89, 15);
            label6.TabIndex = 17;
            label6.Text = "Mantenimiento";
            // 
            // cbMantenimiento
            // 
            cbMantenimiento.FormattingEnabled = true;
            cbMantenimiento.Location = new Point(633, 235);
            cbMantenimiento.Name = "cbMantenimiento";
            cbMantenimiento.Size = new Size(121, 23);
            cbMantenimiento.TabIndex = 18;
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
            // PedidoMantenimientoCorrectivo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(813, 390);
            Controls.Add(cbMantenimiento);
            Controls.Add(label6);
            Controls.Add(button3);
            Controls.Add(listView1);
            Controls.Add(comboBox1);
            Controls.Add(txtPedido);
            Controls.Add(label5);
            Controls.Add(checkBox1);
            Controls.Add(label4);
            Controls.Add(dtpFecha);
            Controls.Add(label3);
            Controls.Add(txtProveedor);
            Controls.Add(label2);
            Controls.Add(cbMaquinaria);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dgvpedido);
            Controls.Add(label1);
            Name = "PedidoMantenimientoCorrectivo";
            Text = "PedidoMantenimientoCorrectivo";
            ((System.ComponentModel.ISupportInitialize)dgvpedido).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvpedido;
        private Button button1;
        private Button button2;
        private ComboBox cbMaquinaria;
        private Label label2;
        private TextBox txtProveedor;
        private Label label3;
        private DateTimePicker dtpFecha;
        private Label label4;
        private CheckBox checkBox1;
        private Label label5;
        private TextBox txtPedido;
        private ComboBox comboBox1;
        private ListView listView1;
        private Button button3;
        private Label label6;
        private ComboBox cbMantenimiento;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
    }
}