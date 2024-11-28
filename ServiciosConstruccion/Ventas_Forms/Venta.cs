using CapaEntidad.Cliente;
using CapaEntidad.Personal;
using CapaEntidad.Servicios;
using CapaEntidad.Venta;
using CapaLogica.Cliente;
using CapaLogica.Personal;
using CapaLogica.Servicios;
using CapaLogica.Venta;
using CapaPresentacion.Ventas_Forms.Requerimientos;
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
    public partial class Venta : Form
    {

        private List<entPersonalVista> personal = new List<entPersonalVista>();
        private AlquilerMaqReq alquiler;
        private EdificacionesReq edificaciones;
        private MuroContencionReq muro;
        private AlquilerMaqReq alquilerDemolicion;

        private List<entVenta> ventas = new List<entVenta>();

        public Venta()
        {
            InitializeComponent();
            listarServicios();
            listarPersonal();
        }

        private void listarServicios()
        {
            cbTipoServicio.Items.Clear();
            cbTipoServicio.DataSource = logServicios.Instancia.listarServicios();
            cbTipoServicio.ValueMember = "nombre";
            cbPersonal.Items.Clear();
            cbPersonal.DataSource = logPersonalVista.Instancia.listarPersonal();
            cbPersonal.DisplayMember = "nombre";
        }

        private void listarPersonal()
        {
            dtgvPersonal.Rows.Clear();

            foreach (entPersonalVista p in personal)
            {
                dtgvPersonal.Rows.Add(p.id, p.nombre, p.sueldo);
            }
        }


        private void cbTipoServicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            entServicios servicio = cbTipoServicio.SelectedItem as entServicios;
            panel.Controls.Clear();
            switch (servicio.idServicio)
            {
                case 1:
                    alquiler = new AlquilerMaqReq();
                    alquiler.TopLevel = false;
                    alquiler.Dock = DockStyle.Fill;
                    panel.Controls.Add(alquiler);
                    alquiler.Show();
                    break;
                case 2:
                    edificaciones = new EdificacionesReq();
                    edificaciones.TopLevel = false;
                    edificaciones.Dock = DockStyle.Fill;
                    panel.Controls.Add(edificaciones);
                    edificaciones.Show();
                    break;
                case 3:
                    muro = new MuroContencionReq();
                    muro.TopLevel = false;
                    muro.Dock = DockStyle.Fill;
                    panel.Controls.Add(muro);
                    muro.Show();
                    break;
                case 4:
                    alquilerDemolicion = new AlquilerMaqReq();
                    alquilerDemolicion.TopLevel = false;
                    alquilerDemolicion.Dock = DockStyle.Fill;
                    panel.Controls.Add(alquilerDemolicion);
                    alquilerDemolicion.Show();
                    break;
            }
        }

        private void listarVenta()
        {
            dtgvServicios.Rows.Clear();
            foreach (entVenta v in ventas)
            {
                string nombre = cbTipoServicio.Items.Cast<entServicios>().FirstOrDefault(item => item.idServicio == v.idServicio).nombre;
                dtgvServicios.Rows.Add(nombre, v.fIncioServicio, v.fFinServicio, v.estado);
            }
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string ruc = txtRuc.Text;
            entCliente cliente = logCliente.Instancia.buscarCliente(ruc);
            if (cliente.idCliente != 0)
            {
                txtCliente.Text = cliente.nombreRepresentatne;
                txtidCliente.Text = cliente.idCliente.ToString();
            }
            else
            {
                MessageBox.Show("no se encontro");
            }
        }

        private void btnAgregarPersonal_Click(object sender, EventArgs e)
        {
            entPersonalVista persona = cbPersonal.SelectedItem as entPersonalVista;
            personal.Add(persona);
            listarPersonal();
        }

        private void dtgvPersonal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dtgvPersonal.Rows[e.RowIndex];
            txtIdPersonal.Text = e.RowIndex.ToString();
            int id = Convert.ToInt32(row.Cells[0].Value);
            cbPersonal.SelectedItem = cbPersonal.Items.Cast<entPersonalVista>().FirstOrDefault(item => item.id == id);
        }

        private void btnEliminarPersonal_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtIdPersonal.Text);
            personal.RemoveAt(id);
            listarPersonal();
        }

        private void btnAgergarVenta_Click(object sender, EventArgs e)
        {
            entVenta venta = new entVenta();
            entServicios servicio = cbTipoServicio.SelectedItem as entServicios;
            venta.idServicio = servicio.idServicio;
            venta.idCliente = int.Parse(txtidCliente.Text);

            switch (servicio.idServicio)
            {
                case 1:
                    (DateTime finicio, DateTime ffin) = alquiler.getTiempos();
                    venta.fIncioServicio = finicio;
                    venta.fFinServicio = ffin;
                    venta.recursos = alquiler.maquinarias;
                    break;
                case 2:
                    (finicio, ffin) = edificaciones.getTiempos();
                    venta.fIncioServicio = finicio;
                    venta.fFinServicio = ffin;
                    venta.recursos = edificaciones.materiales;
                    break;
                case 3:
                    (finicio, ffin) = muro.getTiempos();
                    venta.fIncioServicio = finicio;
                    venta.fFinServicio = ffin;
                    venta.recursos = muro.materiales;
                    break;
                case 4:
                    (finicio, ffin) = alquilerDemolicion.getTiempos();
                    venta.fIncioServicio = finicio;
                    venta.fFinServicio = ffin;
                    venta.recursos = alquiler.maquinarias;
                    break;
            }
            venta.fechaVenta = dtRegistro.Value;
            venta.estado = cbkEstado.Checked;
            venta.personal = personal;

            ventas.Add(venta);
            listarVenta();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            foreach (entVenta v in ventas)
            {
                bool estado = logVenta.Instancia.agregarVenta(v);
                if (!estado)
                {
                    MessageBox.Show("ocurrio algo mal xd");
                    break;
                }
            }
        }
    }
}
