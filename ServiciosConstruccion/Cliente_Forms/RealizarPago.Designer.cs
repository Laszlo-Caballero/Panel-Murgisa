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
            bttnAgrupar = new Button();
            btnBuscar = new Button();
            cbFormaPago = new ComboBox();
            cbCliente = new ComboBox();
            txtCorreo = new TextBox();
            txtDni = new TextBox();
            bttnAnular = new Button();
            label16 = new Label();
            label15 = new Label();
            cbVenta = new ComboBox();
            label13 = new Label();
            txtTotal = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label8 = new Label();
            label7 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label12 = new Label();
            textBox5 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvPago).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(397, 12);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(160, 32);
            label1.TabIndex = 16;
            label1.Text = "Realizar Pago";
            // 
            // dgvPago
            // 
            dgvPago.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPago.Location = new Point(103, 282);
            dgvPago.Margin = new Padding(2, 1, 2, 1);
            dgvPago.Name = "dgvPago";
            dgvPago.RowHeadersWidth = 82;
            dgvPago.Size = new Size(635, 187);
            dgvPago.TabIndex = 18;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(bttnAgrupar);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(btnBuscar);
            groupBox1.Controls.Add(cbFormaPago);
            groupBox1.Controls.Add(cbCliente);
            groupBox1.Controls.Add(txtCorreo);
            groupBox1.Controls.Add(txtDni);
            groupBox1.Controls.Add(bttnAnular);
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(cbVenta);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(txtTotal);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(103, 58);
            groupBox1.Margin = new Padding(2, 1, 2, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 1, 2, 1);
            groupBox1.Size = new Size(794, 212);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos";
            // 
            // bttnAgrupar
            // 
            bttnAgrupar.Location = new Point(29, 160);
            bttnAgrupar.Name = "bttnAgrupar";
            bttnAgrupar.Size = new Size(84, 31);
            bttnAgrupar.TabIndex = 42;
            bttnAgrupar.Text = "Agregar";
            bttnAgrupar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(665, 160);
            btnBuscar.Margin = new Padding(2, 1, 2, 1);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(92, 32);
            btnBuscar.TabIndex = 41;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // cbFormaPago
            // 
            cbFormaPago.FormattingEnabled = true;
            cbFormaPago.Location = new Point(551, 80);
            cbFormaPago.Name = "cbFormaPago";
            cbFormaPago.Size = new Size(121, 23);
            cbFormaPago.TabIndex = 40;
            // 
            // cbCliente
            // 
            cbCliente.FormattingEnabled = true;
            cbCliente.Location = new Point(85, 33);
            cbCliente.Name = "cbCliente";
            cbCliente.Size = new Size(121, 23);
            cbCliente.TabIndex = 39;
            cbCliente.SelectedIndexChanged += cbCliente_SelectedIndexChanged;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(284, 33);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(388, 23);
            txtCorreo.TabIndex = 38;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(301, 78);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(106, 23);
            txtDni.TabIndex = 37;
            // 
            // bttnAnular
            // 
            bttnAnular.Location = new Point(132, 160);
            bttnAnular.Margin = new Padding(2, 1, 2, 1);
            bttnAnular.Name = "bttnAnular";
            bttnAnular.Size = new Size(92, 32);
            bttnAnular.TabIndex = 27;
            bttnAnular.Text = "Anular";
            bttnAnular.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(236, 38);
            label16.Margin = new Padding(2, 0, 2, 0);
            label16.Name = "label16";
            label16.Size = new Size(43, 15);
            label16.TabIndex = 35;
            label16.Text = "Correo";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(242, 81);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(28, 15);
            label15.TabIndex = 33;
            label15.Text = "Dni:";
            // 
            // cbVenta
            // 
            cbVenta.FormattingEnabled = true;
            cbVenta.Location = new Point(85, 75);
            cbVenta.Name = "cbVenta";
            cbVenta.Size = new Size(121, 23);
            cbVenta.TabIndex = 30;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(20, 78);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(36, 15);
            label13.TabIndex = 29;
            label13.Text = "Venta";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(85, 117);
            txtTotal.Margin = new Padding(2, 1, 2, 1);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(121, 23);
            txtTotal.TabIndex = 13;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(340, 117);
            dateTimePicker1.Margin = new Padding(2, 1, 2, 1);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(217, 23);
            dateTimePicker1.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(242, 121);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(87, 15);
            label8.TabIndex = 7;
            label8.Text = "Fecha de pago:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(234, 65);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(0, 15);
            label7.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(456, 83);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(90, 15);
            label5.TabIndex = 3;
            label5.Text = "Forma de pago:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 117);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 1;
            label3.Text = "Total:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 36);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 0;
            label2.Text = "Cliente";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(403, 163);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(49, 15);
            label12.TabIndex = 30;
            label12.Text = "Criterio:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(459, 160);
            textBox5.Margin = new Padding(2, 1, 2, 1);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(176, 23);
            textBox5.TabIndex = 31;
            // 
            // RealizarPago
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(940, 507);
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
        private DateTimePicker dateTimePicker1;
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
        private TextBox textBox5;
        private DateTimePicker dateTimePicker2;
        private Button bttnAnular;
        private ComboBox comboBox2;
        private TextBox textBox6;
        private Label label16;
        private TextBox textBox4;
        private Label label15;
        private TextBox textBox1;
        private ComboBox cbVenta;
        private Label label13;
        private ComboBox cbFormaPago;
        private ComboBox cbCliente;
        private TextBox txtCorreo;
        private TextBox txtDni;
        private Button btnBuscar;
        private Button bttnAgrupar;
    }
}