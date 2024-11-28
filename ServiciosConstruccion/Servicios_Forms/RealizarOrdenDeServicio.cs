using CapaEntidad.Servicio.OrdenServicio;
using CapaLogica.Servicio.OrdenServicio;
using CapaLogica.Servicio.PagoServicio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Servicios_Forms
{
    public partial class RealizarOrdenDeServicio : Form
    {
        List<entOrdenServicioVista> servicios;
        public RealizarOrdenDeServicio()
        {
            InitializeComponent();
            listarDatos();
        }


        private void listarDatos()
        {
            servicios = logOrdenServicio.Instancia.listarOrdenServicio();
            dtvgOrdenes.DataSource = servicios;
        }

        private void limpiarMateriales()
        {
            List<entOrdenServicioVista> orden = new List<entOrdenServicioVista>();
            dtvgOrdenes.DataSource = orden;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string dni = txtDniCliente.Text;
            dvgPagos.DataSource = logPagoServicio.Instancia.listarPagoServicioDni(dni);
        }

        private void dvgPagos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dvgPagos.Rows[e.RowIndex];
            txtVenta.Text = row.Cells[1].Value.ToString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            entOrdenServicio servicio = new entOrdenServicio();

            servicio.idVenta = int.Parse(txtVenta.Text);
            servicio.estado = true;
            servicio.fecha = dtFechaRegistro.Value;



            bool agregar = logOrdenServicio.Instancia.agregarOrdenServicio(servicio);
            if (agregar)
            {
                listarDatos();
            }
        }

        private void dtvgOrdenes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dtvgOrdenes.Rows[e.RowIndex];
            dvgMateriales.DataSource = servicios[e.RowIndex].recursos;
            txtOrdenServicio.Text = row.Cells[0].Value.ToString();
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {

            int id = int.Parse(txtOrdenServicio.Text);
            bool anular = logOrdenServicio.Instancia.deshablitarOrdenServicio(id);
            if (anular)
            {
                listarDatos();
                limpiarMateriales();
            }
        }

    }
}
