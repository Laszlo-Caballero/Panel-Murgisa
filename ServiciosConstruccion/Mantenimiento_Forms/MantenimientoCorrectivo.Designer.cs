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
            label9.Location = new Point(298, 34);
            label9.Name = "label9";
            label9.Size = new Size(82, 15);
            label9.TabIndex = 31;
            label9.Text = "Nro de Orden:";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(638, 226);
            btnSalir.Margin = new Padding(3, 2, 3, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(100, 43);
            btnSalir.TabIndex = 33;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // dtPickerFechaMc
            // 
            dtPickerFechaMc.Location = new Point(24, 65);
            dtPickerFechaMc.Margin = new Padding(3, 2, 3, 2);
            dtPickerFechaMc.Name = "dtPickerFechaMc";
            dtPickerFechaMc.Size = new Size(253, 23);
            dtPickerFechaMc.TabIndex = 30;
            // 
            // btnDeshabilitar
            // 
            btnDeshabilitar.Location = new Point(532, 226);
            btnDeshabilitar.Margin = new Padding(3, 2, 3, 2);
            btnDeshabilitar.Name = "btnDeshabilitar";
            btnDeshabilitar.Size = new Size(100, 43);
            btnDeshabilitar.TabIndex = 24;
            btnDeshabilitar.Text = "Desahabilitar";
            btnDeshabilitar.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(24, 34);
            label8.Name = "label8";
            label8.Size = new Size(41, 15);
            label8.TabIndex = 28;
            label8.Text = "Fecha:";
            // 
            // dgvOrdenMan
            // 
            dgvOrdenMan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrdenMan.Location = new Point(320, 45);
            dgvOrdenMan.Margin = new Padding(3, 2, 3, 2);
            dgvOrdenMan.Name = "dgvOrdenMan";
            dgvOrdenMan.RowHeadersWidth = 51;
            dgvOrdenMan.Size = new Size(481, 158);
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
            Planificacion.Location = new Point(10, 33);
            Planificacion.Margin = new Padding(3, 2, 3, 2);
            Planificacion.Name = "Planificacion";
            Planificacion.Padding = new Padding(3, 2, 3, 2);
            Planificacion.Size = new Size(280, 381);
            Planificacion.TabIndex = 32;
            Planificacion.TabStop = false;
            Planificacion.Text = "Correctivo";
            // 
            // cbEstado
            // 
            cbEstado.AutoSize = true;
            cbEstado.Location = new Point(13, 313);
            cbEstado.Name = "cbEstado";
            cbEstado.Size = new Size(68, 19);
            cbEstado.TabIndex = 40;
            cbEstado.Text = "ESTADO";
            cbEstado.UseVisualStyleBackColor = true;
            // 
            // txtRuc
            // 
            txtRuc.Location = new Point(11, 267);
            txtRuc.Name = "txtRuc";
            txtRuc.Size = new Size(172, 23);
            txtRuc.TabIndex = 39;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(11, 249);
            label10.Name = "label10";
            label10.Size = new Size(33, 15);
            label10.TabIndex = 38;
            label10.Text = "RUC:";
            // 
            // txtProveedor
            // 
            txtProveedor.Location = new Point(162, 213);
            txtProveedor.Name = "txtProveedor";
            txtProveedor.Size = new Size(100, 23);
            txtProveedor.TabIndex = 37;
            // 
            // txtMaquinaria
            // 
            txtMaquinaria.Location = new Point(11, 213);
            txtMaquinaria.Name = "txtMaquinaria";
            txtMaquinaria.Size = new Size(100, 23);
            txtMaquinaria.TabIndex = 36;
            // 
            // cbPedido
            // 
            cbPedido.FormattingEnabled = true;
            cbPedido.Location = new Point(11, 160);
            cbPedido.Name = "cbPedido";
            cbPedido.Size = new Size(121, 23);
            cbPedido.TabIndex = 35;
            cbPedido.SelectedIndexChanged += cbPedido_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(136, 193);
            label7.Name = "label7";
            label7.Size = new Size(61, 15);
            label7.TabIndex = 8;
            label7.Text = "Proveedor";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 193);
            label6.Name = "label6";
            label6.Size = new Size(70, 15);
            label6.TabIndex = 7;
            label6.Text = "Maquinaria:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 142);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 6;
            label5.Text = "Pedido";
            // 
            // dtPickerFechaOrden
            // 
            dtPickerFechaOrden.Location = new Point(9, 107);
            dtPickerFechaOrden.Margin = new Padding(3, 2, 3, 2);
            dtPickerFechaOrden.Name = "dtPickerFechaOrden";
            dtPickerFechaOrden.Size = new Size(253, 23);
            dtPickerFechaOrden.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 84);
            label4.Name = "label4";
            label4.Size = new Size(90, 15);
            label4.TabIndex = 4;
            label4.Text = "Fecha de Orden";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 92);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 3;
            // 
            // txtOrden
            // 
            txtOrden.Enabled = false;
            txtOrden.Location = new Point(6, 53);
            txtOrden.Margin = new Padding(3, 2, 3, 2);
            txtOrden.Name = "txtOrden";
            txtOrden.Size = new Size(177, 23);
            txtOrden.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 28);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 0;
            label1.Text = "Nro de Orden";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(236, 16);
            label2.Name = "label2";
            label2.Size = new Size(175, 15);
            label2.TabIndex = 22;
            label2.Text = "MANTENIMIENTO CORRECTIVO";
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(426, 226);
            btnNuevo.Margin = new Padding(3, 2, 3, 2);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(100, 43);
            btnNuevo.TabIndex = 25;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // txtOrdenMc
            // 
            txtOrdenMc.Location = new Point(298, 65);
            txtOrdenMc.Margin = new Padding(3, 2, 3, 2);
            txtOrdenMc.Name = "txtOrdenMc";
            txtOrdenMc.Size = new Size(177, 23);
            txtOrdenMc.TabIndex = 17;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtOrdenMc);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(dtPickerFechaMc);
            groupBox1.Controls.Add(label8);
            groupBox1.Location = new Point(309, 291);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(528, 155);
            groupBox1.TabIndex = 34;
            groupBox1.TabStop = false;
            groupBox1.Text = "Buscar";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(320, 226);
            btnBuscar.Margin = new Padding(3, 2, 3, 2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(100, 43);
            btnBuscar.TabIndex = 26;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // MantenimientoCorrectivo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(848, 422);
            Controls.Add(groupBox1);
            Controls.Add(btnSalir);
            Controls.Add(btnDeshabilitar);
            Controls.Add(btnBuscar);
            Controls.Add(dgvOrdenMan);
            Controls.Add(Planificacion);
            Controls.Add(label2);
            Controls.Add(btnNuevo);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
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