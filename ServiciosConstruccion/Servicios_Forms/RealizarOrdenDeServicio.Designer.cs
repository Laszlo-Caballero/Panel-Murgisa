namespace CapaPresentacion.Servicios_Forms
{
    partial class RealizarOrdenDeServicio
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
            label6 = new Label();
            txtDniCliente = new TextBox();
            dtFechaRegistro = new DateTimePicker();
            dtvgOrdenes = new DataGridView();
            txtOrdenServicio = new TextBox();
            label10 = new Label();
            groupBox1 = new GroupBox();
            btnBuscar = new Button();
            dvgPagos = new DataGridView();
            txtVenta = new TextBox();
            label11 = new Label();
            dvgMateriales = new DataGridView();
            groupBox2 = new GroupBox();
            btnAgregar = new Button();
            btnAnular = new Button();
            ((System.ComponentModel.ISupportInitialize)dtvgOrdenes).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgPagos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dvgMateriales).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(339, 11);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(261, 41);
            label1.TabIndex = 16;
            label1.Text = "Orden de Servicio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 123);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 17;
            label2.Text = "Cliente:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(33, 182);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(130, 20);
            label6.TabIndex = 21;
            label6.Text = "Fecha de Registro:";
            // 
            // txtDniCliente
            // 
            txtDniCliente.Location = new Point(167, 119);
            txtDniCliente.Margin = new Padding(2);
            txtDniCliente.Name = "txtDniCliente";
            txtDniCliente.Size = new Size(150, 27);
            txtDniCliente.TabIndex = 22;
            // 
            // dtFechaRegistro
            // 
            dtFechaRegistro.Location = new Point(33, 204);
            dtFechaRegistro.Margin = new Padding(2);
            dtFechaRegistro.Name = "dtFechaRegistro";
            dtFechaRegistro.Size = new Size(248, 27);
            dtFechaRegistro.TabIndex = 23;
            // 
            // dtvgOrdenes
            // 
            dtvgOrdenes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtvgOrdenes.Location = new Point(43, 357);
            dtvgOrdenes.Margin = new Padding(2);
            dtvgOrdenes.Name = "dtvgOrdenes";
            dtvgOrdenes.RowHeadersWidth = 82;
            dtvgOrdenes.Size = new Size(710, 238);
            dtvgOrdenes.TabIndex = 30;
            dtvgOrdenes.CellClick += dtvgOrdenes_CellClick;
            dtvgOrdenes.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtOrdenServicio
            // 
            txtOrdenServicio.Enabled = false;
            txtOrdenServicio.Location = new Point(167, 30);
            txtOrdenServicio.Margin = new Padding(2);
            txtOrdenServicio.Name = "txtOrdenServicio";
            txtOrdenServicio.Size = new Size(150, 27);
            txtOrdenServicio.TabIndex = 36;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(30, 34);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(130, 20);
            label10.TabIndex = 37;
            label10.Text = "Orden de Servicio:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnBuscar);
            groupBox1.Controls.Add(dvgPagos);
            groupBox1.Controls.Add(txtVenta);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(txtOrdenServicio);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(dtFechaRegistro);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtDniCliente);
            groupBox1.Location = new Point(43, 54);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(797, 278);
            groupBox1.TabIndex = 42;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Orden de Servicio";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(167, 154);
            btnBuscar.Margin = new Padding(2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(89, 26);
            btnBuscar.TabIndex = 45;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // dvgPagos
            // 
            dvgPagos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgPagos.Location = new Point(340, 24);
            dvgPagos.Margin = new Padding(2);
            dvgPagos.Name = "dvgPagos";
            dvgPagos.RowHeadersWidth = 82;
            dvgPagos.Size = new Size(436, 207);
            dvgPagos.TabIndex = 45;
            dvgPagos.CellClick += dvgPagos_CellClick;
            // 
            // txtVenta
            // 
            txtVenta.Enabled = false;
            txtVenta.Location = new Point(167, 72);
            txtVenta.Margin = new Padding(2);
            txtVenta.Name = "txtVenta";
            txtVenta.Size = new Size(150, 27);
            txtVenta.TabIndex = 43;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(30, 74);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(49, 20);
            label11.TabIndex = 41;
            label11.Text = "Venta:";
            // 
            // dvgMateriales
            // 
            dvgMateriales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgMateriales.Location = new Point(789, 357);
            dvgMateriales.Name = "dvgMateriales";
            dvgMateriales.RowHeadersWidth = 51;
            dvgMateriales.Size = new Size(345, 238);
            dvgMateriales.TabIndex = 45;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnAgregar);
            groupBox2.Controls.Add(btnAnular);
            groupBox2.Location = new Point(861, 60);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(178, 149);
            groupBox2.TabIndex = 46;
            groupBox2.TabStop = false;
            groupBox2.Text = "Servicios";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(18, 33);
            btnAgregar.Margin = new Padding(2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(133, 41);
            btnAgregar.TabIndex = 47;
            btnAgregar.Text = "Guardar Orden";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnAnular
            // 
            btnAnular.Location = new Point(18, 96);
            btnAnular.Margin = new Padding(2);
            btnAnular.Name = "btnAnular";
            btnAnular.Size = new Size(133, 41);
            btnAnular.TabIndex = 48;
            btnAnular.Text = "Anular Orden";
            btnAnular.UseVisualStyleBackColor = true;
            btnAnular.Click += btnAnular_Click;
            // 
            // RealizarOrdenDeServicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1183, 627);
            Controls.Add(groupBox2);
            Controls.Add(dvgMateriales);
            Controls.Add(dtvgOrdenes);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "RealizarOrdenDeServicio";
            Text = "RealizarOrdenDeServicio";
            ((System.ComponentModel.ISupportInitialize)dtvgOrdenes).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dvgPagos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dvgMateriales).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label6;
        private TextBox txtDniCliente;
        private DateTimePicker dtFechaRegistro;
        private DataGridView dtvgOrdenes;
        private TextBox txtOrdenServicio;
        private Label label10;
        private GroupBox groupBox1;
        private TextBox txtVenta;
        private Label label11;
        private Button btnBuscar;
        private DataGridView dvgPagos;
        private DataGridView dvgMateriales;
        private GroupBox groupBox2;
        private Button btnAgregar;
        private Button btnAnular;
    }
}