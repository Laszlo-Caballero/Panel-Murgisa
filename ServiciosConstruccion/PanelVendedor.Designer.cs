﻿namespace Capa_Presentacion
{
    partial class PanelVendedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelVendedor));
            BarraTitulo = new Panel();
            btnResturar = new PictureBox();
            btnMinimizar = new PictureBox();
            btnMaximizar = new PictureBox();
            btnCerrar = new PictureBox();
            MenuVertical = new Panel();
            panel8 = new Panel();
            btnOSManPreventivo = new Button();
            panel7 = new Panel();
            btnOManCorrectivo = new Button();
            panel6 = new Panel();
            btnFormaDePago = new Button();
            panel5 = new Panel();
            btnPagos = new Button();
            panel4 = new Panel();
            btnPago = new Button();
            panel3 = new Panel();
            btnServicio = new Button();
            panel2 = new Panel();
            btnCliente = new Button();
            panel1 = new Panel();
            btnVenta = new Button();
            pictureBox1 = new PictureBox();
            PanelContenedor = new Panel();
            BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnResturar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BarraTitulo
            // 
            BarraTitulo.BackColor = Color.FromArgb(0, 80, 200);
            BarraTitulo.Controls.Add(btnResturar);
            BarraTitulo.Controls.Add(btnMinimizar);
            BarraTitulo.Controls.Add(btnMaximizar);
            BarraTitulo.Controls.Add(btnCerrar);
            BarraTitulo.Dock = DockStyle.Top;
            BarraTitulo.Location = new Point(0, 0);
            BarraTitulo.Name = "BarraTitulo";
            BarraTitulo.Size = new Size(1353, 38);
            BarraTitulo.TabIndex = 0;
            BarraTitulo.Paint += BarraTitulo_Paint;
            BarraTitulo.MouseDown += BarraTitulo_MouseDown;
            // 
            // btnResturar
            // 
            btnResturar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnResturar.BackgroundImageLayout = ImageLayout.Zoom;
            btnResturar.Cursor = Cursors.Hand;
            btnResturar.Location = new Point(1285, 4);
            btnResturar.Name = "btnResturar";
            btnResturar.Size = new Size(25, 25);
            btnResturar.SizeMode = PictureBoxSizeMode.StretchImage;
            btnResturar.TabIndex = 3;
            btnResturar.TabStop = false;
            btnResturar.Visible = false;
            btnResturar.Click += btnResturar_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizar.BackgroundImageLayout = ImageLayout.Zoom;
            btnMinimizar.Cursor = Cursors.Hand;
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(1254, 3);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(25, 25);
            btnMinimizar.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMinimizar.TabIndex = 2;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnMaximizar
            // 
            btnMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximizar.BackgroundImageLayout = ImageLayout.Zoom;
            btnMaximizar.Cursor = Cursors.Hand;
            btnMaximizar.Image = (Image)resources.GetObject("btnMaximizar.Image");
            btnMaximizar.Location = new Point(1285, 4);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(25, 25);
            btnMaximizar.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMaximizar.TabIndex = 1;
            btnMaximizar.TabStop = false;
            btnMaximizar.Click += btnMaximizar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.BackgroundImageLayout = ImageLayout.Zoom;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(1316, 4);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(25, 25);
            btnCerrar.SizeMode = PictureBoxSizeMode.StretchImage;
            btnCerrar.TabIndex = 0;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // MenuVertical
            // 
            MenuVertical.BackColor = Color.FromArgb(26, 32, 40);
            MenuVertical.Controls.Add(panel8);
            MenuVertical.Controls.Add(btnOSManPreventivo);
            MenuVertical.Controls.Add(panel7);
            MenuVertical.Controls.Add(btnOManCorrectivo);
            MenuVertical.Controls.Add(panel6);
            MenuVertical.Controls.Add(btnFormaDePago);
            MenuVertical.Controls.Add(panel5);
            MenuVertical.Controls.Add(btnPagos);
            MenuVertical.Controls.Add(panel4);
            MenuVertical.Controls.Add(btnPago);
            MenuVertical.Controls.Add(panel3);
            MenuVertical.Controls.Add(btnServicio);
            MenuVertical.Controls.Add(panel2);
            MenuVertical.Controls.Add(btnCliente);
            MenuVertical.Controls.Add(panel1);
            MenuVertical.Controls.Add(btnVenta);
            MenuVertical.Controls.Add(pictureBox1);
            MenuVertical.Dock = DockStyle.Left;
            MenuVertical.Location = new Point(0, 38);
            MenuVertical.Name = "MenuVertical";
            MenuVertical.Size = new Size(200, 614);
            MenuVertical.TabIndex = 1;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(0, 80, 200);
            panel8.Location = new Point(0, 354);
            panel8.Name = "panel8";
            panel8.Size = new Size(5, 32);
            panel8.TabIndex = 11;
            // 
            // btnOSManPreventivo
            // 
            btnOSManPreventivo.BackColor = Color.FromArgb(26, 32, 40);
            btnOSManPreventivo.FlatAppearance.BorderSize = 0;
            btnOSManPreventivo.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnOSManPreventivo.FlatStyle = FlatStyle.Flat;
            btnOSManPreventivo.ForeColor = SystemColors.ButtonFace;
            btnOSManPreventivo.ImageAlign = ContentAlignment.MiddleLeft;
            btnOSManPreventivo.Location = new Point(1, 354);
            btnOSManPreventivo.Name = "btnOSManPreventivo";
            btnOSManPreventivo.RightToLeft = RightToLeft.No;
            btnOSManPreventivo.Size = new Size(197, 32);
            btnOSManPreventivo.TabIndex = 12;
            btnOSManPreventivo.Text = "OS Mantenimiendo Preventivo";
            btnOSManPreventivo.UseVisualStyleBackColor = false;
            btnOSManPreventivo.Click += btnOManPreventivo_Click;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(0, 80, 200);
            panel7.Location = new Point(0, 316);
            panel7.Name = "panel7";
            panel7.Size = new Size(5, 32);
            panel7.TabIndex = 9;
            // 
            // btnOManCorrectivo
            // 
            btnOManCorrectivo.BackColor = Color.FromArgb(26, 32, 40);
            btnOManCorrectivo.FlatAppearance.BorderSize = 0;
            btnOManCorrectivo.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnOManCorrectivo.FlatStyle = FlatStyle.Flat;
            btnOManCorrectivo.ForeColor = SystemColors.ButtonFace;
            btnOManCorrectivo.ImageAlign = ContentAlignment.MiddleLeft;
            btnOManCorrectivo.Location = new Point(1, 316);
            btnOManCorrectivo.Name = "btnOManCorrectivo";
            btnOManCorrectivo.RightToLeft = RightToLeft.No;
            btnOManCorrectivo.Size = new Size(197, 32);
            btnOManCorrectivo.TabIndex = 10;
            btnOManCorrectivo.Text = "OS Mantenimiendo Correctivo";
            btnOManCorrectivo.UseVisualStyleBackColor = false;
            btnOManCorrectivo.Click += btnOManCorrectivo_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(0, 80, 200);
            panel6.Location = new Point(0, 278);
            panel6.Name = "panel6";
            panel6.Size = new Size(5, 32);
            panel6.TabIndex = 7;
            // 
            // btnFormaDePago
            // 
            btnFormaDePago.BackColor = Color.FromArgb(26, 32, 40);
            btnFormaDePago.FlatAppearance.BorderSize = 0;
            btnFormaDePago.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnFormaDePago.FlatStyle = FlatStyle.Flat;
            btnFormaDePago.ForeColor = SystemColors.ButtonFace;
            btnFormaDePago.ImageAlign = ContentAlignment.MiddleLeft;
            btnFormaDePago.Location = new Point(1, 278);
            btnFormaDePago.Name = "btnFormaDePago";
            btnFormaDePago.RightToLeft = RightToLeft.No;
            btnFormaDePago.Size = new Size(197, 32);
            btnFormaDePago.TabIndex = 8;
            btnFormaDePago.Text = "Forma de pago";
            btnFormaDePago.UseVisualStyleBackColor = false;
            btnFormaDePago.Click += btnFormaDePago_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(0, 80, 200);
            panel5.Location = new Point(0, 241);
            panel5.Name = "panel5";
            panel5.Size = new Size(5, 32);
            panel5.TabIndex = 6;
            // 
            // btnPagos
            // 
            btnPagos.BackColor = Color.FromArgb(26, 32, 40);
            btnPagos.FlatAppearance.BorderSize = 0;
            btnPagos.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnPagos.FlatStyle = FlatStyle.Flat;
            btnPagos.ForeColor = SystemColors.ButtonFace;
            btnPagos.ImageAlign = ContentAlignment.MiddleLeft;
            btnPagos.Location = new Point(0, 241);
            btnPagos.Name = "btnPagos";
            btnPagos.RightToLeft = RightToLeft.No;
            btnPagos.Size = new Size(197, 32);
            btnPagos.TabIndex = 7;
            btnPagos.Text = "Pagos";
            btnPagos.UseVisualStyleBackColor = false;
            btnPagos.Click += btnPagos_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 80, 200);
            panel4.Location = new Point(0, 203);
            panel4.Name = "panel4";
            panel4.Size = new Size(5, 32);
            panel4.TabIndex = 4;
            // 
            // btnPago
            // 
            btnPago.BackColor = Color.FromArgb(26, 32, 40);
            btnPago.FlatAppearance.BorderSize = 0;
            btnPago.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnPago.FlatStyle = FlatStyle.Flat;
            btnPago.ForeColor = SystemColors.ButtonFace;
            btnPago.ImageAlign = ContentAlignment.MiddleLeft;
            btnPago.Location = new Point(1, 203);
            btnPago.Name = "btnPago";
            btnPago.RightToLeft = RightToLeft.No;
            btnPago.Size = new Size(197, 32);
            btnPago.TabIndex = 5;
            btnPago.Text = "Servicios";
            btnPago.UseVisualStyleBackColor = false;
            btnPago.Click += btnServicios_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 80, 200);
            panel3.Location = new Point(0, 165);
            panel3.Name = "panel3";
            panel3.Size = new Size(5, 32);
            panel3.TabIndex = 2;
            // 
            // btnServicio
            // 
            btnServicio.BackColor = Color.FromArgb(26, 32, 40);
            btnServicio.FlatAppearance.BorderSize = 0;
            btnServicio.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnServicio.FlatStyle = FlatStyle.Flat;
            btnServicio.ForeColor = SystemColors.ButtonFace;
            btnServicio.ImageAlign = ContentAlignment.MiddleLeft;
            btnServicio.Location = new Point(0, 165);
            btnServicio.Name = "btnServicio";
            btnServicio.RightToLeft = RightToLeft.No;
            btnServicio.Size = new Size(197, 32);
            btnServicio.TabIndex = 3;
            btnServicio.Text = "Ventas";
            btnServicio.UseVisualStyleBackColor = false;
            btnServicio.Click += btnVentas_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 80, 200);
            panel2.Location = new Point(0, 127);
            panel2.Name = "panel2";
            panel2.Size = new Size(5, 32);
            panel2.TabIndex = 1;
            // 
            // btnCliente
            // 
            btnCliente.BackColor = Color.FromArgb(26, 32, 40);
            btnCliente.FlatAppearance.BorderSize = 0;
            btnCliente.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnCliente.FlatStyle = FlatStyle.Flat;
            btnCliente.ForeColor = SystemColors.ButtonFace;
            btnCliente.ImageAlign = ContentAlignment.MiddleLeft;
            btnCliente.Location = new Point(0, 127);
            btnCliente.Name = "btnCliente";
            btnCliente.RightToLeft = RightToLeft.No;
            btnCliente.Size = new Size(197, 32);
            btnCliente.TabIndex = 1;
            btnCliente.Text = "Clientes";
            btnCliente.UseVisualStyleBackColor = false;
            btnCliente.Click += btnCliente_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 80, 200);
            panel1.Location = new Point(0, 89);
            panel1.Name = "panel1";
            panel1.Size = new Size(5, 32);
            panel1.TabIndex = 0;
            // 
            // btnVenta
            // 
            btnVenta.BackColor = Color.FromArgb(26, 32, 40);
            btnVenta.Cursor = Cursors.Hand;
            btnVenta.FlatAppearance.BorderSize = 0;
            btnVenta.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnVenta.FlatStyle = FlatStyle.Flat;
            btnVenta.ForeColor = SystemColors.ButtonFace;
            btnVenta.ImageAlign = ContentAlignment.MiddleLeft;
            btnVenta.Location = new Point(3, 89);
            btnVenta.Name = "btnVenta";
            btnVenta.RightToLeft = RightToLeft.No;
            btnVenta.Size = new Size(197, 32);
            btnVenta.TabIndex = 0;
            btnVenta.Text = "Realizar Venta";
            btnVenta.UseVisualStyleBackColor = false;
            btnVenta.Click += btnVenta_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 69);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // PanelContenedor
            // 
            PanelContenedor.BackColor = Color.FromArgb(49, 66, 82);
            PanelContenedor.Dock = DockStyle.Fill;
            PanelContenedor.Location = new Point(200, 38);
            PanelContenedor.Name = "PanelContenedor";
            PanelContenedor.Size = new Size(1153, 614);
            PanelContenedor.TabIndex = 2;
            // 
            // PanelVendedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1353, 652);
            Controls.Add(PanelContenedor);
            Controls.Add(MenuVertical);
            Controls.Add(BarraTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PanelVendedor";
            Text = "RealizarVenta";
            BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnResturar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            MenuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel BarraTitulo;
        private PictureBox btnCerrar;
        private Panel MenuVertical;
        private Panel PanelContenedor;
        private PictureBox btnResturar;
        private PictureBox btnMinimizar;
        private PictureBox btnMaximizar;
        private Button btnVenta;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel4;
        private Button btnPago;
        private Panel panel3;
        private Button btnServicio;
        private Panel panel2;
        private Button btnCliente;
        private Panel panel5;
        private Button btnPagos;
        private Panel panel6;
        private Button btnFormaDePago;
        private Panel panel8;
        private Button btnOSManPreventivo;
        private Panel panel7;
        private Button btnOManCorrectivo;
    }
}