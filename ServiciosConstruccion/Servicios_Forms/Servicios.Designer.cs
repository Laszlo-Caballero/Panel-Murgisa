namespace CapaPresentacion
{
    partial class Servicios
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
            dtServicio = new DataGridView();
            groupBox1 = new GroupBox();
            txtPrecio = new TextBox();
            txtNombre = new TextBox();
            txtId = new TextBox();
            btnDeshabilita = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            cbkEstado = new CheckBox();
            label7 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtServicio).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dtServicio
            // 
            dtServicio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtServicio.Location = new Point(47, 298);
            dtServicio.Margin = new Padding(2);
            dtServicio.Name = "dtServicio";
            dtServicio.RowHeadersWidth = 82;
            dtServicio.Size = new Size(803, 249);
            dtServicio.TabIndex = 17;
            dtServicio.CellClick += dtServicio_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtPrecio);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(btnDeshabilita);
            groupBox1.Controls.Add(btnModificar);
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Controls.Add(cbkEstado);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(36, 84);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(814, 193);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del Servicio";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(156, 108);
            txtPrecio.Margin = new Padding(2);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(201, 27);
            txtPrecio.TabIndex = 15;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(156, 66);
            txtNombre.Margin = new Padding(2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(201, 27);
            txtNombre.TabIndex = 13;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(156, 34);
            txtId.Margin = new Padding(2);
            txtId.Name = "txtId";
            txtId.Size = new Size(201, 27);
            txtId.TabIndex = 12;
            // 
            // btnDeshabilita
            // 
            btnDeshabilita.Location = new Point(670, 136);
            btnDeshabilita.Margin = new Padding(2);
            btnDeshabilita.Name = "btnDeshabilita";
            btnDeshabilita.Size = new Size(92, 29);
            btnDeshabilita.TabIndex = 11;
            btnDeshabilita.Text = "deshabilitar";
            btnDeshabilita.UseVisualStyleBackColor = true;
            btnDeshabilita.Click += btnDeshabilita_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(670, 82);
            btnModificar.Margin = new Padding(2);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(92, 29);
            btnModificar.TabIndex = 10;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click_1;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(670, 34);
            btnAgregar.Margin = new Padding(2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(92, 29);
            btnAgregar.TabIndex = 9;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // cbkEstado
            // 
            cbkEstado.AutoSize = true;
            cbkEstado.Location = new Point(414, 34);
            cbkEstado.Margin = new Padding(2);
            cbkEstado.Name = "cbkEstado";
            cbkEstado.Size = new Size(155, 24);
            cbkEstado.TabIndex = 6;
            cbkEstado.Text = "Estado del servicio";
            cbkEstado.UseVisualStyleBackColor = true;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 106);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 2;
            label4.Text = "Precio:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 68);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(143, 20);
            label3.TabIndex = 1;
            label3.Text = "Nombre del servicio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 39);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 0;
            label2.Text = "Servicio";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(404, 21);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(138, 41);
            label1.TabIndex = 15;
            label1.Text = "Servicios";
            // 
            // Servicios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(980, 607);
            Controls.Add(dtServicio);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "Servicios";
            Text = "Servicios";
            ((System.ComponentModel.ISupportInitialize)dtServicio).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button6;
        private Button button5;
        private Button button4;
        private DataGridView dtServicio;
        private GroupBox groupBox1;
        private TextBox txtPrecio;
        private TextBox txtId;
        private TextBox txtNombre;
        private Button btnModificar;
        private Button btnDeshabilita;
        private Button btnAgregar;
        private CheckBox cbkEstado;
        private Label label7;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}