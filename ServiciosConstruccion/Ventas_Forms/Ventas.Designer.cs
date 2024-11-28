namespace CapaPresentacion
{
    partial class Ventas
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
            label2 = new Label();
            label3 = new Label();
            txtRuc = new TextBox();
            dtFecha = new DateTimePicker();
            btnsultar = new Button();
            dtVentas = new DataGridView();
            button2 = new Button();
            dtMateriales = new DataGridView();
            dtEmpleados = new DataGridView();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtVentas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtMateriales).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtEmpleados).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(441, 19);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(79, 28);
            label1.TabIndex = 1;
            label1.Text = " Ventas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 81);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 2;
            label2.Text = "Fecha:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(343, 81);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 3;
            label3.Text = "Cliente:";
            // 
            // txtRuc
            // 
            txtRuc.Location = new Point(415, 77);
            txtRuc.Margin = new Padding(2);
            txtRuc.Name = "txtRuc";
            txtRuc.Size = new Size(125, 27);
            txtRuc.TabIndex = 6;
            // 
            // dtFecha
            // 
            dtFecha.Location = new Point(79, 81);
            dtFecha.Margin = new Padding(2);
            dtFecha.Name = "dtFecha";
            dtFecha.Size = new Size(248, 27);
            dtFecha.TabIndex = 8;
            // 
            // btnsultar
            // 
            btnsultar.Location = new Point(561, 77);
            btnsultar.Margin = new Padding(2);
            btnsultar.Name = "btnsultar";
            btnsultar.Size = new Size(92, 29);
            btnsultar.TabIndex = 9;
            btnsultar.Text = "Consultar";
            btnsultar.UseVisualStyleBackColor = true;
            // 
            // dtVentas
            // 
            dtVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtVentas.Location = new Point(19, 136);
            dtVentas.Margin = new Padding(2);
            dtVentas.Name = "dtVentas";
            dtVentas.RowHeadersWidth = 82;
            dtVentas.Size = new Size(955, 151);
            dtVentas.TabIndex = 10;
            dtVentas.CellClick += dtVentas_CellClick;
            // 
            // button2
            // 
            button2.Location = new Point(846, 721);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(128, 29);
            button2.TabIndex = 11;
            button2.Text = "Anular Venta";
            button2.UseVisualStyleBackColor = true;
            // 
            // dtMateriales
            // 
            dtMateriales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtMateriales.Location = new Point(18, 334);
            dtMateriales.Margin = new Padding(2);
            dtMateriales.Name = "dtMateriales";
            dtMateriales.RowHeadersWidth = 82;
            dtMateriales.Size = new Size(955, 151);
            dtMateriales.TabIndex = 12;
            // 
            // dtEmpleados
            // 
            dtEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtEmpleados.Location = new Point(19, 526);
            dtEmpleados.Margin = new Padding(2);
            dtEmpleados.Name = "dtEmpleados";
            dtEmpleados.RowHeadersWidth = 82;
            dtEmpleados.Size = new Size(955, 151);
            dtEmpleados.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(19, 304);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(105, 28);
            label4.TabIndex = 14;
            label4.Text = "Materiales";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(18, 496);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(111, 28);
            label5.TabIndex = 15;
            label5.Text = "Empleados";
            // 
            // Ventas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1026, 774);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dtEmpleados);
            Controls.Add(dtMateriales);
            Controls.Add(button2);
            Controls.Add(dtVentas);
            Controls.Add(btnsultar);
            Controls.Add(dtFecha);
            Controls.Add(txtRuc);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "Ventas";
            Text = "Ventas";
            ((System.ComponentModel.ISupportInitialize)dtVentas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtMateriales).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtEmpleados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtRuc;
        private DateTimePicker dtFecha;
        private Button btnsultar;
        private DataGridView dtVentas;
        private Button button2;
        private DataGridView dtMateriales;
        private DataGridView dtEmpleados;
        private Label label4;
        private Label label5;
    }
}