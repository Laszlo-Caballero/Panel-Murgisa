namespace CapaPresentacion.Ventas_Forms.Requerimientos
{
    partial class AlquilerMaqReq
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
            btnEliminar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            label13 = new Label();
            cbMaquinaria = new ComboBox();
            label11 = new Label();
            label10 = new Label();
            cbkEstadoOperador = new CheckBox();
            txtCantidad = new TextBox();
            dtgvMaquinarias = new DataGridView();
            txtId = new TextBox();
            label1 = new Label();
            label6 = new Label();
            dtInicio = new DateTimePicker();
            label5 = new Label();
            dtFin = new DateTimePicker();
            idMaquinaria = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            fechaInicio = new DataGridViewTextBoxColumn();
            fechaFin = new DataGridViewTextBoxColumn();
            cantidad = new DataGridViewTextBoxColumn();
            operador = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtgvMaquinarias).BeginInit();
            SuspendLayout();
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(889, 293);
            btnEliminar.Margin = new Padding(2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(92, 29);
            btnEliminar.TabIndex = 49;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click_1;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(889, 245);
            btnModificar.Margin = new Padding(2);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(92, 29);
            btnModificar.TabIndex = 48;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += button4_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(889, 192);
            btnAgregar.Margin = new Padding(2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(92, 29);
            btnAgregar.TabIndex = 47;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(326, 87);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(72, 20);
            label13.TabIndex = 44;
            label13.Text = "Cantidad:";
            // 
            // cbMaquinaria
            // 
            cbMaquinaria.FormattingEnabled = true;
            cbMaquinaria.Location = new Point(170, 85);
            cbMaquinaria.Margin = new Padding(2);
            cbMaquinaria.Name = "cbMaquinaria";
            cbMaquinaria.Size = new Size(118, 28);
            cbMaquinaria.TabIndex = 40;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(258, 122);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(0, 20);
            label11.TabIndex = 39;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(21, 90);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(142, 20);
            label10.TabIndex = 38;
            label10.Text = "Tipo de maquinaria:";
            // 
            // cbkEstadoOperador
            // 
            cbkEstadoOperador.AutoSize = true;
            cbkEstadoOperador.Location = new Point(595, 85);
            cbkEstadoOperador.Name = "cbkEstadoOperador";
            cbkEstadoOperador.Size = new Size(178, 24);
            cbkEstadoOperador.TabIndex = 51;
            cbkEstadoOperador.Text = "Se necesita operador?";
            cbkEstadoOperador.UseVisualStyleBackColor = true;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(403, 85);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(125, 27);
            txtCantidad.TabIndex = 52;
            // 
            // dtgvMaquinarias
            // 
            dtgvMaquinarias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvMaquinarias.Columns.AddRange(new DataGridViewColumn[] { idMaquinaria, nombre, fechaInicio, fechaFin, cantidad, operador });
            dtgvMaquinarias.Location = new Point(30, 155);
            dtgvMaquinarias.Name = "dtgvMaquinarias";
            dtgvMaquinarias.RowHeadersWidth = 51;
            dtgvMaquinarias.Size = new Size(827, 200);
            dtgvMaquinarias.TabIndex = 53;
            dtgvMaquinarias.CellClick += dtgvMaquinarias_CellClick;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(637, 42);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 55;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(601, 45);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(22, 20);
            label1.TabIndex = 54;
            label1.Text = "id";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 20);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(111, 20);
            label6.TabIndex = 32;
            label6.Text = "Fecha de inicio:";
            // 
            // dtInicio
            // 
            dtInicio.Location = new Point(26, 42);
            dtInicio.Margin = new Padding(2);
            dtInicio.Name = "dtInicio";
            dtInicio.Size = new Size(248, 27);
            dtInicio.TabIndex = 33;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(326, 20);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(92, 20);
            label5.TabIndex = 36;
            label5.Text = "Fecha de fin:";
            // 
            // dtFin
            // 
            dtFin.Location = new Point(326, 42);
            dtFin.Margin = new Padding(2);
            dtFin.Name = "dtFin";
            dtFin.Size = new Size(248, 27);
            dtFin.TabIndex = 37;
            // 
            // idMaquinaria
            // 
            idMaquinaria.HeaderText = "idMaquinaria";
            idMaquinaria.MinimumWidth = 6;
            idMaquinaria.Name = "idMaquinaria";
            idMaquinaria.Width = 125;
            // 
            // nombre
            // 
            nombre.HeaderText = "nombre";
            nombre.MinimumWidth = 6;
            nombre.Name = "nombre";
            nombre.Width = 125;
            // 
            // fechaInicio
            // 
            fechaInicio.HeaderText = "fechaInicio";
            fechaInicio.MinimumWidth = 6;
            fechaInicio.Name = "fechaInicio";
            fechaInicio.Width = 125;
            // 
            // fechaFin
            // 
            fechaFin.HeaderText = "fechaFin";
            fechaFin.MinimumWidth = 6;
            fechaFin.Name = "fechaFin";
            fechaFin.Width = 125;
            // 
            // cantidad
            // 
            cantidad.HeaderText = "cantidad";
            cantidad.MinimumWidth = 6;
            cantidad.Name = "cantidad";
            cantidad.Width = 125;
            // 
            // operador
            // 
            operador.HeaderText = "operador";
            operador.MinimumWidth = 6;
            operador.Name = "operador";
            operador.Width = 125;
            // 
            // AlquilerMaqReq
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1169, 397);
            Controls.Add(txtId);
            Controls.Add(label1);
            Controls.Add(dtgvMaquinarias);
            Controls.Add(txtCantidad);
            Controls.Add(cbkEstadoOperador);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(label13);
            Controls.Add(cbMaquinaria);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(dtFin);
            Controls.Add(label5);
            Controls.Add(dtInicio);
            Controls.Add(label6);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AlquilerMaqReq";
            Text = "AlquilerMaqReq";
            ((System.ComponentModel.ISupportInitialize)dtgvMaquinarias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEliminar;
        private Button btnModificar;
        private Button btnAgregar;
        private ComboBox comboBox3;
        private Label label13;
        private ComboBox cbMaquinaria;
        private Label label11;
        private Label label10;
        private CheckBox cbkEstadoOperador;
        private TextBox txtCantidad;
        private DataGridView dtgvMaquinarias;
        private TextBox txtId;
        private Label label1;
        private Label label6;
        private DateTimePicker dtInicio;
        private Label label5;
        private DateTimePicker dtFin;
        private DataGridViewTextBoxColumn idMaquinaria;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn fechaInicio;
        private DataGridViewTextBoxColumn fechaFin;
        private DataGridViewTextBoxColumn cantidad;
        private DataGridViewTextBoxColumn operador;
    }
}