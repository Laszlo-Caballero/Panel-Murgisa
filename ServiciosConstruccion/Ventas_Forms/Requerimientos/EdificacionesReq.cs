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
    public partial class EdificacionesReq : Form
    {
        public List<entMaterialVenta> materiales = new List<entMaterialVenta>();
        public EdificacionesReq()
        {
            InitializeComponent();
            listarMaterialesCb();
            listarMateriales();
        }

        private void listarMaterialesCb()
        {
            entTipoRecurso recurso = new entTipoRecurso();
            recurso.idTipoRecurso = 3;
            cbMateriales.DataSource = logRecurso.Instancia.listarRecursoTipo(recurso);
            cbMateriales.DisplayMember = "nombre";
        }

        private void listarMateriales()
        {
            dtgvMateriales.Rows.Clear();
            foreach (entMaterialVenta r in materiales)
            {
                dtgvMateriales.Rows.Add(r.idMaterial, r.nombre, r.cantidad);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            entRecurso recurso = cbMateriales.SelectedValue as entRecurso;
            entMaterialVenta material = new entMaterialVenta();
            material.idMaterial = recurso.idRecurso;
            material.nombre = recurso.nombre;
            material.cantidad = Convert.ToInt32(txtCantidad.Text);

            materiales.Add(material);
            listarMateriales();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            entRecurso recurso = cbMateriales.SelectedValue as entRecurso;
            entMaterialVenta material = new entMaterialVenta();
            material.idMaterial = recurso.idRecurso;
            material.nombre = recurso.nombre;
            material.cantidad = Convert.ToInt32(txtCantidad.Text);

            materiales[id] = material;
            listarMateriales();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            materiales.RemoveAt(id);
            listarMateriales();
        }

        private void dtgvMateriales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dtgvMateriales.Rows[e.RowIndex];
            txtId.Text = e.RowIndex.ToString();
            cbMateriales.SelectedItem = row.Cells[1].Value.ToString();
            txtCantidad.Text = row.Cells[2].Value.ToString();
        }
    }
}
