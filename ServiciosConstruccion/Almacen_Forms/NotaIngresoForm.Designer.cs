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
            txtCantidadRecibido = new TextBox();
            label8 = new Label();
            label7 = new Label();
            groupBox1 = new GroupBox();
            cbNombreProducto = new ComboBox();
            cbNombreProveedor = new ComboBox();
            btnAgregar = new Button();
            groupBox2 = new GroupBox();
            dateTimePicker1 = new DateTimePicker();
            dtvNotaIngreso = new DataGridView();
            btnCancelar = new Button();
            btnDeshabilitar = new Button();
            btnNuevoCliente = new Button();
            btnBuscar = new Button();
            txtNotaIngreso = new TextBox();
            groupBox3 = new GroupBox();
            label3 = new Label();
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
            // txtCantidadRecibido
            // 
            txtCantidadRecibido.Location = new Point(202, 275);
            txtCantidadRecibido.Name = "txtCantidadRecibido";
            txtCantidadRecibido.Size = new Size(54, 23);
            txtCantidadRecibido.TabIndex = 11;
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
            groupBox1.Controls.Add(cbNombreProducto);
            groupBox1.Controls.Add(cbNombreProveedor);
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Location = new Point(26, 165);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(357, 172);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Descripcion del Producto";
            // 
            // cbNombreProducto
            // 
            cbNombreProducto.FormattingEnabled = true;
            cbNombreProducto.Location = new Point(176, 31);
            cbNombreProducto.Name = "cbNombreProducto";
            cbNombreProducto.Size = new Size(148, 23);
            cbNombreProducto.TabIndex = 21;
            // 
            // cbNombreProveedor
            // 
            cbNombreProveedor.FormattingEnabled = true;
            cbNombreProveedor.Location = new Point(176, 71);
            cbNombreProveedor.Name = "cbNombreProveedor";
            cbNombreProveedor.Size = new Size(148, 23);
            cbNombreProveedor.TabIndex = 20;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(256, 118);
            btnAgregar.Margin = new Padding(2, 1, 2, 1);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(81, 32);
            btnAgregar.TabIndex = 19;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
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
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(176, 22);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(148, 23);
            dateTimePicker1.TabIndex = 0;
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
            // btnCancelar
            // 
            btnCancelar.Location = new Point(93, 390);
            btnCancelar.Margin = new Padding(2, 1, 2, 1);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(81, 32);
            btnCancelar.TabIndex = 21;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnDeshabilitar
            // 
            btnDeshabilitar.Location = new Point(232, 390);
            btnDeshabilitar.Margin = new Padding(2, 1, 2, 1);
            btnDeshabilitar.Name = "btnDeshabilitar";
            btnDeshabilitar.Size = new Size(81, 32);
            btnDeshabilitar.TabIndex = 22;
            btnDeshabilitar.Text = "Deshabilitar";
            btnDeshabilitar.UseVisualStyleBackColor = true;
            // 
            // btnNuevoCliente
            // 
            btnNuevoCliente.Location = new Point(456, 390);
            btnNuevoCliente.Margin = new Padding(2, 1, 2, 1);
            btnNuevoCliente.Name = "btnNuevoCliente";
            btnNuevoCliente.Size = new Size(185, 32);
            btnNuevoCliente.TabIndex = 23;
            btnNuevoCliente.Text = "Registrar nuevo cliente";
            btnNuevoCliente.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(57, 130);
            btnBuscar.Margin = new Padding(2, 1, 2, 1);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(55, 22);
            btnBuscar.TabIndex = 16;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtNotaIngreso
            // 
            txtNotaIngreso.Location = new Point(45, 90);
            txtNotaIngreso.Margin = new Padding(2, 1, 2, 1);
            txtNotaIngreso.Name = "txtNotaIngreso";
            txtNotaIngreso.Size = new Size(84, 23);
            txtNotaIngreso.TabIndex = 20;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(btnBuscar);
            groupBox3.Controls.Add(txtNotaIngreso);
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
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(896, 432);
            Controls.Add(groupBox3);
            Controls.Add(btnNuevoCliente);
            Controls.Add(btnDeshabilitar);
            Controls.Add(btnCancelar);
            Controls.Add(dtvNotaIngreso);
            Controls.Add(label7);
            Controls.Add(txtCantidadRecibido);
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
        private TextBox txtCantidadRecibido;
        private Label label8;
        private Label label7;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dtvNotaIngreso;
        private Button btnAgregar;
        private Button btnCancelar;
        private Button btnDeshabilitar;
        private Button btnNuevoCliente;
        private Button btnBuscar;
        private TextBox txtNotaIngreso;
        private GroupBox groupBox3;
        private Label label3;
        private ComboBox cbNombreProducto;
        private ComboBox cbNombreProveedor;
        private DateTimePicker dateTimePicker1;
        private GroupBox groupBox4;
    }
}