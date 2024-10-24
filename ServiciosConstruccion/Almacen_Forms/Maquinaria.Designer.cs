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
            btnBuscar = new Button();
            txtIdMaquinaria = new TextBox();
            label7 = new Label();
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
            label1.Location = new Point(354, 7);
            label1.Name = "label1";
            label1.Size = new Size(163, 21);
            label1.TabIndex = 0;
            label1.Text = "Agregar Maquinaria";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 28);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 1;
            label2.Text = "Proveedor";
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(316, 32);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 3;
            label3.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(377, 26);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(164, 23);
            txtNombre.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 74);
            label4.Name = "label4";
            label4.Size = new Size(100, 15);
            label4.TabIndex = 5;
            label4.Text = "Precio de Alquiler";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(124, 71);
            txtPrecio.Margin = new Padding(3, 2, 3, 2);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(164, 23);
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
            gbAgregar.Location = new Point(10, 46);
            gbAgregar.Margin = new Padding(3, 2, 3, 2);
            gbAgregar.Name = "gbAgregar";
            gbAgregar.Padding = new Padding(3, 2, 3, 2);
            gbAgregar.Size = new Size(564, 115);
            gbAgregar.TabIndex = 7;
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
            // dgwMaquinaria
            // 
            dgwMaquinaria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwMaquinaria.Location = new Point(18, 174);
            dgwMaquinaria.Margin = new Padding(3, 2, 3, 2);
            dgwMaquinaria.Name = "dgwMaquinaria";
            dgwMaquinaria.RowHeadersWidth = 51;
            dgwMaquinaria.Size = new Size(556, 292);
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
            groupBox1.Location = new Point(596, 46);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(284, 177);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Actualizar";
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
            cbkEstado.Location = new Point(10, 88);
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 25);
            label6.Name = "label6";
            label6.Size = new Size(18, 15);
            label6.TabIndex = 10;
            label6.Text = "ID";
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
            label5.Location = new Point(10, 56);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 8;
            label5.Text = "Stock";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnBuscar);
            groupBox2.Controls.Add(txtIdMaquinaria);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(598, 241);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(288, 118);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Buscar";
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
            label7.Location = new Point(89, 26);
            label7.Name = "label7";
            label7.Size = new Size(93, 15);
            label7.TabIndex = 0;
            label7.Text = "Nro. Maquinaria";
            // 
            // btnDesabilitar
            // 
            btnDesabilitar.Location = new Point(641, 377);
            btnDesabilitar.Margin = new Padding(3, 2, 3, 2);
            btnDesabilitar.Name = "btnDesabilitar";
            btnDesabilitar.Size = new Size(202, 56);
            btnDesabilitar.TabIndex = 11;
            btnDesabilitar.Text = "Desabilitar";
            btnDesabilitar.UseVisualStyleBackColor = true;
            // 
            // Maquinaria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(909, 488);
            Controls.Add(btnDesabilitar);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dgwMaquinaria);
            Controls.Add(gbAgregar);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
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