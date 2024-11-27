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
            dataGridView1 = new DataGridView();
            btnAgregar = new Button();
            btnEditar = new Button();
            btnDeshabilitar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtProfesion
            // 
            txtProfesion.Location = new Point(120, 30);
            txtProfesion.Name = "txtProfesion";
            txtProfesion.Size = new Size(125, 23);
            txtProfesion.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 33);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 2;
            label1.Text = "PROFESION ID:";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(120, 73);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(125, 23);
            txtTitulo.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 81);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 4;
            label2.Text = "TITULO";
            // 
            // txtCriterio
            // 
            txtCriterio.Location = new Point(367, 30);
            txtCriterio.Name = "txtCriterio";
            txtCriterio.Size = new Size(163, 23);
            txtCriterio.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(292, 33);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 6;
            label3.Text = "CRITERIO";
            // 
            // cbkEstado
            // 
            cbkEstado.AutoSize = true;
            cbkEstado.Location = new Point(306, 76);
            cbkEstado.Name = "cbkEstado";
            cbkEstado.Size = new Size(68, 19);
            cbkEstado.TabIndex = 8;
            cbkEstado.Text = "ESTADO";
            cbkEstado.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(432, 72);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(82, 34);
            btnBuscar.TabIndex = 9;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(38, 123);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(363, 202);
            dataGridView1.TabIndex = 10;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(432, 141);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(98, 34);
            btnAgregar.TabIndex = 11;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(432, 200);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(98, 34);
            btnEditar.TabIndex = 12;
            btnEditar.Text = "EDITAR";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnDeshabilitar
            // 
            btnDeshabilitar.Location = new Point(432, 258);
            btnDeshabilitar.Name = "btnDeshabilitar";
            btnDeshabilitar.Size = new Size(98, 34);
            btnDeshabilitar.TabIndex = 13;
            btnDeshabilitar.Text = "DESHABILITAR";
            btnDeshabilitar.UseVisualStyleBackColor = true;
            // 
            // Profesion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(590, 374);
            Controls.Add(btnDeshabilitar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Controls.Add(dataGridView1);
            Controls.Add(btnBuscar);
            Controls.Add(cbkEstado);
            Controls.Add(txtCriterio);
            Controls.Add(label3);
            Controls.Add(txtTitulo);
            Controls.Add(label2);
            Controls.Add(txtProfesion);
            Controls.Add(label1);
            Name = "Profesion";
            Text = "Profesion";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private DataGridView dataGridView1;
        private Button btnAgregar;
        private Button btnEditar;
        private Button btnDeshabilitar;
    }
}