using CapaEntidad.Cliente;
using CapaEntidad.Personal;
using CapaEntidad.Servicios;
using CapaLogica.Cliente;
using CapaLogica.Personal;
using CapaLogica.Servicios;
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
            dtgvPersonal.DataSource = personal;
        }


        private void cbTipoServicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            entServicios servicio = cbTipoServicio.SelectedItem as entServicios;
            panel.Controls.Clear();
            switch (servicio.idServicio)
            {
                case 1:
                    AlquilerMaqReq alquiler = new AlquilerMaqReq();
                    alquiler.TopLevel = false;
                    alquiler.Dock = DockStyle.Fill;
                    panel.Controls.Add(alquiler);
                    alquiler.Show();
                    break;
                case 2:
                    EdificacionesReq edificaciones = new EdificacionesReq();
                    edificaciones.TopLevel = false;
                    edificaciones.Dock = DockStyle.Fill;
                    panel.Controls.Add(edificaciones);
                    edificaciones.Show();
                    break;
                case 3:
                    MuroContencionReq muro = new MuroContencionReq();
                    muro.TopLevel = false;
                    muro.Dock = DockStyle.Fill;
                    panel.Controls.Add(muro);
                    muro.Show();
                    break;
                case 4:
                    AlquilerMaqReq alquilerDemolicion = new AlquilerMaqReq();
                    alquilerDemolicion.TopLevel = false;
                    alquilerDemolicion.Dock = DockStyle.Fill;
                    panel.Controls.Add(alquilerDemolicion);
                    alquilerDemolicion.Show();
                    break;
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
    }
}
