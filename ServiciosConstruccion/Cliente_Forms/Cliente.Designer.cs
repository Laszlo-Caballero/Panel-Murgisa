namespace CapaPresentacion
{
    partial class Cliente
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
            groupBox1 = new GroupBox();
            label4 = new Label();
            txtTelefono = new TextBox();
            txtDni = new TextBox();
            label11 = new Label();
            label9 = new Label();
            txtCorreo = new TextBox();
            txtDireccion = new TextBox();
            cbCiudad = new ComboBox();
            txtNombreRepresentante = new TextBox();
            txtId = new TextBox();
            btnModificar = new Button();
            btnAgregar = new Button();
            cbEstadoCliente = new CheckBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            dtCliente = new DataGridView();
            groupBox2 = new GroupBox();
            btnBuscar = new Button();
            txtBuscar = new TextBox();
            label10 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtCliente).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(409, 19);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(114, 41);
            label1.TabIndex = 0;
            label1.Text = "Cliente";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtTelefono);
            groupBox1.Controls.Add(txtDni);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtCorreo);
            groupBox1.Controls.Add(txtDireccion);
            groupBox1.Controls.Add(cbCiudad);
            groupBox1.Controls.Add(txtNombreRepresentante);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(btnModificar);
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Controls.Add(cbEstadoCliente);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(26, 81);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(908, 232);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del Cliente";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(362, 104);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 23;
            label4.Text = "Telefono:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(516, 101);
            txtTelefono.Margin = new Padding(2);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(201, 27);
            txtTelefono.TabIndex = 22;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(516, 34);
            txtDni.Margin = new Padding(2);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(201, 27);
            txtDni.TabIndex = 21;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(362, 39);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(38, 20);
            label11.TabIndex = 20;
            label11.Text = "DNI:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(362, 69);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(135, 20);
            label9.TabIndex = 19;
            label9.Text = "Correo electrónico:";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(516, 66);
            txtCorreo.Margin = new Padding(2);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(201, 27);
            txtCorreo.TabIndex = 18;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(128, 148);
            txtDireccion.Margin = new Padding(2);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(197, 27);
            txtDireccion.TabIndex = 17;
            // 
            // cbCiudad
            // 
            cbCiudad.FormattingEnabled = true;
            cbCiudad.Location = new Point(125, 108);
            cbCiudad.Margin = new Padding(2);
            cbCiudad.Name = "cbCiudad";
            cbCiudad.Size = new Size(199, 28);
            cbCiudad.TabIndex = 16;
            // 
            // txtNombreRepresentante
            // 
            txtNombreRepresentante.Location = new Point(123, 69);
            txtNombreRepresentante.Margin = new Padding(2);
            txtNombreRepresentante.Name = "txtNombreRepresentante";
            txtNombreRepresentante.Size = new Size(201, 27);
            txtNombreRepresentante.TabIndex = 13;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(123, 37);
            txtId.Margin = new Padding(2);
            txtId.Name = "txtId";
            txtId.Size = new Size(201, 27);
            txtId.TabIndex = 12;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(770, 86);
            btnModificar.Margin = new Padding(2);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(92, 29);
            btnModificar.TabIndex = 10;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(770, 41);
            btnAgregar.Margin = new Padding(2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(92, 29);
            btnAgregar.TabIndex = 9;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // cbEstadoCliente
            // 
            cbEstadoCliente.AutoSize = true;
            cbEstadoCliente.Location = new Point(362, 148);
            cbEstadoCliente.Margin = new Padding(2);
            cbEstadoCliente.Name = "cbEstadoCliente";
            cbEstadoCliente.Size = new Size(149, 24);
            cbEstadoCliente.TabIndex = 6;
            cbEstadoCliente.Text = "Estado del cliente";
            cbEstadoCliente.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(268, 86);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 152);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 4;
            label6.Text = "Dirección";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 108);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(56, 20);
            label5.TabIndex = 3;
            label5.Text = "Ciudad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 68);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(92, 20);
            label3.TabIndex = 1;
            label3.Text = "Razon social";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 41);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 0;
            label2.Text = "Cliente";
            // 
            // dtCliente
            // 
            dtCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtCliente.Location = new Point(38, 331);
            dtCliente.Margin = new Padding(2);
            dtCliente.Name = "dtCliente";
            dtCliente.RowHeadersWidth = 82;
            dtCliente.Size = new Size(726, 249);
            dtCliente.TabIndex = 2;
            dtCliente.CellClick += dtCliente_CellClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnBuscar);
            groupBox2.Controls.Add(txtBuscar);
            groupBox2.Controls.Add(label10);
            groupBox2.Location = new Point(38, 600);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(609, 110);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Buscar Cliente";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(460, 39);
            btnBuscar.Margin = new Padding(2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(92, 29);
            btnBuscar.TabIndex = 16;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(204, 41);
            txtBuscar.Margin = new Padding(2);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(197, 27);
            txtBuscar.TabIndex = 20;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(35, 46);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(160, 20);
            label10.TabIndex = 0;
            label10.Text = "Nro de indentificación:";
            // 
            // Cliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(977, 725);
            Controls.Add(groupBox2);
            Controls.Add(dtCliente);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "Cliente";
            Text = "Cliente";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtCliente).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private CheckBox cbEstadoCliente;
        private Label label7;
        private Label label6;
        private Label label5;
        private Button btnModificar;
        private Button btnAgregar;
        private DataGridView dtCliente;
        private TextBox txtDireccion;
        private ComboBox cbCiudad;
        private TextBox txtNombreRepresentante;
        private TextBox txtId;
        private TextBox txtDni;
        private Label label11;
        private Label label9;
        private TextBox txtCorreo;
        private GroupBox groupBox2;
        private Button btnBuscar;
        private TextBox txtBuscar;
        private Label label10;
        private Label label4;
        private TextBox txtTelefono;
    }
}