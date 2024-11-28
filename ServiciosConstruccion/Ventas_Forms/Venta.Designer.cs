namespace CapaPresentacion
{
    partial class Venta
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
            txtIdVenta = new TextBox();
            label4 = new Label();
            cbTipoServicio = new ComboBox();
            btnConfirmar = new Button();
            textBox2 = new TextBox();
            label8 = new Label();
            dtgvServicios = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            FechaInicio = new DataGridViewTextBoxColumn();
            FechaFin = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel = new Panel();
            btnAgergarVenta = new Button();
            label3 = new Label();
            dtRegistro = new DateTimePicker();
            cbkEstado = new CheckBox();
            groupBox2 = new GroupBox();
            btnEliminarPersonal = new Button();
            txtIdPersonal = new TextBox();
            cbPersonal = new ComboBox();
            label6 = new Label();
            btnAgregarPersonal = new Button();
            dtgvPersonal = new DataGridView();
            idPersonal = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            sueldo = new DataGridViewTextBoxColumn();
            label5 = new Label();
            groupBox3 = new GroupBox();
            btnBuscar = new Button();
            txtRuc = new TextBox();
            label10 = new Label();
            txtCliente = new TextBox();
            txtidCliente = new TextBox();
            label7 = new Label();
            label9 = new Label();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dtgvServicios).BeginInit();
            panel.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvPersonal).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(426, 21);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(138, 28);
            label1.TabIndex = 0;
            label1.Text = "Realizar Venta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 83);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 1;
            label2.Text = "Venta:";
            // 
            // txtIdVenta
            // 
            txtIdVenta.Enabled = false;
            txtIdVenta.Location = new Point(190, 83);
            txtIdVenta.Margin = new Padding(2);
            txtIdVenta.Name = "txtIdVenta";
            txtIdVenta.Size = new Size(181, 27);
            txtIdVenta.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(62, 128);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(119, 20);
            label4.TabIndex = 5;
            label4.Text = "Tipo de Servicio:";
            // 
            // cbTipoServicio
            // 
            cbTipoServicio.FormattingEnabled = true;
            cbTipoServicio.Location = new Point(190, 123);
            cbTipoServicio.Margin = new Padding(2);
            cbTipoServicio.Name = "cbTipoServicio";
            cbTipoServicio.Size = new Size(181, 28);
            cbTipoServicio.TabIndex = 6;
            cbTipoServicio.SelectedIndexChanged += cbTipoServicio_SelectedIndexChanged;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(801, 754);
            btnConfirmar.Margin = new Padding(2);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(160, 52);
            btnConfirmar.TabIndex = 10;
            btnConfirmar.Text = "Confirmar venta";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(124, 768);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(120, 27);
            textBox2.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(67, 770);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(45, 20);
            label8.TabIndex = 15;
            label8.Text = "Total:";
            // 
            // dtgvServicios
            // 
            dtgvServicios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvServicios.Columns.AddRange(new DataGridViewColumn[] { Column1, FechaInicio, FechaFin, Column5 });
            dtgvServicios.Location = new Point(62, 189);
            dtgvServicios.Margin = new Padding(2);
            dtgvServicios.Name = "dtgvServicios";
            dtgvServicios.RowHeadersWidth = 82;
            dtgvServicios.Size = new Size(664, 140);
            dtgvServicios.TabIndex = 12;
            // 
            // Column1
            // 
            Column1.HeaderText = "Nombre del servicio";
            Column1.MinimumWidth = 10;
            Column1.Name = "Column1";
            Column1.Width = 200;
            // 
            // FechaInicio
            // 
            FechaInicio.HeaderText = "FechaInicio";
            FechaInicio.MinimumWidth = 10;
            FechaInicio.Name = "FechaInicio";
            FechaInicio.Width = 200;
            // 
            // FechaFin
            // 
            FechaFin.HeaderText = "FechaFin";
            FechaFin.MinimumWidth = 6;
            FechaFin.Name = "FechaFin";
            FechaFin.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Estado";
            Column5.MinimumWidth = 10;
            Column5.Name = "Column5";
            Column5.Width = 200;
            // 
            // panel
            // 
            panel.Controls.Add(groupBox1);
            panel.Location = new Point(26, 346);
            panel.Name = "panel";
            panel.Size = new Size(996, 405);
            panel.TabIndex = 17;
            // 
            // btnAgergarVenta
            // 
            btnAgergarVenta.Location = new Point(597, 757);
            btnAgergarVenta.Name = "btnAgergarVenta";
            btnAgergarVenta.Size = new Size(149, 49);
            btnAgergarVenta.TabIndex = 18;
            btnAgergarVenta.Text = "Agregar Venta";
            btnAgergarVenta.UseVisualStyleBackColor = true;
            btnAgergarVenta.Click += btnAgergarVenta_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(425, 85);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(203, 20);
            label3.TabIndex = 3;
            label3.Text = "Fecha de registro de la venta:";
            // 
            // dtRegistro
            // 
            dtRegistro.Location = new Point(426, 107);
            dtRegistro.Margin = new Padding(2);
            dtRegistro.Name = "dtRegistro";
            dtRegistro.Size = new Size(248, 27);
            dtRegistro.TabIndex = 2;
            // 
            // cbkEstado
            // 
            cbkEstado.AutoSize = true;
            cbkEstado.Location = new Point(426, 148);
            cbkEstado.Name = "cbkEstado";
            cbkEstado.Size = new Size(76, 24);
            cbkEstado.TabIndex = 19;
            cbkEstado.Text = "estado";
            cbkEstado.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnEliminarPersonal);
            groupBox2.Controls.Add(txtIdPersonal);
            groupBox2.Controls.Add(cbPersonal);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(btnAgregarPersonal);
            groupBox2.Controls.Add(dtgvPersonal);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(1028, 346);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(289, 431);
            groupBox2.TabIndex = 20;
            groupBox2.TabStop = false;
            groupBox2.Text = "Personal";
            // 
            // btnEliminarPersonal
            // 
            btnEliminarPersonal.Location = new Point(127, 168);
            btnEliminarPersonal.Name = "btnEliminarPersonal";
            btnEliminarPersonal.Size = new Size(96, 40);
            btnEliminarPersonal.TabIndex = 26;
            btnEliminarPersonal.Text = "eliminar";
            btnEliminarPersonal.UseVisualStyleBackColor = true;
            btnEliminarPersonal.Click += btnEliminarPersonal_Click;
            // 
            // txtIdPersonal
            // 
            txtIdPersonal.Enabled = false;
            txtIdPersonal.Location = new Point(15, 73);
            txtIdPersonal.Margin = new Padding(2);
            txtIdPersonal.Name = "txtIdPersonal";
            txtIdPersonal.Size = new Size(188, 27);
            txtIdPersonal.TabIndex = 21;
            // 
            // cbPersonal
            // 
            cbPersonal.FormattingEnabled = true;
            cbPersonal.Location = new Point(15, 126);
            cbPersonal.Margin = new Padding(2);
            cbPersonal.Name = "cbPersonal";
            cbPersonal.Size = new Size(181, 28);
            cbPersonal.TabIndex = 25;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 104);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(64, 20);
            label6.TabIndex = 24;
            label6.Text = "Personal";
            // 
            // btnAgregarPersonal
            // 
            btnAgregarPersonal.Location = new Point(25, 168);
            btnAgregarPersonal.Name = "btnAgregarPersonal";
            btnAgregarPersonal.Size = new Size(96, 40);
            btnAgregarPersonal.TabIndex = 21;
            btnAgregarPersonal.Text = "Agregar";
            btnAgregarPersonal.UseVisualStyleBackColor = true;
            btnAgregarPersonal.Click += btnAgregarPersonal_Click;
            // 
            // dtgvPersonal
            // 
            dtgvPersonal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvPersonal.Columns.AddRange(new DataGridViewColumn[] { idPersonal, nombre, sueldo });
            dtgvPersonal.Location = new Point(15, 230);
            dtgvPersonal.Name = "dtgvPersonal";
            dtgvPersonal.RowHeadersWidth = 51;
            dtgvPersonal.Size = new Size(255, 171);
            dtgvPersonal.TabIndex = 23;
            dtgvPersonal.CellClick += dtgvPersonal_CellClick;
            // 
            // idPersonal
            // 
            idPersonal.HeaderText = "idPersonal";
            idPersonal.MinimumWidth = 6;
            idPersonal.Name = "idPersonal";
            idPersonal.Width = 125;
            // 
            // nombre
            // 
            nombre.HeaderText = "nombre";
            nombre.MinimumWidth = 6;
            nombre.Name = "nombre";
            nombre.Width = 125;
            // 
            // sueldo
            // 
            sueldo.HeaderText = "sueldo";
            sueldo.MinimumWidth = 6;
            sueldo.Name = "sueldo";
            sueldo.Width = 125;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 45);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(22, 20);
            label5.TabIndex = 21;
            label5.Text = "id";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnBuscar);
            groupBox3.Controls.Add(txtRuc);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(txtCliente);
            groupBox3.Controls.Add(txtidCliente);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label9);
            groupBox3.Location = new Point(755, 85);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(538, 234);
            groupBox3.TabIndex = 21;
            groupBox3.TabStop = false;
            groupBox3.Text = "Cliente";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(257, 155);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(96, 40);
            btnBuscar.TabIndex = 27;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtRuc
            // 
            txtRuc.Location = new Point(18, 162);
            txtRuc.Margin = new Padding(2);
            txtRuc.Name = "txtRuc";
            txtRuc.Size = new Size(188, 27);
            txtRuc.TabIndex = 31;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(18, 134);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(103, 20);
            label10.TabIndex = 32;
            label10.Text = "Buscar por ruc";
            // 
            // txtCliente
            // 
            txtCliente.Enabled = false;
            txtCliente.Location = new Point(242, 63);
            txtCliente.Margin = new Padding(2);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(188, 27);
            txtCliente.TabIndex = 30;
            // 
            // txtidCliente
            // 
            txtidCliente.Enabled = false;
            txtidCliente.Location = new Point(18, 63);
            txtidCliente.Margin = new Padding(2);
            txtidCliente.Name = "txtidCliente";
            txtidCliente.Size = new Size(188, 27);
            txtidCliente.TabIndex = 27;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(242, 37);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(55, 20);
            label7.TabIndex = 29;
            label7.Text = "Cliente";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(18, 35);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(22, 20);
            label9.TabIndex = 28;
            label9.Text = "id";
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(2, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(993, 397);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tipo Servicio";
            // 
            // Venta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1317, 863);
            Controls.Add(btnAgergarVenta);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(cbkEstado);
            Controls.Add(panel);
            Controls.Add(dtgvServicios);
            Controls.Add(cbTipoServicio);
            Controls.Add(btnConfirmar);
            Controls.Add(label4);
            Controls.Add(txtIdVenta);
            Controls.Add(label3);
            Controls.Add(dtRegistro);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(label8);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "Venta";
            Text = "0";
            ((System.ComponentModel.ISupportInitialize)dtgvServicios).EndInit();
            panel.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvPersonal).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtIdVenta;
        private Label label4;
        private ComboBox cbTipoServicio;
        private Button btnConfirmar;
        private Label label8;
        private TextBox textBox2;
        private DataGridView dtgvServicios;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panel;
        private Button btnAgergarVenta;
        private Label label3;
        private DateTimePicker dtRegistro;
        private CheckBox cbkEstado;
        private GroupBox groupBox2;
        private Button btnEliminarPersonal;
        private TextBox txtIdPersonal;
        private ComboBox cbPersonal;
        private Label label6;
        private Button btnAgregarPersonal;
        private DataGridView dtgvPersonal;
        private Label label5;
        private GroupBox groupBox3;
        private Button btnBuscar;
        private TextBox txtRuc;
        private Label label10;
        private TextBox txtCliente;
        private TextBox txtidCliente;
        private Label label7;
        private Label label9;
        private DataGridViewTextBoxColumn idPersonal;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn sueldo;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn FechaInicio;
        private DataGridViewTextBoxColumn FechaFin;
        private DataGridViewTextBoxColumn Column5;
        private GroupBox groupBox1;
    }
}