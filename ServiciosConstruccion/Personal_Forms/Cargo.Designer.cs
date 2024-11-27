namespace CapaPresentacion.Personal_Forms
{
    partial class Cargo
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
            txtCargo = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            checkBox1 = new CheckBox();
            dataGridView1 = new DataGridView();
            textBox4 = new TextBox();
            label5 = new Label();
            btnBuscar = new Button();
            btnAgregar = new Button();
            btnEditar = new Button();
            btnDeshabilitar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 21);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 0;
            label1.Text = "CARGOID:";
            // 
            // txtCargo
            // 
            txtCargo.Location = new Point(100, 18);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(125, 23);
            txtCargo.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(100, 63);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 23);
            textBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 66);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 2;
            label2.Text = "NOMBRE:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(373, 18);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(364, 23);
            textBox2.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(283, 24);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 4;
            label3.Text = "DESCRIPCION:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(355, 66);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 23);
            textBox3.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(288, 69);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 6;
            label4.Text = "SUELDO";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(532, 66);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(68, 19);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "ESTADO";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 144);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(615, 241);
            dataGridView1.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(100, 105);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 23);
            textBox4.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 108);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 10;
            label5.Text = "CRITERIO";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(263, 100);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(90, 38);
            btnBuscar.TabIndex = 12;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(647, 144);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(100, 38);
            btnAgregar.TabIndex = 13;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(647, 206);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(100, 38);
            btnEditar.TabIndex = 14;
            btnEditar.Text = "EDITAR";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnDeshabilitar
            // 
            btnDeshabilitar.Location = new Point(647, 266);
            btnDeshabilitar.Name = "btnDeshabilitar";
            btnDeshabilitar.Size = new Size(100, 38);
            btnDeshabilitar.TabIndex = 15;
            btnDeshabilitar.Text = "DESHABILITAR";
            btnDeshabilitar.UseVisualStyleBackColor = true;
            // 
            // Cargo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(776, 408);
            Controls.Add(btnDeshabilitar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Controls.Add(btnBuscar);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Controls.Add(checkBox1);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(txtCargo);
            Controls.Add(label1);
            Name = "Cargo";
            Text = "Cargo";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCargo;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private CheckBox checkBox1;
        private DataGridView dataGridView1;
        private TextBox textBox4;
        private Label label5;
        private Button btnBuscar;
        private Button btnAgregar;
        private Button btnEditar;
        private Button btnDeshabilitar;
    }
}