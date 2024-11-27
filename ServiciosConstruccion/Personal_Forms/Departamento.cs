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

namespace CapaPresentacion.Personal_Forms
{
    public partial class Departamento : Form
    {
        public Departamento()
        {
            InitializeComponent();
            listar();
        }

        public void listar()
        {
            dgvDepartamento.DataSource = logDepartamento.Instancia.listarDepartamento();
        }

        public void limpiar()
        {
            txtDepartamento.Text = "";
            txtNombre.Text = "";
            txtDesc.Text = "";
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            entDepartamento dep = new entDepartamento();
            dep.nombre = txtNombre.Text;
            dep.desc = txtDesc.Text;
            dep.estado = cbkEstado.Checked;

            bool agregar = logDepartamento.Instancia.agregarDepartamento(dep);

            if (agregar)
            {
                listar();
                limpiar();
            }
            else
                MessageBox.Show("error al insertar cargo");
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            entDepartamento dep = new entDepartamento();
            dep.id = Convert.ToInt32(txtDepartamento.Text);
            dep.nombre = txtNombre.Text;
            dep.desc = txtDesc.Text;
            dep.estado = cbkEstado.Checked;

            bool editar = logDepartamento.Instancia.actualizarDepartamento(dep);
            if (editar)
            {
                listar();
                limpiar();
            }
            else
                MessageBox.Show("error al actualizar cargo");

        }

        private void dgvDepartamento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvDepartamento.Rows[e.RowIndex];
            txtDepartamento.Text = filaActual.Cells[0].Value.ToString();
            txtNombre.Text = filaActual.Cells[1].Value.ToString();
            txtDesc.Text = filaActual.Cells[2].Value.ToString();
            cbkEstado.Checked = Convert.ToBoolean(filaActual.Cells[3].Value);
        }
        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            entDepartamento dep = new entDepartamento();
            dep.id = Convert.ToInt32(txtDepartamento.Text);
            bool deshabilitar = logDepartamento.Instancia.deshablitarDepartamento(dep.id);

            if (deshabilitar)
            {
                listar();
                limpiar();
            }
            else
                MessageBox.Show("error al deshabilitar cargo");
        }
        private void txtDepartamento_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
