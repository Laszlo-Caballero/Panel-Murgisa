namespace CapaPresentacion.Mantenimiento_Forms
{
    partial class MantenimientoCorrectivo
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
            label9 = new Label();
            btnSalir = new Button();
            dtPickerFechaMc = new DateTimePicker();
            btnDeshabilitar = new Button();
            label8 = new Label();
            dgvOrdenMan = new DataGridView();
            Planificacion = new GroupBox();
            cbEstado = new CheckBox();
            txtRuc = new TextBox();
            label10 = new Label();
            txtProveedor = new TextBox();
            txtMaquinaria = new TextBox();
            cbPedido = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            dtPickerFechaOrden = new DateTimePicker();
            label4 = new Label();
            label3 = new Label();
            txtOrden = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnNuevo = new Button();
            txtOrdenMc = new TextBox();
            groupBox1 = new GroupBox();
            btnBuscar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvOrdenMan).BeginInit();
            Planificacion.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(341, 45);
            label9.Name = "label9";
            label9.Size = new Size(103, 20);
            label9.TabIndex = 31;
            label9.Text = "Nro de Orden:";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(754, 301);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(114, 57);
            btnSalir.TabIndex = 33;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // dtPickerFechaMc
            // 
            dtPickerFechaMc.Location = new Point(27, 87);
            dtPickerFechaMc.Name = "dtPickerFechaMc";
            dtPickerFechaMc.Size = new Size(289, 27);
            dtPickerFechaMc.TabIndex = 30;
            // 
            // btnDeshabilitar
            // 
            btnDeshabilitar.Location = new Point(622, 301);
            btnDeshabilitar.Name = "btnDeshabilitar";
            btnDeshabilitar.Size = new Size(114, 57);
            btnDeshabilitar.TabIndex = 24;
            btnDeshabilitar.Text = "Desahabilitar";
            btnDeshabilitar.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(27, 45);
            label8.Name = "label8";
            label8.Size = new Size(50, 20);
            label8.TabIndex = 28;
            label8.Text = "Fecha:";
            // 
            // dgvOrdenMan
            // 
            dgvOrdenMan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrdenMan.Location = new Point(366, 60);
            dgvOrdenMan.Name = "dgvOrdenMan";
            dgvOrdenMan.RowHeadersWidth = 51;
            dgvOrdenMan.Size = new Size(550, 211);
            dgvOrdenMan.TabIndex = 23;
            dgvOrdenMan.CellDoubleClick += dgvOrdenMan_CellDoubleClick;
            // 
            // Planificacion
            // 
            Planificacion.Controls.Add(cbEstado);
            Planificacion.Controls.Add(txtRuc);
            Planificacion.Controls.Add(label10);
            Planificacion.Controls.Add(txtProveedor);
            Planificacion.Controls.Add(txtMaquinaria);
            Planificacion.Controls.Add(cbPedido);
            Planificacion.Controls.Add(label7);
            Planificacion.Controls.Add(label6);
            Planificacion.Controls.Add(label5);
            Planificacion.Controls.Add(dtPickerFechaOrden);
            Planificacion.Controls.Add(label4);
            Planificacion.Controls.Add(label3);
            Planificacion.Controls.Add(txtOrden);
            Planificacion.Controls.Add(label1);
            Planificacion.Location = new Point(11, 44);
            Planificacion.Name = "Planificacion";
            Planificacion.Size = new Size(320, 508);
            Planificacion.TabIndex = 32;
            Planificacion.TabStop = false;
            Planificacion.Text = "Correctivo";
            // 
            // cbEstado
            // 
            cbEstado.AutoSize = true;
            cbEstado.Location = new Point(15, 417);
            cbEstado.Margin = new Padding(3, 4, 3, 4);
            cbEstado.Name = "cbEstado";
            cbEstado.Size = new Size(86, 24);
            cbEstado.TabIndex = 40;
            cbEstado.Text = "ESTADO";
            cbEstado.UseVisualStyleBackColor = true;
            // 
            // txtRuc
            // 
            txtRuc.Location = new Point(13, 356);
            txtRuc.Margin = new Padding(3, 4, 3, 4);
            txtRuc.Name = "txtRuc";
            txtRuc.Size = new Size(196, 27);
            txtRuc.TabIndex = 39;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(13, 332);
            label10.Name = "label10";
            label10.Size = new Size(40, 20);
            label10.TabIndex = 38;
            label10.Text = "RUC:";
            // 
            // txtProveedor
            // 
            txtProveedor.Location = new Point(185, 284);
            txtProveedor.Margin = new Padding(3, 4, 3, 4);
            txtProveedor.Name = "txtProveedor";
            txtProveedor.Size = new Size(114, 27);
            txtProveedor.TabIndex = 37;
            // 
            // txtMaquinaria
            // 
            txtMaquinaria.Location = new Point(13, 284);
            txtMaquinaria.Margin = new Padding(3, 4, 3, 4);
            txtMaquinaria.Name = "txtMaquinaria";
            txtMaquinaria.Size = new Size(114, 27);
            txtMaquinaria.TabIndex = 36;
            // 
            // cbPedido
            // 
            cbPedido.FormattingEnabled = true;
            cbPedido.Location = new Point(13, 213);
            cbPedido.Margin = new Padding(3, 4, 3, 4);
            cbPedido.Name = "cbPedido";
            cbPedido.Size = new Size(138, 28);
            cbPedido.TabIndex = 35;
            cbPedido.SelectedIndexChanged += cbPedido_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(155, 257);
            label7.Name = "label7";
            label7.Size = new Size(77, 20);
            label7.TabIndex = 8;
            label7.Text = "Proveedor";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 257);
            label6.Name = "label6";
            label6.Size = new Size(87, 20);
            label6.TabIndex = 7;
            label6.Text = "Maquinaria:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 189);
            label5.Name = "label5";
            label5.Size = new Size(55, 20);
            label5.TabIndex = 6;
            label5.Text = "Pedido";
            // 
            // dtPickerFechaOrden
            // 
            dtPickerFechaOrden.Location = new Point(10, 143);
            dtPickerFechaOrden.Name = "dtPickerFechaOrden";
            dtPickerFechaOrden.Size = new Size(289, 27);
            dtPickerFechaOrden.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 112);
            label4.Name = "label4";
            label4.Size = new Size(113, 20);
            label4.TabIndex = 4;
            label4.Text = "Fecha de Orden";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 123);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 3;
            // 
            // txtOrden
            // 
            txtOrden.Enabled = false;
            txtOrden.Location = new Point(7, 71);
            txtOrden.Name = "txtOrden";
            txtOrden.Size = new Size(202, 27);
            txtOrden.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 37);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 0;
            label1.Text = "Nro de Orden";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(270, 21);
            label2.Name = "label2";
            label2.Size = new Size(219, 20);
            label2.TabIndex = 22;
            label2.Text = "MANTENIMIENTO CORRECTIVO";
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(502, 298);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(114, 57);
            btnNuevo.TabIndex = 25;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // txtOrdenMc
            // 
            txtOrdenMc.Location = new Point(341, 87);
            txtOrdenMc.Name = "txtOrdenMc";
            txtOrdenMc.Size = new Size(202, 27);
            txtOrdenMc.TabIndex = 17;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtOrdenMc);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(dtPickerFechaMc);
            groupBox1.Controls.Add(label8);
            groupBox1.Location = new Point(353, 388);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(603, 207);
            groupBox1.TabIndex = 34;
            groupBox1.TabStop = false;
            groupBox1.Text = "Buscar";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(375, 301);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(114, 57);
            btnBuscar.TabIndex = 26;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // MantenimientoCorrectivo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(983, 627);
            Controls.Add(groupBox1);
            Controls.Add(btnSalir);
            Controls.Add(btnDeshabilitar);
            Controls.Add(btnBuscar);
            Controls.Add(dgvOrdenMan);
            Controls.Add(Planificacion);
            Controls.Add(label2);
            Controls.Add(btnNuevo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MantenimientoCorrectivo";
            Text = "MantenimientoCorrectivo";
            ((System.ComponentModel.ISupportInitialize)dgvOrdenMan).EndInit();
            Planificacion.ResumeLayout(false);
            Planificacion.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label9;
        private Button btnSalir;
        private DateTimePicker dtPickerFechaMc;
        private Button btnDeshabilitar;
        private Label label8;
        private DataGridView dgvOrdenMan;
        private GroupBox Planificacion;
        private Label label7;
        private Label label6;
        private Label label5;
        private DateTimePicker dtPickerFechaOrden;
        private Label label4;
        private Label label3;
        private TextBox txtOrden;
        private Label label1;
        private Label label2;
        private Button btnNuevo;
        private TextBox txtOrdenMc;
        private GroupBox groupBox1;
        private Button btnBuscar;
        private TextBox txtMaquinaria;
        private ComboBox cbPedido;
        private CheckBox cbEstado;
        private TextBox txtRuc;
        private Label label10;
        private TextBox txtProveedor;
    }
}