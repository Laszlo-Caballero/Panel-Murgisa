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
            BarraTitulo.Margin = new Padding(3, 4, 3, 4);
            BarraTitulo.Name = "BarraTitulo";
            BarraTitulo.Size = new Size(1546, 51);
            BarraTitulo.TabIndex = 0;
            BarraTitulo.Paint += BarraTitulo_Paint;
            BarraTitulo.MouseDown += BarraTitulo_MouseDown;
            // 
            // btnResturar
            // 
            btnResturar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnResturar.BackgroundImageLayout = ImageLayout.Zoom;
            btnResturar.Cursor = Cursors.Hand;
            btnResturar.Location = new Point(1469, 5);
            btnResturar.Margin = new Padding(3, 4, 3, 4);
            btnResturar.Name = "btnResturar";
            btnResturar.Size = new Size(29, 33);
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
            btnMinimizar.Location = new Point(1433, 4);
            btnMinimizar.Margin = new Padding(3, 4, 3, 4);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(29, 33);
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
            btnMaximizar.Location = new Point(1469, 5);
            btnMaximizar.Margin = new Padding(3, 4, 3, 4);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(29, 33);
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
            btnCerrar.Location = new Point(1504, 5);
            btnCerrar.Margin = new Padding(3, 4, 3, 4);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(29, 33);
            btnCerrar.SizeMode = PictureBoxSizeMode.StretchImage;
            btnCerrar.TabIndex = 0;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // MenuVertical
            // 
            MenuVertical.BackColor = Color.FromArgb(26, 32, 40);
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
            MenuVertical.Location = new Point(0, 51);
            MenuVertical.Margin = new Padding(3, 4, 3, 4);
            MenuVertical.Name = "MenuVertical";
            MenuVertical.Size = new Size(229, 818);
            MenuVertical.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(0, 80, 200);
            panel6.Location = new Point(0, 371);
            panel6.Margin = new Padding(3, 4, 3, 4);
            panel6.Name = "panel6";
            panel6.Size = new Size(6, 43);
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
            btnFormaDePago.Location = new Point(1, 371);
            btnFormaDePago.Margin = new Padding(3, 4, 3, 4);
            btnFormaDePago.Name = "btnFormaDePago";
            btnFormaDePago.RightToLeft = RightToLeft.No;
            btnFormaDePago.Size = new Size(225, 43);
            btnFormaDePago.TabIndex = 8;
            btnFormaDePago.Text = "Forma de pago";
            btnFormaDePago.UseVisualStyleBackColor = false;
            btnFormaDePago.Click += btnFormaDePago_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(0, 80, 200);
            panel5.Location = new Point(0, 321);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(6, 43);
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
            btnPagos.Location = new Point(0, 321);
            btnPagos.Margin = new Padding(3, 4, 3, 4);
            btnPagos.Name = "btnPagos";
            btnPagos.RightToLeft = RightToLeft.No;
            btnPagos.Size = new Size(225, 43);
            btnPagos.TabIndex = 7;
            btnPagos.Text = "Pagos";
            btnPagos.UseVisualStyleBackColor = false;
            btnPagos.Click += btnPagos_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 80, 200);
            panel4.Location = new Point(0, 271);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(6, 43);
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
            btnPago.Location = new Point(1, 271);
            btnPago.Margin = new Padding(3, 4, 3, 4);
            btnPago.Name = "btnPago";
            btnPago.RightToLeft = RightToLeft.No;
            btnPago.Size = new Size(225, 43);
            btnPago.TabIndex = 5;
            btnPago.Text = "Servicios";
            btnPago.UseVisualStyleBackColor = false;
            btnPago.Click += btnServicios_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 80, 200);
            panel3.Location = new Point(0, 220);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(6, 43);
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
            btnServicio.Location = new Point(0, 220);
            btnServicio.Margin = new Padding(3, 4, 3, 4);
            btnServicio.Name = "btnServicio";
            btnServicio.RightToLeft = RightToLeft.No;
            btnServicio.Size = new Size(225, 43);
            btnServicio.TabIndex = 3;
            btnServicio.Text = "Ventas";
            btnServicio.UseVisualStyleBackColor = false;
            btnServicio.Click += btnVentas_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 80, 200);
            panel2.Location = new Point(0, 169);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(6, 43);
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
            btnCliente.Location = new Point(0, 169);
            btnCliente.Margin = new Padding(3, 4, 3, 4);
            btnCliente.Name = "btnCliente";
            btnCliente.RightToLeft = RightToLeft.No;
            btnCliente.Size = new Size(225, 43);
            btnCliente.TabIndex = 1;
            btnCliente.Text = "Clientes";
            btnCliente.UseVisualStyleBackColor = false;
            btnCliente.Click += btnCliente_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 80, 200);
            panel1.Location = new Point(0, 119);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(6, 43);
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
            btnVenta.Location = new Point(3, 119);
            btnVenta.Margin = new Padding(3, 4, 3, 4);
            btnVenta.Name = "btnVenta";
            btnVenta.RightToLeft = RightToLeft.No;
            btnVenta.Size = new Size(225, 43);
            btnVenta.TabIndex = 0;
            btnVenta.Text = "Realizar Venta";
            btnVenta.UseVisualStyleBackColor = false;
            btnVenta.Click += btnVenta_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(229, 92);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // PanelContenedor
            // 
            PanelContenedor.BackColor = Color.FromArgb(49, 66, 82);
            PanelContenedor.Dock = DockStyle.Fill;
            PanelContenedor.Location = new Point(229, 51);
            PanelContenedor.Margin = new Padding(3, 4, 3, 4);
            PanelContenedor.Name = "PanelContenedor";
            PanelContenedor.Size = new Size(1317, 818);
            PanelContenedor.TabIndex = 2;
            // 
            // PanelVendedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1546, 869);
            Controls.Add(PanelContenedor);
            Controls.Add(MenuVertical);
            Controls.Add(BarraTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
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
    }
}