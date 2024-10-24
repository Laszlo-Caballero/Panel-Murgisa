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
            btnActualizar = new Button();
            cbkEstado = new CheckBox();
            txtId = new TextBox();
            btnDesabilitar = new Button();
            label6 = new Label();
            gbAgregar = new GroupBox();
            btnAgregar = new Button();
            cbProveedor = new ComboBox();
            txtPrecio = new TextBox();
            label4 = new Label();
            label2 = new Label();
            txtNombre = new TextBox();
            label3 = new Label();
            txtStock = new TextBox();
            label5 = new Label();
            groupBox1 = new GroupBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgwMaquinaria).BeginInit();
            groupBox2.SuspendLayout();
            gbAgregar.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgwMaquinaria
            // 
            dgwMaquinaria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwMaquinaria.Location = new Point(20, 158);
            dgwMaquinaria.Margin = new Padding(3, 2, 3, 2);
            dgwMaquinaria.Name = "dgwMaquinaria";
            dgwMaquinaria.RowHeadersWidth = 51;
            dgwMaquinaria.Size = new Size(556, 292);
            dgwMaquinaria.TabIndex = 14;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(53, 68);
            btnBuscar.Margin = new Padding(3, 2, 3, 2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(179, 32);
            btnBuscar.TabIndex = 14;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtIdMaquinaria
            // 
            txtIdMaquinaria.Location = new Point(60, 43);
            txtIdMaquinaria.Margin = new Padding(3, 2, 3, 2);
            txtIdMaquinaria.Name = "txtIdMaquinaria";
            txtIdMaquinaria.Size = new Size(164, 23);
            txtIdMaquinaria.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(89, 25);
            label7.Name = "label7";
            label7.Size = new Size(93, 15);
            label7.TabIndex = 0;
            label7.Text = "Nro. Maquinaria";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnBuscar);
            groupBox2.Controls.Add(txtIdMaquinaria);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(600, 225);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(288, 118);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            groupBox2.Text = "Buscar";
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(56, 128);
            btnActualizar.Margin = new Padding(3, 2, 3, 2);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(171, 32);
            btnActualizar.TabIndex = 8;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            // 
            // cbkEstado
            // 
            cbkEstado.AutoSize = true;
            cbkEstado.Location = new Point(10, 87);
            cbkEstado.Margin = new Padding(3, 2, 3, 2);
            cbkEstado.Name = "cbkEstado";
            cbkEstado.Size = new Size(61, 19);
            cbkEstado.TabIndex = 13;
            cbkEstado.Text = "Estado";
            cbkEstado.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            txtId.Location = new Point(72, 20);
            txtId.Margin = new Padding(3, 2, 3, 2);
            txtId.Name = "txtId";
            txtId.Size = new Size(164, 23);
            txtId.TabIndex = 11;
            // 
            // btnDesabilitar
            // 
            btnDesabilitar.BackColor = SystemColors.ControlDark;
            btnDesabilitar.Location = new Point(643, 361);
            btnDesabilitar.Margin = new Padding(3, 2, 3, 2);
            btnDesabilitar.Name = "btnDesabilitar";
            btnDesabilitar.Size = new Size(202, 56);
            btnDesabilitar.TabIndex = 17;
            btnDesabilitar.Text = "Desabilitar";
            btnDesabilitar.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 24);
            label6.Name = "label6";
            label6.Size = new Size(18, 15);
            label6.TabIndex = 10;
            label6.Text = "ID";
            // 
            // gbAgregar
            // 
            gbAgregar.Controls.Add(btnAgregar);
            gbAgregar.Controls.Add(cbProveedor);
            gbAgregar.Controls.Add(txtPrecio);
            gbAgregar.Controls.Add(label4);
            gbAgregar.Controls.Add(label2);
            gbAgregar.Controls.Add(txtNombre);
            gbAgregar.Controls.Add(label3);
            gbAgregar.Location = new Point(12, 30);
            gbAgregar.Margin = new Padding(3, 2, 3, 2);
            gbAgregar.Name = "gbAgregar";
            gbAgregar.Padding = new Padding(3, 2, 3, 2);
            gbAgregar.Size = new Size(564, 115);
            gbAgregar.TabIndex = 13;
            gbAgregar.TabStop = false;
            gbAgregar.Text = "Agregar";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(370, 65);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(171, 32);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // cbProveedor
            // 
            cbProveedor.FormattingEnabled = true;
            cbProveedor.Location = new Point(124, 26);
            cbProveedor.Margin = new Padding(3, 2, 3, 2);
            cbProveedor.Name = "cbProveedor";
            cbProveedor.Size = new Size(164, 23);
            cbProveedor.TabIndex = 2;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(124, 71);
            txtPrecio.Margin = new Padding(3, 2, 3, 2);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(164, 23);
            txtPrecio.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 73);
            label4.Name = "label4";
            label4.Size = new Size(100, 15);
            label4.TabIndex = 5;
            label4.Text = "Precio de Alquiler";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 27);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 1;
            label2.Text = "Proveedor";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(377, 26);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(164, 23);
            txtNombre.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(316, 31);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 3;
            label3.Text = "Nombre";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(72, 50);
            txtStock.Margin = new Padding(3, 2, 3, 2);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(164, 23);
            txtStock.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 55);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 8;
            label5.Text = "Stock";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnActualizar);
            groupBox1.Controls.Add(cbkEstado);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtStock);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(598, 30);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(284, 177);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Actualizar";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(362, 7);
            label1.Name = "label1";
            label1.Size = new Size(163, 21);
            label1.TabIndex = 12;
            label1.Text = "Agregar Maquinaria";
            // 
            // MaquinariaFormServicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(908, 473);
            Controls.Add(dgwMaquinaria);
            Controls.Add(groupBox2);
            Controls.Add(btnDesabilitar);
            Controls.Add(gbAgregar);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "MaquinariaFormServicio";
            Text = "MaquinariaFormServicio";
            ((System.ComponentModel.ISupportInitialize)dgwMaquinaria).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            gbAgregar.ResumeLayout(false);
            gbAgregar.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgwMaquinaria;
        private Button btnBuscar;
        private TextBox txtIdMaquinaria;
        private Label label7;
        private GroupBox groupBox2;
        private Button btnActualizar;
        private CheckBox cbkEstado;
        private TextBox txtId;
        private Button btnDesabilitar;
        private Label label6;
        private GroupBox gbAgregar;
        private Button btnAgregar;
        private ComboBox cbProveedor;
        private TextBox txtPrecio;
        private Label label4;
        private Label label2;
        private TextBox txtNombre;
        private Label label3;
        private TextBox txtStock;
        private Label label5;
        private GroupBox groupBox1;
        private Label label1;
    }
}