using CapaEntidad.Personal;
using CapaEntidad.Recurso;
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

namespace CapaPresentacion
{
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();
            listarVentas();
        }
        List<entAsignacionPersonal> personal;
        List<entDetalleVenta> recursos;

        public void listarVentas()
        {
            dtVentas.DataSource = logVenta.Instancia.listarVenta();
        }

        private void dtVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dtVentas.Rows[e.RowIndex];
            int id = Convert.ToInt32(row.Cells[0].Value);
            txtIdVenta.Text = id.ToString();

            personal = logVenta.Instancia.listarPersonal(id);
            recursos = logVenta.Instancia.listarDetalleVentas(id);

            dtMateriales.DataSource = recursos;
            dtEmpleados.DataSource = personal;
        }

        private void btnsultar_Click(object sender, EventArgs e)
        {
            string dni = txtRuc.Text;
            dtVentas.DataSource = logVenta.Instancia.listarVentaClienteDni(dni);
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            listarVentas();
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtIdVenta.Text);
            bool anularV = logVenta.Instancia.deshablitarVenta(id);
            bool anularR = false;
            bool anularP = false;
            foreach (entDetalleVenta v in recursos)
            {
                anularR = logVenta.Instancia.habilitarRecurso(id, v.idRecurso);
            }

            foreach (entAsignacionPersonal p in personal)
            {
                anularP = logVenta.Instancia.deshabilitarPersonal(id, p.idPersonal);
            }

            if(anularR && anularV && anularP)
            {
                listarVentas();

                personal = logVenta.Instancia.listarPersonal(id);
                recursos = logVenta.Instancia.listarDetalleVentas(id);

                dtMateriales.DataSource = recursos;
                dtEmpleados.DataSource = personal;
            }
            else
            {
                MessageBox.Show("algo paso");
            }
        }
    }
}
