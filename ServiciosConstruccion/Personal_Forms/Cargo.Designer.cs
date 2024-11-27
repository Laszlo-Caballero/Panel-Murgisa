namespace CapaPresentacion.Personal_Forms
{
    partial class Cargo
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
            txtCargo = new TextBox();
            txtNombre = new TextBox();
            label2 = new Label();
            txtDesc = new TextBox();
            label3 = new Label();
            txtSueldo = new TextBox();
            label4 = new Label();
            cbkEstado = new CheckBox();
            dgvCargo = new DataGridView();
            txtCriterio = new TextBox();
            label5 = new Label();
            btnBuscar = new Button();
            btnAgregar = new Button();
            btnEditar = new Button();
            btnDeshabilitar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCargo).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 45);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(120, 32);
            label1.TabIndex = 0;
            label1.Text = "CARGOID:";
            // 
            // txtCargo
            // 
            txtCargo.Location = new Point(186, 38);
            txtCargo.Margin = new Padding(6, 6, 6, 6);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(229, 39);
            txtCargo.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(186, 134);
            txtNombre.Margin = new Padding(6, 6, 6, 6);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(229, 39);
            txtNombre.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 141);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(117, 32);
            label2.TabIndex = 2;
            label2.Text = "NOMBRE:";
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(693, 38);
            txtDesc.Margin = new Padding(6, 6, 6, 6);
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(673, 39);
            txtDesc.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(526, 51);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(166, 32);
            label3.TabIndex = 4;
            label3.Text = "DESCRIPCION:";
            // 
            // txtSueldo
            // 
            txtSueldo.Location = new Point(659, 141);
            txtSueldo.Margin = new Padding(6, 6, 6, 6);
            txtSueldo.Name = "txtSueldo";
            txtSueldo.Size = new Size(229, 39);
            txtSueldo.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(535, 147);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(101, 32);
            label4.TabIndex = 6;
            label4.Text = "SUELDO";
            // 
            // cbkEstado
            // 
            cbkEstado.AutoSize = true;
            cbkEstado.Location = new Point(988, 141);
            cbkEstado.Margin = new Padding(6, 6, 6, 6);
            cbkEstado.Name = "cbkEstado";
            cbkEstado.Size = new Size(132, 36);
            cbkEstado.TabIndex = 8;
            cbkEstado.Text = "ESTADO";
            cbkEstado.UseVisualStyleBackColor = true;
            // 
            // dgvCargo
            // 
            dgvCargo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCargo.Location = new Point(22, 307);
            dgvCargo.Margin = new Padding(6, 6, 6, 6);
            dgvCargo.Name = "dgvCargo";
            dgvCargo.RowHeadersWidth = 82;
            dgvCargo.Size = new Size(1142, 514);
            dgvCargo.TabIndex = 9;
            // 
            // txtCriterio
            // 
            txtCriterio.Location = new Point(186, 224);
            txtCriterio.Margin = new Padding(6, 6, 6, 6);
            txtCriterio.Name = "txtCriterio";
            txtCriterio.Size = new Size(229, 39);
            txtCriterio.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(45, 230);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(112, 32);
            label5.TabIndex = 10;
            label5.Text = "CRITERIO";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(488, 213);
            btnBuscar.Margin = new Padding(6, 6, 6, 6);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(167, 81);
            btnBuscar.TabIndex = 12;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(1202, 307);
            btnAgregar.Margin = new Padding(6, 6, 6, 6);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(186, 81);
            btnAgregar.TabIndex = 13;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(1202, 439);
            btnEditar.Margin = new Padding(6, 6, 6, 6);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(186, 81);
            btnEditar.TabIndex = 14;
            btnEditar.Text = "EDITAR";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnDeshabilitar
            // 
            btnDeshabilitar.Location = new Point(1202, 567);
            btnDeshabilitar.Margin = new Padding(6, 6, 6, 6);
            btnDeshabilitar.Name = "btnDeshabilitar";
            btnDeshabilitar.Size = new Size(186, 81);
            btnDeshabilitar.TabIndex = 15;
            btnDeshabilitar.Text = "DESHABILITAR";
            btnDeshabilitar.UseVisualStyleBackColor = true;
            // 
            // Cargo
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1441, 870);
            Controls.Add(btnDeshabilitar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Controls.Add(btnBuscar);
            Controls.Add(txtCriterio);
            Controls.Add(label5);
            Controls.Add(dgvCargo);
            Controls.Add(cbkEstado);
            Controls.Add(txtSueldo);
            Controls.Add(label4);
            Controls.Add(txtDesc);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(txtCargo);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6, 6, 6, 6);
            Name = "Cargo";
            Text = "Cargo";
            ((System.ComponentModel.ISupportInitialize)dgvCargo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCargo;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtDesc;
        private Label label3;
        private TextBox txtSueldo;
        private Label label4;
        private CheckBox cbkEstado;
        private DataGridView dgvCargo;
        private TextBox txtCriterio;
        private Label label5;
        private Button btnBuscar;
        private Button btnAgregar;
        private Button btnEditar;
        private Button btnDeshabilitar;
    }
}