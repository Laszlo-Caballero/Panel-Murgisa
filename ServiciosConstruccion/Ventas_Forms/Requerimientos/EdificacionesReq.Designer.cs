namespace CapaPresentacion.Ventas_Forms.Requerimientos
{
    partial class EdificacionesReq
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
            textBox8 = new TextBox();
            textBox4 = new TextBox();
            label14 = new Label();
            label16 = new Label();
            label17 = new Label();
            dtFin = new DateTimePicker();
            label18 = new Label();
            dtInicio = new DateTimePicker();
            label20 = new Label();
            groupBox1 = new GroupBox();
            txtId = new TextBox();
            label1 = new Label();
            dtgvMateriales = new DataGridView();
            idMaterial = new DataGridViewTextBoxColumn();
            Material = new DataGridViewTextBoxColumn();
            cantidad = new DataGridViewTextBoxColumn();
            txtCantidad = new TextBox();
            label19 = new Label();
            label15 = new Label();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            cbMateriales = new ComboBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvMateriales).BeginInit();
            SuspendLayout();
            // 
            // textBox8
            // 
            textBox8.Location = new Point(176, 93);
            textBox8.Margin = new Padding(2);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(125, 27);
            textBox8.TabIndex = 55;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(447, 85);
            textBox4.Margin = new Padding(2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 53;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(315, 90);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(131, 20);
            label14.TabIndex = 45;
            label14.Text = "Cantidad de pisos:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(247, 125);
            label16.Margin = new Padding(2, 0, 2, 0);
            label16.Name = "label16";
            label16.Size = new Size(0, 20);
            label16.TabIndex = 44;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(10, 93);
            label17.Margin = new Padding(2, 0, 2, 0);
            label17.Name = "label17";
            label17.Size = new Size(116, 20);
            label17.TabIndex = 43;
            label17.Text = "Área a construir:";
            // 
            // dtFin
            // 
            dtFin.Location = new Point(315, 45);
            dtFin.Margin = new Padding(2);
            dtFin.Name = "dtFin";
            dtFin.Size = new Size(248, 27);
            dtFin.TabIndex = 42;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(315, 23);
            label18.Margin = new Padding(2, 0, 2, 0);
            label18.Name = "label18";
            label18.Size = new Size(92, 20);
            label18.TabIndex = 41;
            label18.Text = "Fecha de fin:";
            // 
            // dtInicio
            // 
            dtInicio.Location = new Point(15, 45);
            dtInicio.Margin = new Padding(2);
            dtInicio.Name = "dtInicio";
            dtInicio.Size = new Size(248, 27);
            dtInicio.TabIndex = 40;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(10, 23);
            label20.Margin = new Padding(2, 0, 2, 0);
            label20.Name = "label20";
            label20.Size = new Size(111, 20);
            label20.TabIndex = 39;
            label20.Text = "Fecha de inicio:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dtgvMateriales);
            groupBox1.Controls.Add(txtCantidad);
            groupBox1.Controls.Add(label19);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Controls.Add(btnModificar);
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Controls.Add(cbMateriales);
            groupBox1.Location = new Point(12, 135);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(850, 336);
            groupBox1.TabIndex = 56;
            groupBox1.TabStop = false;
            groupBox1.Text = "Materiales";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(179, 39);
            txtId.Margin = new Padding(2);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 66;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(143, 42);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(25, 20);
            label1.TabIndex = 65;
            label1.Text = "id:";
            // 
            // dtgvMateriales
            // 
            dtgvMateriales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvMateriales.Columns.AddRange(new DataGridViewColumn[] { idMaterial, Material, cantidad });
            dtgvMateriales.Location = new Point(334, 39);
            dtgvMateriales.Name = "dtgvMateriales";
            dtgvMateriales.RowHeadersWidth = 51;
            dtgvMateriales.Size = new Size(463, 212);
            dtgvMateriales.TabIndex = 64;
            dtgvMateriales.CellClick += dtgvMateriales_CellClick;
            // 
            // idMaterial
            // 
            idMaterial.HeaderText = "idMaterial";
            idMaterial.MinimumWidth = 6;
            idMaterial.Name = "idMaterial";
            idMaterial.Width = 125;
            // 
            // Material
            // 
            Material.HeaderText = "Material";
            Material.MinimumWidth = 6;
            Material.Name = "Material";
            Material.Width = 125;
            // 
            // cantidad
            // 
            cantidad.HeaderText = "cantidad";
            cantidad.MinimumWidth = 6;
            cantidad.Name = "cantidad";
            cantidad.Width = 125;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(179, 120);
            txtCantidad.Margin = new Padding(2);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(125, 27);
            txtCantidad.TabIndex = 63;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(18, 124);
            label19.Margin = new Padding(2, 0, 2, 0);
            label19.Name = "label19";
            label19.Size = new Size(72, 20);
            label19.TabIndex = 62;
            label19.Text = "Cantidad:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(12, 82);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(156, 20);
            label15.TabIndex = 61;
            label15.Text = "Materiales requeridos:";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(210, 210);
            btnEliminar.Margin = new Padding(2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(92, 29);
            btnEliminar.TabIndex = 60;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(87, 165);
            btnModificar.Margin = new Padding(2);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(92, 29);
            btnModificar.TabIndex = 59;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(210, 165);
            btnAgregar.Margin = new Padding(2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(92, 29);
            btnAgregar.TabIndex = 58;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // cbMateriales
            // 
            cbMateriales.FormattingEnabled = true;
            cbMateriales.Location = new Point(179, 80);
            cbMateriales.Margin = new Padding(2);
            cbMateriales.Name = "cbMateriales";
            cbMateriales.Size = new Size(125, 28);
            cbMateriales.TabIndex = 57;
            // 
            // EdificacionesReq
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(887, 501);
            Controls.Add(groupBox1);
            Controls.Add(textBox8);
            Controls.Add(textBox4);
            Controls.Add(label14);
            Controls.Add(label16);
            Controls.Add(label17);
            Controls.Add(dtFin);
            Controls.Add(label18);
            Controls.Add(dtInicio);
            Controls.Add(label20);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EdificacionesReq";
            Text = "EdificacionesReq";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvMateriales).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox8;
        private TextBox textBox4;
        private ListBox listBox1;
        private ComboBox comboBox4;
        private Label label14;
        private Label label16;
        private Label label17;
        private DateTimePicker dtFin;
        private Label label18;
        private DateTimePicker dtInicio;
        private Label label20;
        private GroupBox groupBox1;
        private DataGridView dtgvMateriales;
        private TextBox txtCantidad;
        private Label label19;
        private Label label15;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnAgregar;
        private ComboBox cbMateriales;
        private DataGridViewTextBoxColumn idMaterial;
        private DataGridViewTextBoxColumn Material;
        private DataGridViewTextBoxColumn cantidad;
        private TextBox txtId;
        private Label label1;
    }
}