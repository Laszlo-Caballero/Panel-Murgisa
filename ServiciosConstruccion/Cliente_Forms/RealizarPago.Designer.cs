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
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            label6 = new Label();
            cbParcial = new CheckBox();
            this.cbForma = new ComboBox();
            txtTotal = new TextBox();
            button1 = new Button();
            dateTimePicker1 = new DateTimePicker();
            label8 = new Label();
            cbTotal = new CheckBox();
            label7 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label12 = new Label();
            textBox5 = new TextBox();
            button3 = new Button();
            this.cbCliente = new ComboBox();
            cbVenta = new ComboBox();
            label13 = new Label();
            this.txtNombre = new TextBox();
            label14 = new Label();
            this.txtDni7 = new TextBox();
            label15 = new Label();
            this.txtCorreo = new TextBox();
            label16 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(103, 282);
            dataGridView1.Margin = new Padding(2, 1, 2, 1);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(635, 187);
            dataGridView1.TabIndex = 18;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(this.txtCorreo);
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(this.txtDni7);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(this.txtNombre);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(cbVenta);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(this.cbCliente);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(cbParcial);
            groupBox1.Controls.Add(this.cbForma);
            groupBox1.Controls.Add(txtTotal);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(cbTotal);
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(244, 125);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(79, 15);
            label6.TabIndex = 25;
            label6.Text = "Tipo de Pago:";
            // 
            // cbParcial
            // 
            cbParcial.AutoSize = true;
            cbParcial.Location = new Point(411, 124);
            cbParcial.Margin = new Padding(2, 1, 2, 1);
            cbParcial.Name = "cbParcial";
            cbParcial.Size = new Size(91, 19);
            cbParcial.TabIndex = 24;
            cbParcial.Text = "Pago parcial";
            cbParcial.UseVisualStyleBackColor = true;
            // 
            // cbForma
            // 
            this.cbForma.FormattingEnabled = true;
            this.cbForma.Location = new Point(550, 65);
            this.cbForma.Margin = new Padding(2, 1, 2, 1);
            this.cbForma.Name = "cbForma";
            this.cbForma.Size = new Size(132, 23);
            this.cbForma.TabIndex = 23;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(85, 120);
            txtTotal.Margin = new Padding(2, 1, 2, 1);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(121, 23);
            txtTotal.TabIndex = 13;
            // 
            // button1
            // 
            button1.Location = new Point(387, 161);
            button1.Margin = new Padding(2, 1, 2, 1);
            button1.Name = "button1";
            button1.Size = new Size(92, 32);
            button1.TabIndex = 9;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(122, 166);
            dateTimePicker1.Margin = new Padding(2, 1, 2, 1);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(217, 23);
            dateTimePicker1.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(24, 170);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(87, 15);
            label8.TabIndex = 7;
            label8.Text = "Fecha de pago:";
            // 
            // cbTotal
            // 
            cbTotal.AutoSize = true;
            cbTotal.Location = new Point(327, 124);
            cbTotal.Margin = new Padding(2, 1, 2, 1);
            cbTotal.Name = "cbTotal";
            cbTotal.Size = new Size(80, 19);
            cbTotal.TabIndex = 6;
            cbTotal.Text = "Pago total";
            cbTotal.UseVisualStyleBackColor = true;
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
            label5.Location = new Point(456, 71);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(90, 15);
            label5.TabIndex = 3;
            label5.Text = "Forma de pago:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 120);
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
            label12.Location = new Point(105, 487);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(49, 15);
            label12.TabIndex = 30;
            label12.Text = "Criterio:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(161, 484);
            textBox5.Margin = new Padding(2, 1, 2, 1);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(176, 23);
            textBox5.TabIndex = 31;
            // 
            // button3
            // 
            button3.Location = new Point(500, 161);
            button3.Margin = new Padding(2, 1, 2, 1);
            button3.Name = "button3";
            button3.Size = new Size(92, 32);
            button3.TabIndex = 27;
            button3.Text = "Anular";
            button3.UseVisualStyleBackColor = true;
            // 
            // cbCliente
            // 
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new Point(85, 33);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new Size(121, 23);
            this.cbCliente.TabIndex = 27;
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
            // txtNombre
            // 
            this.txtNombre.Location = new Point(300, 30);
            this.txtNombre.Margin = new Padding(2, 1, 2, 1);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new Size(123, 23);
            this.txtNombre.TabIndex = 32;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(242, 33);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(54, 15);
            label14.TabIndex = 31;
            label14.Text = "Nombre:";
            // 
            // txtDni7
            // 
            this.txtDni7.Location = new Point(300, 68);
            this.txtDni7.Margin = new Padding(2, 1, 2, 1);
            this.txtDni7.Name = "txtDni7";
            this.txtDni7.Size = new Size(123, 23);
            this.txtDni7.TabIndex = 34;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(242, 71);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(28, 15);
            label15.TabIndex = 33;
            label15.Text = "Dni:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new Point(514, 30);
            this.txtCorreo.Margin = new Padding(2, 1, 2, 1);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new Size(230, 23);
            this.txtCorreo.TabIndex = 36;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(456, 33);
            label16.Margin = new Padding(2, 0, 2, 0);
            label16.Name = "label16";
            label16.Size = new Size(43, 15);
            label16.TabIndex = 35;
            label16.Text = "Correo";
            // 
            // button2
            // 
            button2.Location = new Point(360, 478);
            button2.Margin = new Padding(2, 1, 2, 1);
            button2.Name = "button2";
            button2.Size = new Size(92, 32);
            button2.TabIndex = 37;
            button2.Text = "Buscar";
            button2.UseVisualStyleBackColor = true;
            // 
            // RealizarPago
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(940, 549);
            Controls.Add(button2);
            Controls.Add(textBox5);
            Controls.Add(label12);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 1, 2, 1);
            Name = "RealizarPago";
            Text = "RealizarPago";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
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
        private Button button3;
        private ComboBox comboBox2;
        private TextBox textBox6;
        private Label label16;
        private TextBox textBox4;
        private Label label15;
        private TextBox textBox1;
        private Label label14;
        private ComboBox cbVenta;
        private Label label13;
        private Button button2;
    }
}