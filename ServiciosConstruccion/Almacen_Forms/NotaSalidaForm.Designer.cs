namespace CapaPresentacion.Almacen_Forms
{
    partial class NotaSalidaForm
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
            label3 = new Label();
            btnBuscar = new Button();
            groupBox3 = new GroupBox();
            txtNotaIngreso = new TextBox();
            btnNuevoCliente = new Button();
            btnDeshabilitar = new Button();
            btnCancelar = new Button();
            dtvNotaIngreso = new DataGridView();
            label7 = new Label();
            btnAgregar = new Button();
            txtCantidadRecibido = new TextBox();
            label5 = new Label();
            cbNombreProveedor = new ComboBox();
            label4 = new Label();
            groupBox1 = new GroupBox();
            cbNombreProducto = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            groupBox2 = new GroupBox();
            groupBox4 = new GroupBox();
            label8 = new Label();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtvNotaIngreso).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 51);
            label3.Name = "label3";
            label3.Size = new Size(112, 15);
            label3.TabIndex = 21;
            label3.Text = "Nro. Nota de Salida:";
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
            // groupBox3
            // 
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(btnBuscar);
            groupBox3.Controls.Add(txtNotaIngreso);
            groupBox3.Location = new Point(708, 74);
            groupBox3.Margin = new Padding(2, 1, 2, 1);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(2, 1, 2, 1);
            groupBox3.Size = new Size(177, 189);
            groupBox3.TabIndex = 38;
            groupBox3.TabStop = false;
            groupBox3.Text = "Buscar Nota Ingreso";
            // 
            // txtNotaIngreso
            // 
            txtNotaIngreso.Location = new Point(45, 90);
            txtNotaIngreso.Margin = new Padding(2, 1, 2, 1);
            txtNotaIngreso.Name = "txtNotaIngreso";
            txtNotaIngreso.Size = new Size(84, 23);
            txtNotaIngreso.TabIndex = 20;
            // 
            // btnNuevoCliente
            // 
            btnNuevoCliente.Location = new Point(456, 399);
            btnNuevoCliente.Margin = new Padding(2, 1, 2, 1);
            btnNuevoCliente.Name = "btnNuevoCliente";
            btnNuevoCliente.Size = new Size(185, 32);
            btnNuevoCliente.TabIndex = 37;
            btnNuevoCliente.Text = "Registrar nuevo cliente";
            btnNuevoCliente.UseVisualStyleBackColor = true;
            // 
            // btnDeshabilitar
            // 
            btnDeshabilitar.Location = new Point(232, 399);
            btnDeshabilitar.Margin = new Padding(2, 1, 2, 1);
            btnDeshabilitar.Name = "btnDeshabilitar";
            btnDeshabilitar.Size = new Size(81, 32);
            btnDeshabilitar.TabIndex = 36;
            btnDeshabilitar.Text = "Deshabilitar";
            btnDeshabilitar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(93, 399);
            btnCancelar.Margin = new Padding(2, 1, 2, 1);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(81, 32);
            btnCancelar.TabIndex = 35;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // dtvNotaIngreso
            // 
            dtvNotaIngreso.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtvNotaIngreso.Location = new Point(388, 74);
            dtvNotaIngreso.Margin = new Padding(2, 1, 2, 1);
            dtvNotaIngreso.Name = "dtvNotaIngreso";
            dtvNotaIngreso.RowHeadersWidth = 82;
            dtvNotaIngreso.Size = new Size(313, 321);
            dtvNotaIngreso.TabIndex = 34;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(44, 213);
            label7.Name = "label7";
            label7.Size = new Size(125, 15);
            label7.TabIndex = 31;
            label7.Text = "Nombre del Producto:";
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
            // txtCantidadRecibido
            // 
            txtCantidadRecibido.Location = new Point(202, 284);
            txtCantidadRecibido.Name = "txtCantidadRecibido";
            txtCantidadRecibido.Size = new Size(54, 23);
            txtCantidadRecibido.TabIndex = 30;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(44, 292);
            label5.Name = "label5";
            label5.Size = new Size(91, 15);
            label5.TabIndex = 29;
            label5.Text = "Cantidad salida:";
            // 
            // cbNombreProveedor
            // 
            cbNombreProveedor.FormattingEnabled = true;
            cbNombreProveedor.Location = new Point(176, 71);
            cbNombreProveedor.Name = "cbNombreProveedor";
            cbNombreProveedor.Size = new Size(148, 23);
            cbNombreProveedor.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 253);
            label4.Name = "label4";
            label4.Size = new Size(130, 15);
            label4.TabIndex = 28;
            label4.Text = "Nombre del Proveedor:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbNombreProducto);
            groupBox1.Controls.Add(cbNombreProveedor);
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Location = new Point(26, 174);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(357, 172);
            groupBox1.TabIndex = 32;
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
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(176, 22);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(148, 23);
            dateTimePicker1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 104);
            label2.Name = "label2";
            label2.Size = new Size(102, 15);
            label2.TabIndex = 27;
            label2.Text = "Fecha de Emision:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dateTimePicker1);
            groupBox2.Location = new Point(26, 74);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(357, 69);
            groupBox2.TabIndex = 33;
            groupBox2.TabStop = false;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label8);
            groupBox4.Location = new Point(12, 12);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(872, 46);
            groupBox4.TabIndex = 39;
            groupBox4.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(325, 11);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(174, 32);
            label8.TabIndex = 13;
            label8.Text = "Nota de Salida";
            // 
            // NotaSalidaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(895, 456);
            Controls.Add(groupBox3);
            Controls.Add(btnNuevoCliente);
            Controls.Add(btnDeshabilitar);
            Controls.Add(btnCancelar);
            Controls.Add(dtvNotaIngreso);
            Controls.Add(label7);
            Controls.Add(txtCantidadRecibido);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(groupBox2);
            Controls.Add(groupBox4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NotaSalidaForm";
            Text = "NotaSalidaForm";
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtvNotaIngreso).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Button btnBuscar;
        private GroupBox groupBox3;
        private TextBox txtNotaIngreso;
        private Button btnNuevoCliente;
        private Button btnDeshabilitar;
        private Button btnCancelar;
        private DataGridView dtvNotaIngreso;
        private Label label7;
        private Button btnAgregar;
        private TextBox txtCantidadRecibido;
        private Label label5;
        private ComboBox cbNombreProveedor;
        private Label label4;
        private GroupBox groupBox1;
        private ComboBox cbNombreProducto;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private GroupBox groupBox2;
        private GroupBox groupBox4;
        private Label label8;
    }
}