namespace CapaPresentacion.Mantenimiento_Forms
{
    partial class TipoMantenimiento
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
            groupBox1 = new GroupBox();
            txtDuracion = new TextBox();
            txtDescripcionTipo = new TextBox();
            btnCancelarTm = new Button();
            btnModificarTm = new Button();
            btnAgregarTm = new Button();
            txtCostoMantenimiento = new TextBox();
            txtIdMantenimiento = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnSalirTm = new Button();
            btnDesahabilitarTm = new Button();
            btnNuevoTm = new Button();
            dgvTipoMantenimiento = new DataGridView();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTipoMantenimiento).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtDuracion);
            groupBox1.Controls.Add(txtDescripcionTipo);
            groupBox1.Controls.Add(btnCancelarTm);
            groupBox1.Controls.Add(btnModificarTm);
            groupBox1.Controls.Add(btnAgregarTm);
            groupBox1.Controls.Add(txtCostoMantenimiento);
            groupBox1.Controls.Add(txtIdMantenimiento);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(28, 60);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(910, 271);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            groupBox1.Text = "Mantenimiento";
            // 
            // txtDuracion
            // 
            txtDuracion.Location = new Point(476, 65);
            txtDuracion.Name = "txtDuracion";
            txtDuracion.Size = new Size(191, 27);
            txtDuracion.TabIndex = 17;
            // 
            // txtDescripcionTipo
            // 
            txtDescripcionTipo.Location = new Point(252, 65);
            txtDescripcionTipo.Name = "txtDescripcionTipo";
            txtDescripcionTipo.Size = new Size(191, 27);
            txtDescripcionTipo.TabIndex = 16;
            // 
            // btnCancelarTm
            // 
            btnCancelarTm.Location = new Point(704, 154);
            btnCancelarTm.Name = "btnCancelarTm";
            btnCancelarTm.Size = new Size(188, 38);
            btnCancelarTm.TabIndex = 15;
            btnCancelarTm.Text = "Cancelar";
            btnCancelarTm.UseVisualStyleBackColor = true;
            // 
            // btnModificarTm
            // 
            btnModificarTm.Location = new Point(707, 91);
            btnModificarTm.Name = "btnModificarTm";
            btnModificarTm.Size = new Size(185, 38);
            btnModificarTm.TabIndex = 14;
            btnModificarTm.Text = "Modificar";
            btnModificarTm.UseVisualStyleBackColor = true;
            // 
            // btnAgregarTm
            // 
            btnAgregarTm.Location = new Point(704, 32);
            btnAgregarTm.Name = "btnAgregarTm";
            btnAgregarTm.Size = new Size(188, 38);
            btnAgregarTm.TabIndex = 13;
            btnAgregarTm.Text = "Agregar ";
            btnAgregarTm.UseVisualStyleBackColor = true;
            // 
            // txtCostoMantenimiento
            // 
            txtCostoMantenimiento.Location = new Point(20, 165);
            txtCostoMantenimiento.Name = "txtCostoMantenimiento";
            txtCostoMantenimiento.Size = new Size(191, 27);
            txtCostoMantenimiento.TabIndex = 8;
            // 
            // txtIdMantenimiento
            // 
            txtIdMantenimiento.Location = new Point(20, 65);
            txtIdMantenimiento.Name = "txtIdMantenimiento";
            txtIdMantenimiento.Size = new Size(191, 27);
            txtIdMantenimiento.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(491, 32);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 5;
            label6.Text = "Duracion";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 124);
            label5.Name = "label5";
            label5.Size = new Size(51, 20);
            label5.TabIndex = 4;
            label5.Text = "Costo ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(253, 32);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 2;
            label3.Text = "Descripcion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 32);
            label2.Name = "label2";
            label2.Size = new Size(129, 20);
            label2.TabIndex = 1;
            label2.Text = "ID Mantenimiento";
            // 
            // btnSalirTm
            // 
            btnSalirTm.Location = new Point(669, 509);
            btnSalirTm.Name = "btnSalirTm";
            btnSalirTm.Size = new Size(143, 48);
            btnSalirTm.TabIndex = 24;
            btnSalirTm.Text = "Salir";
            btnSalirTm.UseVisualStyleBackColor = true;
            // 
            // btnDesahabilitarTm
            // 
            btnDesahabilitarTm.Location = new Point(669, 438);
            btnDesahabilitarTm.Name = "btnDesahabilitarTm";
            btnDesahabilitarTm.Size = new Size(143, 49);
            btnDesahabilitarTm.TabIndex = 23;
            btnDesahabilitarTm.Text = "Desahabilitar";
            btnDesahabilitarTm.UseVisualStyleBackColor = true;
            // 
            // btnNuevoTm
            // 
            btnNuevoTm.Location = new Point(669, 363);
            btnNuevoTm.Name = "btnNuevoTm";
            btnNuevoTm.Size = new Size(143, 52);
            btnNuevoTm.TabIndex = 22;
            btnNuevoTm.Text = "Nuevo";
            btnNuevoTm.UseVisualStyleBackColor = true;
            // 
            // dgvTipoMantenimiento
            // 
            dgvTipoMantenimiento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTipoMantenimiento.Location = new Point(28, 350);
            dgvTipoMantenimiento.Name = "dgvTipoMantenimiento";
            dgvTipoMantenimiento.RowHeadersWidth = 51;
            dgvTipoMantenimiento.Size = new Size(590, 230);
            dgvTipoMantenimiento.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(369, 21);
            label1.Name = "label1";
            label1.Size = new Size(202, 20);
            label1.TabIndex = 20;
            label1.Text = "Agregar Tipo Mantenimiento";
            // 
            // TipoMantenimiento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 649);
            Controls.Add(groupBox1);
            Controls.Add(btnSalirTm);
            Controls.Add(btnDesahabilitarTm);
            Controls.Add(btnNuevoTm);
            Controls.Add(dgvTipoMantenimiento);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TipoMantenimiento";
            Text = "Equipo";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTipoMantenimiento).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnCancelarTm;
        private Button btnModificarTm;
        private Button btnAgregarTm;
        private TextBox txtCostoMantenimiento;
        private TextBox txtIdMantenimiento;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label2;
        private Button btnSalirTm;
        private Button btnDesahabilitarTm;
        private Button btnNuevoTm;
        private DataGridView dgvTipoMantenimiento;
        private Label label1;
        private TextBox txtDescripcionTipo;
        private TextBox txtDuracion;
    }
}