namespace CapaPresentacion.Almacen_Forms
{
    partial class Herramienta
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
            btnDesabilitar = new Button();
            groupBox2 = new GroupBox();
            btnBuscar = new Button();
            txtIdMaquinaria = new TextBox();
            label7 = new Label();
            groupBox1 = new GroupBox();
            btnActualizar = new Button();
            cbkEstado = new CheckBox();
            txtId = new TextBox();
            label6 = new Label();
            txtStock = new TextBox();
            label5 = new Label();
            dgwMaquinaria = new DataGridView();
            gbAgregar = new GroupBox();
            btnAgregar = new Button();
            cbProveedor = new ComboBox();
            txtPrecio = new TextBox();
            label4 = new Label();
            label2 = new Label();
            txtNombre = new TextBox();
            label3 = new Label();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwMaquinaria).BeginInit();
            gbAgregar.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(424, 9);
            label1.Name = "label1";
            label1.Size = new Size(156, 20);
            label1.TabIndex = 0;
            label1.Text = "Agregar Herramientas";
            // 
            // btnDesabilitar
            // 
            btnDesabilitar.Location = new Point(750, 500);
            btnDesabilitar.Name = "btnDesabilitar";
            btnDesabilitar.Size = new Size(231, 75);
            btnDesabilitar.TabIndex = 16;
            btnDesabilitar.Text = "Desabilitar";
            btnDesabilitar.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnBuscar);
            groupBox2.Controls.Add(txtIdMaquinaria);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(700, 318);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(329, 157);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Buscar";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(61, 91);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(205, 43);
            btnBuscar.TabIndex = 14;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtIdMaquinaria
            // 
            txtIdMaquinaria.Location = new Point(69, 57);
            txtIdMaquinaria.Name = "txtIdMaquinaria";
            txtIdMaquinaria.Size = new Size(187, 27);
            txtIdMaquinaria.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(102, 35);
            label7.Name = "label7";
            label7.Size = new Size(130, 20);
            label7.TabIndex = 0;
            label7.Text = "Nro. Herramientas";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnActualizar);
            groupBox1.Controls.Add(cbkEstado);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtStock);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(698, 58);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(325, 236);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Actualizar";
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(64, 171);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(195, 43);
            btnActualizar.TabIndex = 8;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            // 
            // cbkEstado
            // 
            cbkEstado.AutoSize = true;
            cbkEstado.Location = new Point(11, 117);
            cbkEstado.Name = "cbkEstado";
            cbkEstado.Size = new Size(76, 24);
            cbkEstado.TabIndex = 13;
            cbkEstado.Text = "Estado";
            cbkEstado.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            txtId.Location = new Point(82, 27);
            txtId.Name = "txtId";
            txtId.Size = new Size(187, 27);
            txtId.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 33);
            label6.Name = "label6";
            label6.Size = new Size(24, 20);
            label6.TabIndex = 10;
            label6.Text = "ID";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(82, 67);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(187, 27);
            txtStock.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 75);
            label5.Name = "label5";
            label5.Size = new Size(45, 20);
            label5.TabIndex = 8;
            label5.Text = "Stock";
            // 
            // dgwMaquinaria
            // 
            dgwMaquinaria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwMaquinaria.Location = new Point(38, 229);
            dgwMaquinaria.Name = "dgwMaquinaria";
            dgwMaquinaria.RowHeadersWidth = 51;
            dgwMaquinaria.Size = new Size(635, 389);
            dgwMaquinaria.TabIndex = 13;
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
            gbAgregar.Location = new Point(28, 58);
            gbAgregar.Name = "gbAgregar";
            gbAgregar.Size = new Size(645, 153);
            gbAgregar.TabIndex = 12;
            gbAgregar.TabStop = false;
            gbAgregar.Text = "Agregar";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(423, 87);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(195, 43);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // cbProveedor
            // 
            cbProveedor.FormattingEnabled = true;
            cbProveedor.Location = new Point(142, 35);
            cbProveedor.Name = "cbProveedor";
            cbProveedor.Size = new Size(187, 28);
            cbProveedor.TabIndex = 2;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(142, 95);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(187, 27);
            txtPrecio.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 99);
            label4.Name = "label4";
            label4.Size = new Size(127, 20);
            label4.TabIndex = 5;
            label4.Text = "Precio de Alquiler";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 37);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 1;
            label2.Text = "Proveedor";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(431, 35);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(187, 27);
            txtNombre.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(361, 43);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 3;
            label3.Text = "Nombre";
            // 
            // Herramienta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1057, 677);
            Controls.Add(btnDesabilitar);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dgwMaquinaria);
            Controls.Add(gbAgregar);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Herramienta";
            Text = "Herramienta";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgwMaquinaria).EndInit();
            gbAgregar.ResumeLayout(false);
            gbAgregar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnDesabilitar;
        private GroupBox groupBox2;
        private Button btnBuscar;
        private TextBox txtIdMaquinaria;
        private Label label7;
        private GroupBox groupBox1;
        private Button btnActualizar;
        private CheckBox cbkEstado;
        private TextBox txtId;
        private Label label6;
        private TextBox txtStock;
        private Label label5;
        private DataGridView dgwMaquinaria;
        private GroupBox gbAgregar;
        private Button btnAgregar;
        private ComboBox cbProveedor;
        private TextBox txtPrecio;
        private Label label4;
        private Label label2;
        private TextBox txtNombre;
        private Label label3;
    }
}