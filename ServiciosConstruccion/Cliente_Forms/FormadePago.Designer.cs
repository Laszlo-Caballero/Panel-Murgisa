namespace CapaPresentacion
{
    partial class FormadePago
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
            dgForma = new DataGridView();
            groupBox1 = new GroupBox();
            txtFormaPago = new TextBox();
            label3 = new Label();
            txtId = new TextBox();
            btnDeshabilitar = new Button();
            btnAgregar = new Button();
            cbkForma = new CheckBox();
            label7 = new Label();
            label2 = new Label();
            btnActualizar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgForma).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(378, 31);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(224, 41);
            label1.TabIndex = 16;
            label1.Text = "Forma de Pago";
            // 
            // dgForma
            // 
            dgForma.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgForma.Location = new Point(68, 308);
            dgForma.Margin = new Padding(2);
            dgForma.Name = "dgForma";
            dgForma.RowHeadersWidth = 82;
            dgForma.Size = new Size(897, 249);
            dgForma.TabIndex = 18;
            dgForma.CellClick += dgForma_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnActualizar);
            groupBox1.Controls.Add(txtFormaPago);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(btnDeshabilitar);
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Controls.Add(cbkForma);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(57, 81);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(908, 192);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Forma de Pago";
            // 
            // txtFormaPago
            // 
            txtFormaPago.Location = new Point(217, 89);
            txtFormaPago.Margin = new Padding(2);
            txtFormaPago.Name = "txtFormaPago";
            txtFormaPago.Size = new Size(201, 27);
            txtFormaPago.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 91);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(165, 20);
            label3.TabIndex = 13;
            label3.Text = "Tipo de forma de Pago:";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(217, 39);
            txtId.Margin = new Padding(2);
            txtId.Name = "txtId";
            txtId.Size = new Size(201, 27);
            txtId.TabIndex = 12;
            // 
            // btnDeshabilitar
            // 
            btnDeshabilitar.Location = new Point(765, 86);
            btnDeshabilitar.Margin = new Padding(2);
            btnDeshabilitar.Name = "btnDeshabilitar";
            btnDeshabilitar.Size = new Size(97, 29);
            btnDeshabilitar.TabIndex = 10;
            btnDeshabilitar.Text = "Deshabilitar";
            btnDeshabilitar.UseVisualStyleBackColor = true;
            btnDeshabilitar.Click += btnDeshabilitar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(765, 41);
            btnAgregar.Margin = new Padding(2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(97, 29);
            btnAgregar.TabIndex = 9;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // cbkForma
            // 
            cbkForma.AutoSize = true;
            cbkForma.Location = new Point(17, 148);
            cbkForma.Margin = new Padding(2);
            cbkForma.Name = "cbkForma";
            cbkForma.Size = new Size(217, 24);
            cbkForma.TabIndex = 6;
            cbkForma.Text = "Estado de la forma de pago";
            cbkForma.UseVisualStyleBackColor = true;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 41);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(112, 20);
            label2.TabIndex = 0;
            label2.Text = "Forma de Pago:";
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(765, 128);
            btnActualizar.Margin = new Padding(2);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(97, 29);
            btnActualizar.TabIndex = 15;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // FormadePago
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1022, 609);
            Controls.Add(dgForma);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "FormadePago";
            Text = "btnFormadePago";
            ((System.ComponentModel.ISupportInitialize)dgForma).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button6;
        private Button button5;
        private Button button4;
        private DataGridView dgForma;
        private GroupBox groupBox1;
        private TextBox txtId;
        private Button btnAgregar;
        private Button btnDeshabilitar;
        private CheckBox cbkForma;
        private Label label7;
        private Label label2;
        private TextBox txtFormaPago;
        private Label label3;
        private Button btnActualizar;
    }
}