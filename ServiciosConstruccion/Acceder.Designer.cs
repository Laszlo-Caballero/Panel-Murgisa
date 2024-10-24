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
            label1.Location = new Point(21, 216);
            label1.Name = "label1";
            label1.Size = new Size(38, 19);
            label1.TabIndex = 0;
            label1.Text = "Rol:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 258);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(107, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(133, 133);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(21, 284);
            label3.Name = "label3";
            label3.Size = new Size(66, 19);
            label3.TabIndex = 4;
            label3.Text = "Usuario:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(21, 351);
            label4.Name = "label4";
            label4.Size = new Size(91, 19);
            label4.TabIndex = 5;
            label4.Text = "Contraseña:";
            // 
            // cbSistemas
            // 
            cbSistemas.FormattingEnabled = true;
            cbSistemas.Items.AddRange(new object[] { "Vendedor", "Jefe de Servicio", "Jefe de Mantenimiento", "Jefe de Almacén" });
            cbSistemas.Location = new Point(136, 216);
            cbSistemas.Name = "cbSistemas";
            cbSistemas.Size = new Size(194, 23);
            cbSistemas.TabIndex = 6;
            cbSistemas.SelectedIndexChanged += cbSistemas_SelectedIndexChanged;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(136, 280);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(194, 23);
            txtUsuario.TabIndex = 7;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(136, 347);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(194, 23);
            txtContraseña.TabIndex = 8;
            // 
            // btnAcceder
            // 
            btnAcceder.Font = new Font("Snap ITC", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAcceder.Location = new Point(107, 411);
            btnAcceder.Name = "btnAcceder";
            btnAcceder.Size = new Size(144, 49);
            btnAcceder.TabIndex = 9;
            btnAcceder.Text = "Acceder";
            btnAcceder.UseVisualStyleBackColor = true;
            btnAcceder.Click += btnAcceder_Click;
            // 
            // Acceder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(353, 486);
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