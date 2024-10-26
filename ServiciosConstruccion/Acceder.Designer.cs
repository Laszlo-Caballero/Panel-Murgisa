namespace Capa_Presentacion
{
    partial class Acceder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Acceder));
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            cbSistemas = new ComboBox();
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            btnAcceder = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 288);
            label1.Name = "label1";
            label1.Size = new Size(46, 23);
            label1.TabIndex = 0;
            label1.Text = "Rol:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 344);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(122, 33);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(152, 177);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(24, 379);
            label3.Name = "label3";
            label3.Size = new Size(82, 23);
            label3.TabIndex = 4;
            label3.Text = "Usuario:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(24, 468);
            label4.Name = "label4";
            label4.Size = new Size(115, 23);
            label4.TabIndex = 5;
            label4.Text = "Contraseña:";
            // 
            // cbSistemas
            // 
            cbSistemas.FormattingEnabled = true;
            cbSistemas.Items.AddRange(new object[] { "Vendedor", "Jefe de Servicio", "Jefe de Mantenimiento" });
            cbSistemas.Location = new Point(155, 288);
            cbSistemas.Margin = new Padding(3, 4, 3, 4);
            cbSistemas.Name = "cbSistemas";
            cbSistemas.Size = new Size(221, 28);
            cbSistemas.TabIndex = 6;
            cbSistemas.SelectedIndexChanged += cbSistemas_SelectedIndexChanged;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(155, 373);
            txtUsuario.Margin = new Padding(3, 4, 3, 4);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(221, 27);
            txtUsuario.TabIndex = 7;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(155, 463);
            txtContraseña.Margin = new Padding(3, 4, 3, 4);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(221, 27);
            txtContraseña.TabIndex = 8;
            // 
            // btnAcceder
            // 
            btnAcceder.Font = new Font("Snap ITC", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAcceder.Location = new Point(122, 548);
            btnAcceder.Margin = new Padding(3, 4, 3, 4);
            btnAcceder.Name = "btnAcceder";
            btnAcceder.Size = new Size(165, 65);
            btnAcceder.TabIndex = 9;
            btnAcceder.Text = "Acceder";
            btnAcceder.UseVisualStyleBackColor = true;
            btnAcceder.Click += btnAcceder_Click;
            // 
            // Acceder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(403, 648);
            Controls.Add(btnAcceder);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(cbSistemas);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ActiveCaption;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Acceder";
            Text = "Acceder";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
        private ComboBox cbSistemas;
        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private Button btnAcceder;
    }
}