namespace CapaPresentacion
{
    partial class FormadePago
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
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            checkBox1 = new CheckBox();
            label7 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(615, 49);
            label1.Name = "label1";
            label1.Size = new Size(358, 65);
            label1.TabIndex = 16;
            label1.Text = "Forma de Pago";
            // 
            // button6
            // 
            button6.Location = new Point(1332, 727);
            button6.Name = "button6";
            button6.Size = new Size(150, 46);
            button6.TabIndex = 21;
            button6.Text = "Deshabilitar";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(1332, 651);
            button5.Name = "button5";
            button5.Size = new Size(150, 46);
            button5.TabIndex = 20;
            button5.Text = "Editar";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(1332, 568);
            button4.Name = "button4";
            button4.Size = new Size(150, 49);
            button4.TabIndex = 19;
            button4.Text = "Nuevo";
            button4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(110, 492);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1179, 399);
            dataGridView1.TabIndex = 18;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(92, 129);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1475, 307);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Forma de Pago";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(352, 142);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(324, 39);
            textBox2.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 145);
            label3.Name = "label3";
            label3.Size = new Size(263, 32);
            label3.TabIndex = 13;
            label3.Text = "Tipo de forma de Pago:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(352, 63);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(324, 39);
            textBox1.TabIndex = 12;
            // 
            // button3
            // 
            button3.Location = new Point(1251, 217);
            button3.Name = "button3";
            button3.Size = new Size(150, 46);
            button3.TabIndex = 11;
            button3.Text = "Cancelar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(1251, 138);
            button2.Name = "button2";
            button2.Size = new Size(150, 46);
            button2.TabIndex = 10;
            button2.Text = "Modificar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(1251, 66);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 9;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(27, 236);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(340, 36);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Estado de la forma de pago";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(435, 138);
            label7.Name = "label7";
            label7.Size = new Size(0, 32);
            label7.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 66);
            label2.Name = "label2";
            label2.Size = new Size(179, 32);
            label2.TabIndex = 0;
            label2.Text = "Forma de Pago:";
            // 
            // FormadePago
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1661, 974);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormadePago";
            Text = "btnFormadePago";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button6;
        private Button button5;
        private Button button4;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private Button button3;
        private Button button2;
        private Button button1;
        private CheckBox checkBox1;
        private Label label7;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
    }
}