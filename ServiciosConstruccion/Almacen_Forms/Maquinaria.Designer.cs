namespace CapaPresentacion.Almacen_Forms
{
    partial class Maquinaria
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
            cbProveedor = new ComboBox();
            label3 = new Label();
            txtNombre = new TextBox();
            label4 = new Label();
            txtPrecio = new TextBox();
            gbAgregar = new GroupBox();
            btnAgregar = new Button();
            dgwMaquinaria = new DataGridView();
            groupBox1 = new GroupBox();
            btnActualizar = new Button();
            cbkEstado = new CheckBox();
            txtId = new TextBox();
            label6 = new Label();
            txtStock = new TextBox();
            label5 = new Label();
            groupBox2 = new GroupBox();
            txtIdMaquinaria = new TextBox();
            label7 = new Label();
            btnBuscar = new Button();
            btnDesabilitar = new Button();
            gbAgregar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwMaquinaria).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(405, 9);
            label1.Name = "label1";
            label1.Size = new Size(202, 28);
            label1.TabIndex = 0;
            label1.Text = "Agregar Maquinaria";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 38);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 1;
            label2.Text = "Proveedor";
            // 
            // cbProveedor
            // 
            cbProveedor.FormattingEnabled = true;
            cbProveedor.Location = new Point(142, 34);
            cbProveedor.Name = "cbProveedor";
            cbProveedor.Size = new Size(187, 28);
            cbProveedor.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(361, 42);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 3;
            label3.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(431, 35);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(187, 27);
            txtNombre.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 98);
            label4.Name = "label4";
            label4.Size = new Size(127, 20);
            label4.TabIndex = 5;
            label4.Text = "Precio de Alquiler";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(142, 95);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(187, 27);
            txtPrecio.TabIndex = 6;
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
            gbAgregar.Location = new Point(12, 62);
            gbAgregar.Name = "gbAgregar";
            gbAgregar.Size = new Size(645, 153);
            gbAgregar.TabIndex = 7;
            gbAgregar.TabStop = false;
            gbAgregar.Text = "Agregar";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(423, 87);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(195, 42);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // dgwMaquinaria
            // 
            dgwMaquinaria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwMaquinaria.Location = new Point(21, 232);
            dgwMaquinaria.Name = "dgwMaquinaria";
            dgwMaquinaria.RowHeadersWidth = 51;
            dgwMaquinaria.Size = new Size(636, 390);
            dgwMaquinaria.TabIndex = 8;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnActualizar);
            groupBox1.Controls.Add(cbkEstado);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtStock);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(681, 62);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(324, 236);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Actualizar";
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(64, 170);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(195, 42);
            btnActualizar.TabIndex = 8;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            // 
            // cbkEstado
            // 
            cbkEstado.AutoSize = true;
            cbkEstado.Location = new Point(12, 117);
            cbkEstado.Name = "cbkEstado";
            cbkEstado.Size = new Size(76, 24);
            cbkEstado.TabIndex = 13;
            cbkEstado.Text = "Estado";
            cbkEstado.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            txtId.Location = new Point(82, 26);
            txtId.Name = "txtId";
            txtId.Size = new Size(187, 27);
            txtId.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 33);
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
            label5.Location = new Point(12, 74);
            label5.Name = "label5";
            label5.Size = new Size(45, 20);
            label5.TabIndex = 8;
            label5.Text = "Stock";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnBuscar);
            groupBox2.Controls.Add(txtIdMaquinaria);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(684, 321);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(329, 158);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Buscar";
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
            label7.Location = new Point(102, 34);
            label7.Name = "label7";
            label7.Size = new Size(116, 20);
            label7.TabIndex = 0;
            label7.Text = "Nro. Maquinaria";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(61, 90);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(205, 42);
            btnBuscar.TabIndex = 14;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnDesabilitar
            // 
            btnDesabilitar.Location = new Point(730, 527);
            btnDesabilitar.Name = "btnDesabilitar";
            btnDesabilitar.Size = new Size(231, 75);
            btnDesabilitar.TabIndex = 11;
            btnDesabilitar.Text = "Desabilitar";
            btnDesabilitar.UseVisualStyleBackColor = true;
            // 
            // Maquinaria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1039, 651);
            Controls.Add(btnDesabilitar);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dgwMaquinaria);
            Controls.Add(gbAgregar);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Maquinaria";
            Text = "Maquinaria";
            gbAgregar.ResumeLayout(false);
            gbAgregar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgwMaquinaria).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cbProveedor;
        private Label label3;
        private TextBox txtNombre;
        private Label label4;
        private TextBox txtPrecio;
        private GroupBox gbAgregar;
        private Button btnAgregar;
        private DataGridView dgwMaquinaria;
        private GroupBox groupBox1;
        private TextBox txtId;
        private Label label6;
        private TextBox txtStock;
        private Label label5;
        private Button btnActualizar;
        private CheckBox cbkEstado;
        private GroupBox groupBox2;
        private TextBox txtIdMaquinaria;
        private Label label7;
        private Button btnBuscar;
        private Button btnDesabilitar;
    }
}