namespace CapaPresentacion.Servicios_Forms
{
    partial class RealizarOrdenDeServicio
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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(558, 35);
            label1.Name = "label1";
            label1.Size = new Size(420, 65);
            label1.TabIndex = 16;
            label1.Text = "Orden de Servicio";
            // 
            // RealizarOrdenDeServicio
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1617, 888);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RealizarOrdenDeServicio";
            Text = "RealizarOrdenDeServicio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
    }
}