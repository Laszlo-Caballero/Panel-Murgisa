using CapaEntidad.Venta;
using CapaLogica.Venta;
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
        public List<entAlquilerMaquinaria> maquinarias = new List<entAlquilerMaquinaria>();
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
            foreach (entAlquilerMaquinaria m in maquinarias)
            {
                dtgvMaquinarias.Rows.Add(m.idMaquinaria, m.nombre, m.fechaInicio, m.fechaFin, m.cantidad, m.operador);
            }
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            entAlquilerMaquinaria maquinaria = new entAlquilerMaquinaria();

            entRecurso recurso = cbMaquinaria.SelectedValue as entRecurso;

            maquinaria.idMaquinaria = recurso.idRecurso;
            maquinaria.nombre = recurso.nombre;
            maquinaria.fechaInicio = dtInicio.Value;
            maquinaria.fechaFin = dtFin.Value;
            maquinaria.cantidad = Convert.ToInt32(txtCantidad.Text);
            maquinaria.operador = cbkEstadoOperador.Checked;

            maquinarias.Add(maquinaria);
            listarMaquinarias();
        }

        private void dtgvMaquinarias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dtgvMaquinarias.Rows[e.RowIndex];
            txtId.Text = e.RowIndex.ToString();
            cbMaquinaria.SelectedItem = row.Cells[0].Value;
            dtInicio.Value = Convert.ToDateTime(row.Cells[2].Value);
            dtFin.Value = Convert.ToDateTime(row.Cells[3].Value);
            txtCantidad.Text = row.Cells[4].Value.ToString();
            cbkEstadoOperador.Checked = Convert.ToBoolean(row.Cells[5].Value);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            entAlquilerMaquinaria maquinaria = new entAlquilerMaquinaria();

            entRecurso recurso = cbMaquinaria.SelectedValue as entRecurso;

            maquinaria.idMaquinaria = recurso.idRecurso;
            maquinaria.nombre = recurso.nombre;
            maquinaria.fechaInicio = dtInicio.Value;
            maquinaria.fechaFin = dtFin.Value;
            maquinaria.cantidad = Convert.ToInt32(txtCantidad.Text);
            maquinaria.operador = cbkEstadoOperador.Checked;

            maquinarias[id] = maquinaria;
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
