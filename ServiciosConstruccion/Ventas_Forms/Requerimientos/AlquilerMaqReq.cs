using CapaEntidad.Venta;
using CapaLogica.Recurso;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Ventas_Forms.Requerimientos
{
    public partial class AlquilerMaqReq : Form
    {
        public List<entRecurso> maquinarias = new List<entRecurso>();
        public AlquilerMaqReq()
        {
            InitializeComponent();
            listarMaquinaria();
            listarMaquinarias();
        }

        private void listarMaquinaria()
        {
            entTipoRecurso tipo = new entTipoRecurso();
            tipo.idTipoRecurso = 1;
            cbMaquinaria.DataSource = logRecurso.Instancia.listarRecursoTipo(tipo);
            cbMaquinaria.DisplayMember = "nombre";
        }

        private void listarMaquinarias()
        {
            dtgvMaquinarias.Rows.Clear();

            foreach (entRecurso m in maquinarias)
            {
                dtgvMaquinarias.Rows.Add(m.idRecurso, m.nombre,  m.cantidad);
            }
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {

            entRecurso recurso = cbMaquinaria.SelectedValue as entRecurso;

            recurso.cantidad = Convert.ToInt32(txtCantidad.Text);

            maquinarias.Add(recurso);
            listarMaquinarias();
        }

        private void dtgvMaquinarias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dtgvMaquinarias.Rows[e.RowIndex];
            txtId.Text = e.RowIndex.ToString();
            cbMaquinaria.SelectedItem = row.Cells[1].Value.ToString();
            txtCantidad.Text = row.Cells[2].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);

            entRecurso recurso = cbMaquinaria.SelectedValue as entRecurso;

            recurso.cantidad = Convert.ToInt32(txtCantidad.Text);

            maquinarias[id] = recurso;
            listarMaquinarias();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            maquinarias.RemoveAt(id);
            listarMaquinarias();
        }
    }
}
