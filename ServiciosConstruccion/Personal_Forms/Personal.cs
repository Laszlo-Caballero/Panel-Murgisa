using System;
using CapaLogica;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica.Personal;
using CapaAccesoDatos.Personal;
using CapaEntidad.Personal;

namespace CapaPresentacion.Personal_Forms
{
    public partial class Personal : Form
    {
        public Personal()
        {
            InitializeComponent();
            listarPersonal();
            listarDatos();
        }

        public void listarDatos()
        {
            cbCargo.DataSource = logCargo.Instancia.listarCargo();
            cbCargo.DisplayMember = "cargo";
            cbProfesion.DataSource = logProfesion.Instancia.listarProfesion();
            cbProfesion.DisplayMember = "titulo";
            cbDepartamento.DataSource = logDepartamento.Instancia.listarDepartamento();
            cbDepartamento.DisplayMember = "nombre";
        }

        public void listarPersonal()
        {
            dgvPersonal.DataSource = logPersonalVista.Instancia.listarPersonal();
        }

        private void dgvPersonal_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvPersonal.Rows[e.RowIndex];
            txtPersonal.Text = filaActual.Cells[0].Value.ToString();
            txtNombre.Text = filaActual.Cells[1].Value.ToString();
            txtPaterno.Text = filaActual.Cells[2].Value.ToString();
            txtMaterno.Text = filaActual.Cells[3].Value.ToString();
            cbCargo.SelectedItem = filaActual.Cells[4].Value.ToString();
            //cbProfesion.SelectedItem = filaActual.Cells[5].Value.ToString();
            //cbDepartamento.SelectedItem = filaActual.Cells[6].Value.ToString();
            txtSueldo.Text = filaActual.Cells[7].Value.ToString();
            cbkEstado.Checked = Convert.ToBoolean(filaActual.Cells[8].Value);
        }

        private void bttnAgregar_Click(object sender, EventArgs e)
        {
            entCargo cargo = cbCargo.SelectedValue as entCargo;
            entDepartamento dep = cbDepartamento.SelectedValue as entDepartamento;
            entProfesion prof = cbProfesion.SelectedValue as entProfesion;

            entPersonal personal = new entPersonal();
            personal.idCargo = cargo.id;
            personal.idProf = prof.id;
            personal.idDepa = dep.id;
            personal.nombre = txtNombre.Text;
            personal.paterno = txtPaterno.Text;
            personal.materno = txtMaterno.Text;
            personal.sueldo = Convert.ToSingle(txtSueldo.Text);
            personal.estado = cbkEstado.Checked;

            bool agregar = logPersonal.Instancia.agregarPersonal(personal);

            if (agregar)
            {
                listarPersonal();
                limpiar();
            }
            else
                MessageBox.Show("error al insertar cargo");
        }

        public void limpiar()
        {
            txtNombre.Text = "";
            txtPaterno.Text = "";
            txtMaterno.Text = "";
            txtSueldo.Text = "";
            txtPersonal.Text = "";
        }

        private void bttnEditar_Click(object sender, EventArgs e)
        {
            entCargo cargo = cbCargo.SelectedValue as entCargo;
            entDepartamento dep = cbDepartamento.SelectedValue as entDepartamento;
            entProfesion prof = cbProfesion.SelectedValue as entProfesion;

            entPersonal personal = new entPersonal();

            personal.id = Convert.ToInt32(txtPersonal.Text);
            personal.idCargo = cargo.id;
            personal.idProf = prof.id;
            personal.idDepa = dep.id;
            personal.nombre = txtNombre.Text;
            personal.paterno = txtPaterno.Text;
            personal.materno = txtMaterno.Text;
            personal.sueldo = Convert.ToSingle(txtSueldo.Text);
            personal.estado = cbkEstado.Checked;

            bool editar = logPersonal.Instancia.actualizarPersonal(personal);
            if (editar)
            {
                listarPersonal();
                limpiar();
            }
            else
                MessageBox.Show("error al actualizar cargo");
        }

        private void bttnDeshabilitar_Click(object sender, EventArgs e)
        {
            entPersonal personal = new entPersonal();
            personal.id = Convert.ToInt32(txtPersonal.Text);
            bool deshabilitar = logPersonal.Instancia.deshablitarPersonal(personal.id);

            if (deshabilitar)
            {
                listarPersonal();
                limpiar();
            }
            else
                MessageBox.Show("error al deshabilitar cargo");
        }
    }
}
