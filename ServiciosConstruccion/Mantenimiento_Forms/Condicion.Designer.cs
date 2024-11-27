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
            ((System.ComponentModel.ISupportInitialize)dgvCondicion).BeginInit();
            SuspendLayout();
            // 
            // dgvCondicion
            // 
            dgvCondicion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCondicion.Location = new Point(27, 174);
            dgvCondicion.Name = "dgvCondicion";
            dgvCondicion.Size = new Size(566, 242);
            dgvCondicion.TabIndex = 0;
            // 
            // txtIdCondicion
            // 
            txtIdCondicion.Location = new Point(128, 37);
            txtIdCondicion.Name = "txtIdCondicion";
            txtIdCondicion.Size = new Size(46, 23);
            txtIdCondicion.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 40);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 1;
            label1.Text = "IdCondicion:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 84);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 3;
            label2.Text = "Condicion:";
            // 
            // txtCondicion
            // 
            txtCondicion.Location = new Point(128, 76);
            txtCondicion.Name = "txtCondicion";
            txtCondicion.Size = new Size(125, 23);
            txtCondicion.TabIndex = 4;
            // 
            // cbEstado
            // 
            cbEstado.AutoSize = true;
            cbEstado.Location = new Point(49, 122);
            cbEstado.Name = "cbEstado";
            cbEstado.Size = new Size(61, 19);
            cbEstado.TabIndex = 6;
            cbEstado.Text = "Estado";
            cbEstado.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(377, 37);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(137, 23);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(377, 76);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(137, 23);
            btnEditar.TabIndex = 8;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnDeshabilitar
            // 
            btnDeshabilitar.Location = new Point(377, 119);
            btnDeshabilitar.Name = "btnDeshabilitar";
            btnDeshabilitar.Size = new Size(137, 23);
            btnDeshabilitar.TabIndex = 9;
            btnDeshabilitar.Text = "Deshabilitar";
            btnDeshabilitar.UseVisualStyleBackColor = true;
            btnDeshabilitar.Click += btnDeshabilitar_Click;
            // 
            // Condicion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(609, 450);
            Controls.Add(btnDeshabilitar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Controls.Add(cbEstado);
            Controls.Add(txtCondicion);
            Controls.Add(label2);
            Controls.Add(txtIdCondicion);
            Controls.Add(label1);
            Controls.Add(dgvCondicion);
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
    }
}