using CapaAccesoDatos.Personal;
using CapaEntidad.Personal;
using CapaLogica.Personal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace CapaPresentacion.Personal_Forms
{
    public partial class Profesion : Form
    {
        public Profesion()
        {
            InitializeComponent();
            listar();
        }

        public void listar()
        {
            dgvProfesion.DataSource = logProfesion.Instancia.listarProfesion();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            entProfesion profesion = new entProfesion();
            profesion.titulo = txtTitulo.Text;
            profesion.estado = cbkEstado.Checked;

            bool agregar = logProfesion.Instancia.agregarProfesion(profesion);

            if (agregar)
            {
                listar();
                limpiar();
            }
            else
                MessageBox.Show("error al insertar profesion");
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            entProfesion profesion = new entProfesion();
            profesion.id = Convert.ToInt32(txtProfesion.Text);
            profesion.titulo = txtTitulo.Text;
            profesion.estado = cbkEstado.Checked;

            bool editar = logProfesion.Instancia.actualizarProfesion(profesion);
            if (editar)
            {
                listar();
                limpiar();
            }
            else
                MessageBox.Show("error al actualizar profesion");
        }

        private void dgvProfesion_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvProfesion.Rows[e.RowIndex];
            txtProfesion.Text = filaActual.Cells[0].Value.ToString();
            txtTitulo.Text = filaActual.Cells[1].Value.ToString();
            cbkEstado.Checked = Convert.ToBoolean(filaActual.Cells[2].Value);
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            entProfesion profesion = new entProfesion();
            profesion.id = Convert.ToInt32(txtProfesion.Text);
            bool deshabilitar = logProfesion.Instancia.deshablitarProfesion(profesion.id);

            if (deshabilitar)
            {
                listar();
                limpiar();
            }
            else
                MessageBox.Show("error al deshabilitar cargo");
        }

        public void limpiar()
        {
            txtTitulo.Text = "";
            txtProfesion.Text = "";
        }
    }
}
