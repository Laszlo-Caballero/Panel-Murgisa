namespace CapaPresentacion.Almacen_Forms
{
    partial class NotaIngresoForm
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
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox6 = new TextBox();
            label8 = new Label();
            label7 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            dtvNotaIngreso = new DataGridView();
            button3 = new Button();
            button1 = new Button();
            button6 = new Button();
            button4 = new Button();
            button7 = new Button();
            textBox7 = new TextBox();
            groupBox3 = new GroupBox();
            label3 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            groupBox4 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtvNotaIngreso).BeginInit();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 95);
            label2.Name = "label2";
            label2.Size = new Size(102, 15);
            label2.TabIndex = 1;
            label2.Text = "Fecha de Emision:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 244);
            label4.Name = "label4";
            label4.Size = new Size(130, 15);
            label4.TabIndex = 3;
            label4.Text = "Nombre del Proveedor:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(44, 283);
            label5.Name = "label5";
            label5.Size = new Size(103, 15);
            label5.TabIndex = 4;
            label5.Text = "Cantidad recibida:";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(202, 275);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(54, 23);
            textBox6.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(325, 11);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(190, 32);
            label8.TabIndex = 13;
            label8.Text = "Nota de Ingreso";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(44, 204);
            label7.Name = "label7";
            label7.Size = new Size(125, 15);
            label7.TabIndex = 14;
            label7.Text = "Nombre del Producto:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(26, 165);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(357, 172);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Descripcion del Producto";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dateTimePicker1);
            groupBox2.Location = new Point(26, 65);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(357, 69);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            // 
            // dtvNotaIngreso
            // 
            dtvNotaIngreso.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtvNotaIngreso.Location = new Point(388, 65);
            dtvNotaIngreso.Margin = new Padding(2, 1, 2, 1);
            dtvNotaIngreso.Name = "dtvNotaIngreso";
            dtvNotaIngreso.RowHeadersWidth = 82;
            dtvNotaIngreso.Size = new Size(313, 321);
            dtvNotaIngreso.TabIndex = 18;
            // 
            // button3
            // 
            button3.Location = new Point(93, 390);
            button3.Margin = new Padding(2, 1, 2, 1);
            button3.Name = "button3";
            button3.Size = new Size(81, 32);
            button3.TabIndex = 21;
            button3.Text = "Cancelar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(256, 118);
            button1.Margin = new Padding(2, 1, 2, 1);
            button1.Name = "button1";
            button1.Size = new Size(81, 32);
            button1.TabIndex = 19;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(232, 390);
            button6.Margin = new Padding(2, 1, 2, 1);
            button6.Name = "button6";
            button6.Size = new Size(81, 32);
            button6.TabIndex = 22;
            button6.Text = "Deshabilitar";
            button6.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(456, 390);
            button4.Margin = new Padding(2, 1, 2, 1);
            button4.Name = "button4";
            button4.Size = new Size(185, 32);
            button4.TabIndex = 23;
            button4.Text = "Registrar nuevo cliente";
            button4.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(57, 130);
            button7.Margin = new Padding(2, 1, 2, 1);
            button7.Name = "button7";
            button7.Size = new Size(55, 22);
            button7.TabIndex = 16;
            button7.Text = "Buscar";
            button7.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(45, 90);
            textBox7.Margin = new Padding(2, 1, 2, 1);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(84, 23);
            textBox7.TabIndex = 20;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(button7);
            groupBox3.Controls.Add(textBox7);
            groupBox3.Location = new Point(708, 65);
            groupBox3.Margin = new Padding(2, 1, 2, 1);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(2, 1, 2, 1);
            groupBox3.Size = new Size(177, 189);
            groupBox3.TabIndex = 24;
            groupBox3.TabStop = false;
            groupBox3.Text = "Buscar Nota Ingreso";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 53);
            label3.Name = "label3";
            label3.Size = new Size(120, 15);
            label3.TabIndex = 21;
            label3.Text = "Nro. Nota de Ingreso:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(176, 71);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(148, 23);
            comboBox1.TabIndex = 20;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(176, 31);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(148, 23);
            comboBox2.TabIndex = 21;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(176, 22);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(148, 23);
            dateTimePicker1.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label8);
            groupBox4.Location = new Point(12, 3);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(872, 46);
            groupBox4.TabIndex = 26;
            groupBox4.TabStop = false;
            // 
            // NotaIngresoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 432);
            Controls.Add(groupBox3);
            Controls.Add(button4);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(dtvNotaIngreso);
            Controls.Add(label7);
            Controls.Add(textBox6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NotaIngresoForm";
            Text = "NotaIngresoForm";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtvNotaIngreso).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label4;
        private Label label5;
        private TextBox textBox6;
        private Label label8;
        private Label label7;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dtvNotaIngreso;
        private Button button1;
        private Button button3;
        private Button button6;
        private Button button4;
        private Button button7;
        private TextBox textBox7;
        private GroupBox groupBox3;
        private Label label3;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private GroupBox groupBox4;
    }
}