namespace CapaPresentacion
{
    partial class RealizarPago
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
            dgvPago = new DataGridView();
            groupBox1 = new GroupBox();
            button1 = new Button();
            txtBuscarDni = new TextBox();
            txtIdServicio = new TextBox();
            label4 = new Label();
            txtIdVenta = new TextBox();
            bttnAgrupar = new Button();
            label12 = new Label();
            btnBuscar = new Button();
            cbFormaPago = new ComboBox();
            cbCliente = new ComboBox();
            txtCorreo = new TextBox();
            txtDni = new TextBox();
            bttnAnular = new Button();
            label16 = new Label();
            label15 = new Label();
            label13 = new Label();
            txtTotal = new TextBox();
            dtPago = new DateTimePicker();
            label8 = new Label();
            label7 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPago).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(381, 20);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(202, 41);
            label1.TabIndex = 16;
            label1.Text = "Realizar Pago";
            // 
            // dgvPago
            // 
            dgvPago.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPago.Location = new Point(37, 369);
            dgvPago.Margin = new Padding(2, 1, 2, 1);
            dgvPago.Name = "dgvPago";
            dgvPago.RowHeadersWidth = 82;
            dgvPago.Size = new Size(907, 281);
            dgvPago.TabIndex = 18;
            dgvPago.CellClick += dgvPago_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(txtBuscarDni);
            groupBox1.Controls.Add(txtIdServicio);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtIdVenta);
            groupBox1.Controls.Add(bttnAgrupar);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(btnBuscar);
            groupBox1.Controls.Add(cbFormaPago);
            groupBox1.Controls.Add(cbCliente);
            groupBox1.Controls.Add(txtCorreo);
            groupBox1.Controls.Add(txtDni);
            groupBox1.Controls.Add(bttnAnular);
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(txtTotal);
            groupBox1.Controls.Add(dtPago);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(37, 74);
            groupBox1.Margin = new Padding(2, 1, 2, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 1, 2, 1);
            groupBox1.Size = new Size(907, 283);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos";
            // 
            // button1
            // 
            button1.Location = new Point(270, 211);
            button1.Margin = new Padding(2, 1, 2, 1);
            button1.Name = "button1";
            button1.Size = new Size(105, 56);
            button1.TabIndex = 47;
            button1.Text = "Ver todos los pagos";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtBuscarDni
            // 
            txtBuscarDni.Location = new Point(608, 221);
            txtBuscarDni.Margin = new Padding(2, 1, 2, 1);
            txtBuscarDni.Name = "txtBuscarDni";
            txtBuscarDni.Size = new Size(138, 27);
            txtBuscarDni.TabIndex = 46;
            // 
            // txtIdServicio
            // 
            txtIdServicio.Location = new Point(142, 44);
            txtIdServicio.Margin = new Padding(2, 1, 2, 1);
            txtIdServicio.Name = "txtIdServicio";
            txtIdServicio.Size = new Size(93, 27);
            txtIdServicio.TabIndex = 45;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 47);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(115, 20);
            label4.TabIndex = 44;
            label4.Text = "id Pago Servicio";
            // 
            // txtIdVenta
            // 
            txtIdVenta.Location = new Point(97, 133);
            txtIdVenta.Margin = new Padding(2, 1, 2, 1);
            txtIdVenta.Name = "txtIdVenta";
            txtIdVenta.Size = new Size(138, 27);
            txtIdVenta.TabIndex = 43;
            // 
            // bttnAgrupar
            // 
            bttnAgrupar.Location = new Point(33, 213);
            bttnAgrupar.Margin = new Padding(3, 4, 3, 4);
            bttnAgrupar.Name = "bttnAgrupar";
            bttnAgrupar.Size = new Size(96, 41);
            bttnAgrupar.TabIndex = 42;
            bttnAgrupar.Text = "Agregar";
            bttnAgrupar.UseVisualStyleBackColor = true;
            bttnAgrupar.Click += bttnAgrupar_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(442, 228);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(150, 20);
            label12.TabIndex = 30;
            label12.Text = "Buscar Pagos por dni:";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(760, 213);
            btnBuscar.Margin = new Padding(2, 1, 2, 1);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(105, 43);
            btnBuscar.TabIndex = 41;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // cbFormaPago
            // 
            cbFormaPago.FormattingEnabled = true;
            cbFormaPago.Location = new Point(630, 107);
            cbFormaPago.Margin = new Padding(3, 4, 3, 4);
            cbFormaPago.Name = "cbFormaPago";
            cbFormaPago.Size = new Size(138, 28);
            cbFormaPago.TabIndex = 40;
            // 
            // cbCliente
            // 
            cbCliente.FormattingEnabled = true;
            cbCliente.Location = new Point(97, 87);
            cbCliente.Margin = new Padding(3, 4, 3, 4);
            cbCliente.Name = "cbCliente";
            cbCliente.Size = new Size(138, 28);
            cbCliente.TabIndex = 39;
            cbCliente.SelectedIndexChanged += cbCliente_SelectedIndexChanged;
            // 
            // txtCorreo
            // 
            txtCorreo.Enabled = false;
            txtCorreo.Location = new Point(325, 44);
            txtCorreo.Margin = new Padding(3, 4, 3, 4);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(443, 27);
            txtCorreo.TabIndex = 38;
            // 
            // txtDni
            // 
            txtDni.Enabled = false;
            txtDni.Location = new Point(344, 104);
            txtDni.Margin = new Padding(3, 4, 3, 4);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(121, 27);
            txtDni.TabIndex = 37;
            // 
            // bttnAnular
            // 
            bttnAnular.Location = new Point(151, 213);
            bttnAnular.Margin = new Padding(2, 1, 2, 1);
            bttnAnular.Name = "bttnAnular";
            bttnAnular.Size = new Size(105, 43);
            bttnAnular.TabIndex = 27;
            bttnAnular.Text = "Anular";
            bttnAnular.UseVisualStyleBackColor = true;
            bttnAnular.Click += bttnAnular_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(270, 51);
            label16.Margin = new Padding(2, 0, 2, 0);
            label16.Name = "label16";
            label16.Size = new Size(54, 20);
            label16.TabIndex = 35;
            label16.Text = "Correo";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(277, 108);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(35, 20);
            label15.TabIndex = 33;
            label15.Text = "Dni:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(23, 136);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(46, 20);
            label13.TabIndex = 29;
            label13.Text = "Venta";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(97, 172);
            txtTotal.Margin = new Padding(2, 1, 2, 1);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(138, 27);
            txtTotal.TabIndex = 13;
            // 
            // dtPago
            // 
            dtPago.Location = new Point(389, 156);
            dtPago.Margin = new Padding(2, 1, 2, 1);
            dtPago.Name = "dtPago";
            dtPago.Size = new Size(247, 27);
            dtPago.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(277, 161);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(110, 20);
            label8.TabIndex = 7;
            label8.Text = "Fecha de pago:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(267, 87);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(521, 111);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(114, 20);
            label5.TabIndex = 3;
            label5.Text = "Forma de pago:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 172);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 1;
            label3.Text = "Total:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 91);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 0;
            label2.Text = "Cliente";
            // 
            // RealizarPago
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1074, 676);
            Controls.Add(dgvPago);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 1, 2, 1);
            Name = "RealizarPago";
            Text = "RealizarPago";
            ((System.ComponentModel.ISupportInitialize)dgvPago).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvPago;
        private GroupBox groupBox1;
        private CheckBox cbParcial;
        private ComboBox comboBox1;
        private TextBox txtTotal;
        private Button button1;
        private DateTimePicker dtPago;
        private Label label8;
        private CheckBox cbTotal;
        private Label label7;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label6;
        private Label label9;
        private Label label10;
        private TextBox textBox3;
        private Label label11;
        private Label label12;
        private DateTimePicker dateTimePicker2;
        private Button bttnAnular;
        private ComboBox comboBox2;
        private TextBox textBox6;
        private Label label16;
        private TextBox textBox4;
        private Label label15;
        private TextBox textBox1;
        private Label label13;
        private ComboBox cbFormaPago;
        private ComboBox cbCliente;
        private TextBox txtCorreo;
        private TextBox txtDni;
        private Button btnBuscar;
        private Button bttnAgrupar;
        private TextBox txtIdVenta;
        private TextBox txtIdServicio;
        private Label label4;
        private TextBox txtBuscarDni;
    }
}