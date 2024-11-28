namespace CapaPresentacion.Mantenimiento_Forms
{
    partial class Motivo
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
            dtPickerMotivo = new DateTimePicker();
            label4 = new Label();
            cbPrioridadMotivo = new ComboBox();
            txtDuracionMotivo = new TextBox();
            btnCancelarMotivo = new Button();
            btnModificarMotivo = new Button();
            btnAgregarMotivo = new Button();
            txtDescripcionMotivo = new TextBox();
            label6 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnSalirMotivo = new Button();
            btnDesahabilitarMotivo = new Button();
            btnNuevoMotivo = new Button();
            dgvMotivo = new DataGridView();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMotivo).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtPickerMotivo);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(cbPrioridadMotivo);
            groupBox1.Controls.Add(txtDuracionMotivo);
            groupBox1.Controls.Add(btnCancelarMotivo);
            groupBox1.Controls.Add(btnModificarMotivo);
            groupBox1.Controls.Add(btnAgregarMotivo);
            groupBox1.Controls.Add(txtDescripcionMotivo);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(26, 48);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(910, 271);
            groupBox1.TabIndex = 31;
            groupBox1.TabStop = false;
            groupBox1.Text = "Motivo";
            // 
            // dtPickerMotivo
            // 
            dtPickerMotivo.Location = new Point(449, 57);
            dtPickerMotivo.Name = "dtPickerMotivo";
            dtPickerMotivo.Size = new Size(199, 27);
            dtPickerMotivo.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(464, 32);
            label4.Name = "label4";
            label4.Size = new Size(162, 20);
            label4.TabIndex = 19;
            label4.Text = "Fecha de Identificacion";
            // 
            // cbPrioridadMotivo
            // 
            cbPrioridadMotivo.FormattingEnabled = true;
            cbPrioridadMotivo.Location = new Point(238, 60);
            cbPrioridadMotivo.Name = "cbPrioridadMotivo";
            cbPrioridadMotivo.Size = new Size(195, 28);
            cbPrioridadMotivo.TabIndex = 18;
            // 
            // txtDuracionMotivo
            // 
            txtDuracionMotivo.Location = new Point(19, 142);
            txtDuracionMotivo.Name = "txtDuracionMotivo";
            txtDuracionMotivo.Size = new Size(191, 27);
            txtDuracionMotivo.TabIndex = 17;
            // 
            // btnCancelarMotivo
            // 
            btnCancelarMotivo.Location = new Point(704, 154);
            btnCancelarMotivo.Name = "btnCancelarMotivo";
            btnCancelarMotivo.Size = new Size(188, 38);
            btnCancelarMotivo.TabIndex = 15;
            btnCancelarMotivo.Text = "Cancelar";
            btnCancelarMotivo.UseVisualStyleBackColor = true;
            // 
            // btnModificarMotivo
            // 
            btnModificarMotivo.Location = new Point(707, 91);
            btnModificarMotivo.Name = "btnModificarMotivo";
            btnModificarMotivo.Size = new Size(185, 38);
            btnModificarMotivo.TabIndex = 14;
            btnModificarMotivo.Text = "Modificar";
            btnModificarMotivo.UseVisualStyleBackColor = true;
            // 
            // btnAgregarMotivo
            // 
            btnAgregarMotivo.Location = new Point(704, 32);
            btnAgregarMotivo.Name = "btnAgregarMotivo";
            btnAgregarMotivo.Size = new Size(188, 38);
            btnAgregarMotivo.TabIndex = 13;
            btnAgregarMotivo.Text = "Agregar ";
            btnAgregarMotivo.UseVisualStyleBackColor = true;
            // 
            // txtDescripcionMotivo
            // 
            txtDescripcionMotivo.Location = new Point(20, 65);
            txtDescripcionMotivo.Name = "txtDescripcionMotivo";
            txtDescripcionMotivo.Size = new Size(191, 27);
            txtDescripcionMotivo.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(34, 109);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 5;
            label6.Text = "Duracion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(253, 32);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 2;
            label3.Text = "Prioridad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 32);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 1;
            label2.Text = "Descripcion";
            // 
            // btnSalirMotivo
            // 
            btnSalirMotivo.Location = new Point(667, 514);
            btnSalirMotivo.Name = "btnSalirMotivo";
            btnSalirMotivo.Size = new Size(143, 54);
            btnSalirMotivo.TabIndex = 30;
            btnSalirMotivo.Text = "Salir";
            btnSalirMotivo.UseVisualStyleBackColor = true;
            // 
            // btnDesahabilitarMotivo
            // 
            btnDesahabilitarMotivo.Location = new Point(667, 442);
            btnDesahabilitarMotivo.Name = "btnDesahabilitarMotivo";
            btnDesahabilitarMotivo.Size = new Size(143, 50);
            btnDesahabilitarMotivo.TabIndex = 29;
            btnDesahabilitarMotivo.Text = "Desahabilitar";
            btnDesahabilitarMotivo.UseVisualStyleBackColor = true;
            // 
            // btnNuevoMotivo
            // 
            btnNuevoMotivo.Location = new Point(667, 368);
            btnNuevoMotivo.Name = "btnNuevoMotivo";
            btnNuevoMotivo.Size = new Size(143, 47);
            btnNuevoMotivo.TabIndex = 28;
            btnNuevoMotivo.Text = "Nuevo";
            btnNuevoMotivo.UseVisualStyleBackColor = true;
            // 
            // dgvMotivo
            // 
            dgvMotivo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMotivo.Location = new Point(26, 338);
            dgvMotivo.Name = "dgvMotivo";
            dgvMotivo.RowHeadersWidth = 51;
            dgvMotivo.Size = new Size(590, 230);
            dgvMotivo.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(367, 9);
            label1.Name = "label1";
            label1.Size = new Size(186, 20);
            label1.TabIndex = 26;
            label1.Text = "Agregar Motivo Correctivo";
            // 
            // Motivo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(961, 614);
            Controls.Add(groupBox1);
            Controls.Add(btnSalirMotivo);
            Controls.Add(btnDesahabilitarMotivo);
            Controls.Add(btnNuevoMotivo);
            Controls.Add(dgvMotivo);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Motivo";
            Text = "Motivo";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMotivo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private DateTimePicker dtPickerMotivo;
        private Label label4;
        private ComboBox cbPrioridadMotivo;
        private TextBox txtDuracionMotivo;
        private Button btnCancelarMotivo;
        private Button btnModificarMotivo;
        private Button btnAgregarMotivo;
        private TextBox txtDescripcionMotivo;
        private Label label6;
        private Label label3;
        private Label label2;
        private Button btnSalirMotivo;
        private Button btnDesahabilitarMotivo;
        private Button btnNuevoMotivo;
        private DataGridView dgvMotivo;
        private Label label1;
    }
}