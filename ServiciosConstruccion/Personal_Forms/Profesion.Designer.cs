namespace CapaPresentacion.Personal_Forms
{
    partial class Profesion
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
            txtProfesion = new TextBox();
            label1 = new Label();
            txtTitulo = new TextBox();
            label2 = new Label();
            txtCriterio = new TextBox();
            label3 = new Label();
            cbkEstado = new CheckBox();
            btnBuscar = new Button();
            dgvProfesion = new DataGridView();
            btnAgregar = new Button();
            btnEditar = new Button();
            btnDeshabilitar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProfesion).BeginInit();
            SuspendLayout();
            // 
            // txtProfesion
            // 
            txtProfesion.Location = new Point(223, 64);
            txtProfesion.Margin = new Padding(6, 6, 6, 6);
            txtProfesion.Name = "txtProfesion";
            txtProfesion.Size = new Size(229, 39);
            txtProfesion.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 70);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(173, 32);
            label1.TabIndex = 2;
            label1.Text = "PROFESION ID:";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(223, 156);
            txtTitulo.Margin = new Padding(6, 6, 6, 6);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(229, 39);
            txtTitulo.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 173);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(90, 32);
            label2.TabIndex = 4;
            label2.Text = "TITULO";
            // 
            // txtCriterio
            // 
            txtCriterio.Location = new Point(682, 64);
            txtCriterio.Margin = new Padding(6, 6, 6, 6);
            txtCriterio.Name = "txtCriterio";
            txtCriterio.Size = new Size(299, 39);
            txtCriterio.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(542, 70);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(112, 32);
            label3.TabIndex = 6;
            label3.Text = "CRITERIO";
            // 
            // cbkEstado
            // 
            cbkEstado.AutoSize = true;
            cbkEstado.Location = new Point(568, 162);
            cbkEstado.Margin = new Padding(6, 6, 6, 6);
            cbkEstado.Name = "cbkEstado";
            cbkEstado.Size = new Size(132, 36);
            cbkEstado.TabIndex = 8;
            cbkEstado.Text = "ESTADO";
            cbkEstado.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(802, 154);
            btnBuscar.Margin = new Padding(6, 6, 6, 6);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(152, 73);
            btnBuscar.TabIndex = 9;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // dgvProfesion
            // 
            dgvProfesion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProfesion.Location = new Point(71, 262);
            dgvProfesion.Margin = new Padding(6, 6, 6, 6);
            dgvProfesion.Name = "dgvProfesion";
            dgvProfesion.RowHeadersWidth = 82;
            dgvProfesion.Size = new Size(674, 431);
            dgvProfesion.TabIndex = 10;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(802, 301);
            btnAgregar.Margin = new Padding(6, 6, 6, 6);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(182, 73);
            btnAgregar.TabIndex = 11;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(802, 427);
            btnEditar.Margin = new Padding(6, 6, 6, 6);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(182, 73);
            btnEditar.TabIndex = 12;
            btnEditar.Text = "EDITAR";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnDeshabilitar
            // 
            btnDeshabilitar.Location = new Point(802, 550);
            btnDeshabilitar.Margin = new Padding(6, 6, 6, 6);
            btnDeshabilitar.Name = "btnDeshabilitar";
            btnDeshabilitar.Size = new Size(182, 73);
            btnDeshabilitar.TabIndex = 13;
            btnDeshabilitar.Text = "DESHABILITAR";
            btnDeshabilitar.UseVisualStyleBackColor = true;
            // 
            // Profesion
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1096, 798);
            Controls.Add(btnDeshabilitar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Controls.Add(dgvProfesion);
            Controls.Add(btnBuscar);
            Controls.Add(cbkEstado);
            Controls.Add(txtCriterio);
            Controls.Add(label3);
            Controls.Add(txtTitulo);
            Controls.Add(label2);
            Controls.Add(txtProfesion);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6, 6, 6, 6);
            Name = "Profesion";
            Text = "Profesion";
            ((System.ComponentModel.ISupportInitialize)dgvProfesion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtProfesion;
        private Label label1;
        private TextBox txtTitulo;
        private Label label2;
        private TextBox txtCriterio;
        private Label label3;
        private CheckBox cbkEstado;
        private Button btnBuscar;
        private DataGridView dgvProfesion;
        private Button btnAgregar;
        private Button btnEditar;
        private Button btnDeshabilitar;
    }
}