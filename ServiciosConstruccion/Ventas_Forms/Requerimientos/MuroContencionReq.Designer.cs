namespace CapaPresentacion.Ventas_Forms.Requerimientos
{
    partial class MuroContencionReq
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
            textBox10 = new TextBox();
            label23 = new Label();
            label24 = new Label();
            label25 = new Label();
            dateTimePicker6 = new DateTimePicker();
            label26 = new Label();
            dateTimePicker7 = new DateTimePicker();
            label27 = new Label();
            textBox12 = new TextBox();
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
            label16 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvMateriales).BeginInit();
            SuspendLayout();
            // 
            // textBox10
            // 
            textBox10.Location = new Point(186, 94);
            textBox10.Margin = new Padding(2);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(125, 27);
            textBox10.TabIndex = 57;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(325, 91);
            label23.Margin = new Padding(2, 0, 2, 0);
            label23.Name = "label23";
            label23.Size = new Size(107, 20);
            label23.TabIndex = 47;
            label23.Text = "Área del muro:";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(257, 126);
            label24.Margin = new Padding(2, 0, 2, 0);
            label24.Name = "label24";
            label24.Size = new Size(0, 20);
            label24.TabIndex = 46;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(20, 94);
            label25.Margin = new Padding(2, 0, 2, 0);
            label25.Name = "label25";
            label25.Size = new Size(135, 20);
            label25.TabIndex = 45;
            label25.Text = "Longitud del muro:";
            // 
            // dateTimePicker6
            // 
            dateTimePicker6.Location = new Point(325, 46);
            dateTimePicker6.Margin = new Padding(2);
            dateTimePicker6.Name = "dateTimePicker6";
            dateTimePicker6.Size = new Size(248, 27);
            dateTimePicker6.TabIndex = 44;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(325, 24);
            label26.Margin = new Padding(2, 0, 2, 0);
            label26.Name = "label26";
            label26.Size = new Size(92, 20);
            label26.TabIndex = 43;
            label26.Text = "Fecha de fin:";
            // 
            // dateTimePicker7
            // 
            dateTimePicker7.Location = new Point(25, 46);
            dateTimePicker7.Margin = new Padding(2);
            dateTimePicker7.Name = "dateTimePicker7";
            dateTimePicker7.Size = new Size(248, 27);
            dateTimePicker7.TabIndex = 42;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(20, 24);
            label27.Margin = new Padding(2, 0, 2, 0);
            label27.Name = "label27";
            label27.Size = new Size(111, 20);
            label27.TabIndex = 41;
            label27.Text = "Fecha de inicio:";
            // 
            // textBox12
            // 
            textBox12.Location = new Point(437, 86);
            textBox12.Margin = new Padding(2);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(125, 27);
            textBox12.TabIndex = 55;
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
            groupBox1.Location = new Point(20, 126);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(850, 336);
            groupBox1.TabIndex = 59;
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
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(255, 116);
            label16.Margin = new Padding(2, 0, 2, 0);
            label16.Name = "label16";
            label16.Size = new Size(0, 20);
            label16.TabIndex = 58;
            // 
            // MuroContencionReq
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 503);
            Controls.Add(groupBox1);
            Controls.Add(label16);
            Controls.Add(textBox10);
            Controls.Add(label23);
            Controls.Add(label24);
            Controls.Add(label25);
            Controls.Add(dateTimePicker6);
            Controls.Add(label26);
            Controls.Add(dateTimePicker7);
            Controls.Add(label27);
            Controls.Add(textBox12);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MuroContencionReq";
            Text = "MuroContencionReq";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvMateriales).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox10;
        private Label label23;
        private Label label24;
        private Label label25;
        private DateTimePicker dateTimePicker6;
        private Label label26;
        private DateTimePicker dateTimePicker7;
        private Label label27;
        private TextBox textBox12;
        private GroupBox groupBox1;
        private TextBox txtId;
        private Label label1;
        private DataGridView dtgvMateriales;
        private DataGridViewTextBoxColumn idMaterial;
        private DataGridViewTextBoxColumn Material;
        private DataGridViewTextBoxColumn cantidad;
        private TextBox txtCantidad;
        private Label label19;
        private Label label15;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnAgregar;
        private ComboBox cbMateriales;
        private Label label16;
    }
}