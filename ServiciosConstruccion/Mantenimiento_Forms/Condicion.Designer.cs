namespace CapaPresentacion.Mantenimiento_Forms
{
    partial class Condicion
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
            dgvCondicion = new DataGridView();
            txtIdCondicion = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtCondicion = new TextBox();
            cbEstado = new CheckBox();
            btnAgregar = new Button();
            btnEditar = new Button();
            btnDeshabilitar = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCondicion).BeginInit();
            SuspendLayout();
            // 
            // dgvCondicion
            // 
            dgvCondicion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCondicion.Location = new Point(31, 232);
            dgvCondicion.Margin = new Padding(3, 4, 3, 4);
            dgvCondicion.Name = "dgvCondicion";
            dgvCondicion.RowHeadersWidth = 51;
            dgvCondicion.Size = new Size(647, 323);
            dgvCondicion.TabIndex = 0;
            // 
            // txtIdCondicion
            // 
            txtIdCondicion.Location = new Point(146, 49);
            txtIdCondicion.Margin = new Padding(3, 4, 3, 4);
            txtIdCondicion.Name = "txtIdCondicion";
            txtIdCondicion.Size = new Size(52, 27);
            txtIdCondicion.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 53);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 1;
            label1.Text = "IdCondicion:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 112);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 3;
            label2.Text = "Condicion:";
            // 
            // txtCondicion
            // 
            txtCondicion.Location = new Point(146, 101);
            txtCondicion.Margin = new Padding(3, 4, 3, 4);
            txtCondicion.Name = "txtCondicion";
            txtCondicion.Size = new Size(142, 27);
            txtCondicion.TabIndex = 4;
            // 
            // cbEstado
            // 
            cbEstado.AutoSize = true;
            cbEstado.Location = new Point(56, 163);
            cbEstado.Margin = new Padding(3, 4, 3, 4);
            cbEstado.Name = "cbEstado";
            cbEstado.Size = new Size(76, 24);
            cbEstado.TabIndex = 6;
            cbEstado.Text = "Estado";
            cbEstado.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(431, 49);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(157, 31);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(431, 101);
            btnEditar.Margin = new Padding(3, 4, 3, 4);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(157, 31);
            btnEditar.TabIndex = 8;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnDeshabilitar
            // 
            btnDeshabilitar.Location = new Point(431, 159);
            btnDeshabilitar.Margin = new Padding(3, 4, 3, 4);
            btnDeshabilitar.Name = "btnDeshabilitar";
            btnDeshabilitar.Size = new Size(157, 31);
            btnDeshabilitar.TabIndex = 9;
            btnDeshabilitar.Text = "Deshabilitar";
            btnDeshabilitar.UseVisualStyleBackColor = true;
            btnDeshabilitar.Click += btnDeshabilitar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 9);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 10;
            label3.Text = "Condicion";
            // 
            // Condicion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(696, 600);
            Controls.Add(label3);
            Controls.Add(btnDeshabilitar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Controls.Add(cbEstado);
            Controls.Add(txtCondicion);
            Controls.Add(label2);
            Controls.Add(txtIdCondicion);
            Controls.Add(label1);
            Controls.Add(dgvCondicion);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Condicion";
            Text = "Condicion";
            ((System.ComponentModel.ISupportInitialize)dgvCondicion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCondicion;
        private TextBox txtIdCondicion;
        private Label label1;
        private Label label2;
        private TextBox txtCondicion;
        private CheckBox cbEstado;
        private Button btnAgregar;
        private Button btnEditar;
        private Button btnDeshabilitar;
        private Label label3;
    }
}