﻿namespace CapaPresentacion.Mantenimiento_Forms
{
    partial class PedidoMantenimientoCorrectivo
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
            dgvpedido = new DataGridView();
            txtRegistrar = new Button();
            txtDeshabilitar = new Button();
            cbMaquinaria = new ComboBox();
            label3 = new Label();
            dtpFecha = new DateTimePicker();
            checkBox1 = new CheckBox();
            label5 = new Label();
            txtPedido = new TextBox();
            listaDetalle = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            btnAñadir = new Button();
            label6 = new Label();
            cbMantenimiento = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvpedido).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(258, 243);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 0;
            label1.Text = "Maquinaria:";
            // 
            // dgvpedido
            // 
            dgvpedido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvpedido.Location = new Point(22, 12);
            dgvpedido.Name = "dgvpedido";
            dgvpedido.Size = new Size(450, 187);
            dgvpedido.TabIndex = 1;
            // 
            // txtRegistrar
            // 
            txtRegistrar.Location = new Point(562, 277);
            txtRegistrar.Name = "txtRegistrar";
            txtRegistrar.Size = new Size(104, 37);
            txtRegistrar.TabIndex = 2;
            txtRegistrar.Text = "REGISTRAR";
            txtRegistrar.UseVisualStyleBackColor = true;
            // 
            // txtDeshabilitar
            // 
            txtDeshabilitar.Location = new Point(697, 277);
            txtDeshabilitar.Name = "txtDeshabilitar";
            txtDeshabilitar.Size = new Size(104, 37);
            txtDeshabilitar.TabIndex = 3;
            txtDeshabilitar.Text = "DESHABILITAR";
            txtDeshabilitar.UseVisualStyleBackColor = true;
            // 
            // cbMaquinaria
            // 
            cbMaquinaria.FormattingEnabled = true;
            cbMaquinaria.Location = new Point(351, 240);
            cbMaquinaria.Name = "cbMaquinaria";
            cbMaquinaria.Size = new Size(121, 23);
            cbMaquinaria.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 288);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 7;
            label3.Text = "Fecha";
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(94, 284);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(209, 23);
            dtpFecha.TabIndex = 8;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(350, 286);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(61, 19);
            checkBox1.TabIndex = 11;
            checkBox1.Text = "Estado";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 243);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 12;
            label5.Text = "Pedido Id";
            // 
            // txtPedido
            // 
            txtPedido.Location = new Point(115, 240);
            txtPedido.Name = "txtPedido";
            txtPedido.Size = new Size(121, 23);
            txtPedido.TabIndex = 13;
            // 
            // listaDetalle
            // 
            listaDetalle.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listaDetalle.Location = new Point(515, 12);
            listaDetalle.Name = "listaDetalle";
            listaDetalle.Size = new Size(221, 187);
            listaDetalle.TabIndex = 15;
            listaDetalle.UseCompatibleStateImageBehavior = false;
            listaDetalle.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Mantenimiento";
            columnHeader2.Width = 150;
            // 
            // btnAñadir
            // 
            btnAñadir.Location = new Point(429, 277);
            btnAñadir.Name = "btnAñadir";
            btnAñadir.Size = new Size(101, 37);
            btnAñadir.TabIndex = 16;
            btnAñadir.Text = "AÑADIR";
            btnAñadir.UseVisualStyleBackColor = true;
            btnAñadir.Click += btnAñadir_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(525, 240);
            label6.Name = "label6";
            label6.Size = new Size(89, 15);
            label6.TabIndex = 17;
            label6.Text = "Mantenimiento";
            // 
            // cbMantenimiento
            // 
            cbMantenimiento.FormattingEnabled = true;
            cbMantenimiento.Location = new Point(633, 235);
            cbMantenimiento.Name = "cbMantenimiento";
            cbMantenimiento.Size = new Size(121, 23);
            cbMantenimiento.TabIndex = 18;
            // 
            // PedidoMantenimientoCorrectivo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(813, 390);
            Controls.Add(cbMantenimiento);
            Controls.Add(label6);
            Controls.Add(btnAñadir);
            Controls.Add(listaDetalle);
            Controls.Add(txtPedido);
            Controls.Add(label5);
            Controls.Add(checkBox1);
            Controls.Add(dtpFecha);
            Controls.Add(label3);
            Controls.Add(cbMaquinaria);
            Controls.Add(txtDeshabilitar);
            Controls.Add(txtRegistrar);
            Controls.Add(dgvpedido);
            Controls.Add(label1);
            Name = "PedidoMantenimientoCorrectivo";
            Text = "PedidoMantenimientoCorrectivo";
            ((System.ComponentModel.ISupportInitialize)dgvpedido).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvpedido;
        private Button txtRegistrar;
        private Button txtDeshabilitar;
        private ComboBox cbMaquinaria;
        private Label label3;
        private DateTimePicker dtpFecha;
        private CheckBox checkBox1;
        private Label label5;
        private TextBox txtPedido;
        private ListView listaDetalle;
        private Button btnAñadir;
        private Label label6;
        private ComboBox cbMantenimiento;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
    }
}