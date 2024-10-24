namespace CapaPresentacion.Servicios_Forms
{
    partial class MaquinariaFormServicio
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
            dgwMaquinaria = new DataGridView();
            btnBuscar = new Button();
            txtIdMaquinaria = new TextBox();
            label7 = new Label();
            groupBox2 = new GroupBox();
            btnModificar = new Button();
            cbkEstado = new CheckBox();
            btnDesabilitar = new Button();
            gbAgregar = new GroupBox();
            btnAgregar = new Button();
            cbProveedor = new ComboBox();
            txtPrecio = new TextBox();
            label4 = new Label();
            label2 = new Label();
            txtNombre = new TextBox();
            label3 = new Label();
            txtStock = new TextBox();
            label1 = new Label();
            label8 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label6 = new Label();
            comboBox1 = new ComboBox();
            label9 = new Label();
            textBox3 = new TextBox();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgwMaquinaria).BeginInit();
            groupBox2.SuspendLayout();
            gbAgregar.SuspendLayout();
            SuspendLayout();
            // 
            // dgwMaquinaria
            // 
            dgwMaquinaria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwMaquinaria.Location = new Point(34, 535);
            dgwMaquinaria.Margin = new Padding(6, 4, 6, 4);
            dgwMaquinaria.Name = "dgwMaquinaria";
            dgwMaquinaria.RowHeadersWidth = 51;
            dgwMaquinaria.Size = new Size(1033, 441);
            dgwMaquinaria.TabIndex = 14;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(98, 145);
            btnBuscar.Margin = new Padding(6, 4, 6, 4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(332, 68);
            btnBuscar.TabIndex = 14;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtIdMaquinaria
            // 
            txtIdMaquinaria.Location = new Point(111, 92);
            txtIdMaquinaria.Margin = new Padding(6, 4, 6, 4);
            txtIdMaquinaria.Name = "txtIdMaquinaria";
            txtIdMaquinaria.Size = new Size(301, 39);
            txtIdMaquinaria.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(165, 53);
            label7.Margin = new Padding(6, 0, 6, 0);
            label7.Name = "label7";
            label7.Size = new Size(186, 32);
            label7.TabIndex = 0;
            label7.Text = "Nro. Maquinaria";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnBuscar);
            groupBox2.Controls.Add(txtIdMaquinaria);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(1094, 519);
            groupBox2.Margin = new Padding(6, 4, 6, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(6, 4, 6, 4);
            groupBox2.Size = new Size(535, 252);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            groupBox2.Text = "Buscar";
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(1210, 154);
            btnModificar.Margin = new Padding(6, 4, 6, 4);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(233, 68);
            btnModificar.TabIndex = 8;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // cbkEstado
            // 
            cbkEstado.AutoSize = true;
            cbkEstado.Location = new Point(587, 389);
            cbkEstado.Margin = new Padding(6, 4, 6, 4);
            cbkEstado.Name = "cbkEstado";
            cbkEstado.Size = new Size(276, 36);
            cbkEstado.TabIndex = 13;
            cbkEstado.Text = "Estado de maquinaria";
            cbkEstado.UseVisualStyleBackColor = true;
            // 
            // btnDesabilitar
            // 
            btnDesabilitar.BackColor = SystemColors.ControlDark;
            btnDesabilitar.Location = new Point(1122, 841);
            btnDesabilitar.Margin = new Padding(6, 4, 6, 4);
            btnDesabilitar.Name = "btnDesabilitar";
            btnDesabilitar.Size = new Size(375, 119);
            btnDesabilitar.TabIndex = 17;
            btnDesabilitar.Text = "Desabilitar";
            btnDesabilitar.UseVisualStyleBackColor = false;
            // 
            // gbAgregar
            // 
            gbAgregar.Controls.Add(label10);
            gbAgregar.Controls.Add(textBox3);
            gbAgregar.Controls.Add(label9);
            gbAgregar.Controls.Add(comboBox1);
            gbAgregar.Controls.Add(label6);
            gbAgregar.Controls.Add(textBox2);
            gbAgregar.Controls.Add(textBox1);
            gbAgregar.Controls.Add(label5);
            gbAgregar.Controls.Add(btnModificar);
            gbAgregar.Controls.Add(btnAgregar);
            gbAgregar.Controls.Add(label8);
            gbAgregar.Controls.Add(cbProveedor);
            gbAgregar.Controls.Add(txtPrecio);
            gbAgregar.Controls.Add(cbkEstado);
            gbAgregar.Controls.Add(label4);
            gbAgregar.Controls.Add(txtStock);
            gbAgregar.Controls.Add(label2);
            gbAgregar.Controls.Add(txtNombre);
            gbAgregar.Controls.Add(label3);
            gbAgregar.Location = new Point(22, 64);
            gbAgregar.Margin = new Padding(6, 4, 6, 4);
            gbAgregar.Name = "gbAgregar";
            gbAgregar.Padding = new Padding(6, 4, 6, 4);
            gbAgregar.Size = new Size(1490, 447);
            gbAgregar.TabIndex = 13;
            gbAgregar.TabStop = false;
            gbAgregar.Text = "Datos maquinaria";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(1210, 55);
            btnAgregar.Margin = new Padding(6, 4, 6, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(233, 68);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // cbProveedor
            // 
            cbProveedor.FormattingEnabled = true;
            cbProveedor.Location = new Point(248, 151);
            cbProveedor.Margin = new Padding(6, 4, 6, 4);
            cbProveedor.Name = "cbProveedor";
            cbProveedor.Size = new Size(301, 40);
            cbProveedor.TabIndex = 2;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(248, 63);
            txtPrecio.Margin = new Padding(6, 4, 6, 4);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(301, 39);
            txtPrecio.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 234);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(202, 32);
            label4.TabIndex = 5;
            label4.Text = "Precio de Alquiler";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 154);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(123, 32);
            label2.TabIndex = 1;
            label2.Text = "Proveedor";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(700, 55);
            txtNombre.Margin = new Padding(6, 4, 6, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(301, 39);
            txtNombre.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(587, 66);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(102, 32);
            label3.TabIndex = 3;
            label3.Text = "Nombre";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(248, 227);
            txtStock.Margin = new Padding(6, 4, 6, 4);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(301, 39);
            txtStock.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(609, 15);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(385, 45);
            label1.TabIndex = 12;
            label1.Text = "Mantenedor Maquinaria";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(15, 69);
            label8.Margin = new Padding(6, 0, 6, 0);
            label8.Name = "label8";
            label8.Size = new Size(134, 32);
            label8.TabIndex = 14;
            label8.Text = "Maquinaria";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(587, 151);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(97, 32);
            label5.TabIndex = 15;
            label5.Text = "Modelo";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(701, 147);
            textBox1.Margin = new Padding(6, 4, 6, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(301, 39);
            textBox1.TabIndex = 16;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(710, 227);
            textBox2.Margin = new Padding(6, 4, 6, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(301, 39);
            textBox2.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(587, 230);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(79, 32);
            label6.TabIndex = 18;
            label6.Text = "Marca";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(248, 310);
            comboBox1.Margin = new Padding(6, 4, 6, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(301, 40);
            comboBox1.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(15, 313);
            label9.Margin = new Padding(6, 0, 6, 0);
            label9.Name = "label9";
            label9.Size = new Size(221, 32);
            label9.TabIndex = 20;
            label9.Text = "Tipo de maquinaria";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(710, 313);
            textBox3.Margin = new Padding(6, 4, 6, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(301, 39);
            textBox3.TabIndex = 21;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(587, 318);
            label10.Margin = new Padding(6, 0, 6, 0);
            label10.Name = "label10";
            label10.Size = new Size(76, 32);
            label10.TabIndex = 22;
            label10.Text = "Stock:";
            // 
            // MaquinariaFormServicio
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1686, 1009);
            Controls.Add(dgwMaquinaria);
            Controls.Add(groupBox2);
            Controls.Add(btnDesabilitar);
            Controls.Add(gbAgregar);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6);
            Name = "MaquinariaFormServicio";
            Text = "MaquinariaFormServicio";
            ((System.ComponentModel.ISupportInitialize)dgwMaquinaria).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            gbAgregar.ResumeLayout(false);
            gbAgregar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgwMaquinaria;
        private Button btnBuscar;
        private TextBox txtIdMaquinaria;
        private Label label7;
        private GroupBox groupBox2;
        private Button btnModificar;
        private CheckBox cbkEstado;
        private Button btnDesabilitar;
        private GroupBox gbAgregar;
        private Button btnAgregar;
        private ComboBox cbProveedor;
        private TextBox txtPrecio;
        private Label label4;
        private Label label2;
        private TextBox txtNombre;
        private Label label3;
        private TextBox txtStock;
        private Label label1;
        private Label label8;
        private Label label6;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label5;
        private Label label9;
        private ComboBox comboBox1;
        private Label label10;
        private TextBox textBox3;
    }
}