namespace CapaPresentacion
{
    partial class Venta
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
            label2 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            cbTipoServicio = new ComboBox();
            button2 = new Button();
            textBox2 = new TextBox();
            label8 = new Label();
            label9 = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel = new Panel();
            groupBox1 = new GroupBox();
            button3 = new Button();
            textBox3 = new TextBox();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(426, 21);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(138, 28);
            label1.TabIndex = 0;
            label1.Text = "Realizar Venta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 83);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 1;
            label2.Text = "Venta:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(190, 83);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(181, 27);
            textBox1.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(62, 128);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(119, 20);
            label4.TabIndex = 5;
            label4.Text = "Tipo de Servicio:";
            // 
            // cbTipoServicio
            // 
            cbTipoServicio.FormattingEnabled = true;
            cbTipoServicio.Location = new Point(190, 123);
            cbTipoServicio.Margin = new Padding(2);
            cbTipoServicio.Name = "cbTipoServicio";
            cbTipoServicio.Size = new Size(181, 28);
            cbTipoServicio.TabIndex = 6;
            cbTipoServicio.SelectedIndexChanged += cbTipoServicio_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.Location = new Point(860, 752);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(160, 52);
            button2.TabIndex = 10;
            button2.Text = "Confirmar venta";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(126, 752);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(120, 27);
            textBox2.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(69, 754);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(45, 20);
            label8.TabIndex = 15;
            label8.Text = "Total:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(425, 125);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(58, 20);
            label9.TabIndex = 16;
            label9.Text = "Cliente:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridView1.Location = new Point(62, 189);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(664, 140);
            dataGridView1.TabIndex = 12;
            // 
            // Column1
            // 
            Column1.HeaderText = "Nombre del servicio";
            Column1.MinimumWidth = 10;
            Column1.Name = "Column1";
            Column1.Width = 200;
            // 
            // Column2
            // 
            Column2.HeaderText = "fecha de disponibilidad";
            Column2.MinimumWidth = 10;
            Column2.Name = "Column2";
            Column2.Width = 200;
            // 
            // Column3
            // 
            Column3.HeaderText = "Precio";
            Column3.MinimumWidth = 10;
            Column3.Name = "Column3";
            Column3.Width = 200;
            // 
            // Column4
            // 
            Column4.HeaderText = "Características";
            Column4.MinimumWidth = 10;
            Column4.Name = "Column4";
            Column4.Width = 200;
            // 
            // Column5
            // 
            Column5.HeaderText = "Estado";
            Column5.MinimumWidth = 10;
            Column5.Name = "Column5";
            Column5.Width = 200;
            // 
            // panel
            // 
            panel.Controls.Add(groupBox1);
            panel.Location = new Point(26, 346);
            panel.Name = "panel";
            panel.Size = new Size(1027, 391);
            panel.TabIndex = 17;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(3, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1041, 397);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tipo Servicio";
            // 
            // button3
            // 
            button3.Location = new Point(774, 189);
            button3.Name = "button3";
            button3.Size = new Size(149, 49);
            button3.TabIndex = 18;
            button3.Text = "Agregar Venta";
            button3.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(501, 122);
            textBox3.Margin = new Padding(2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(188, 27);
            textBox3.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(425, 85);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(203, 20);
            label3.TabIndex = 3;
            label3.Text = "Fecha de registro de la venta:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(630, 83);
            dateTimePicker1.Margin = new Padding(2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(248, 27);
            dateTimePicker1.TabIndex = 2;
            // 
            // Venta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1089, 863);
            Controls.Add(button3);
            Controls.Add(panel);
            Controls.Add(dataGridView1);
            Controls.Add(cbTipoServicio);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(label9);
            Controls.Add(textBox2);
            Controls.Add(label8);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "Venta";
            Text = "0";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label4;
        private ComboBox cbTipoServicio;
        private Button button2;
        private Label label8;
        private Label label9;
        private TextBox textBox2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panel;
        private GroupBox groupBox1;
        private Button button3;
        private TextBox textBox3;
        private Label label3;
        private DateTimePicker dateTimePicker1;
    }
}