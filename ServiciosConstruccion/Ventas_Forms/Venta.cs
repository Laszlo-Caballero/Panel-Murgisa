using CapaEntidad.Servicios;
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
        public Venta()
        {
            InitializeComponent();
            listarServicios();
        }

        private void listarServicios()
        {
            cbTipoServicio.Items.Clear();
            cbTipoServicio.DataSource = logServicios.Instancia.listarServicios();
            cbTipoServicio.ValueMember = "nombre";
        }


        private void cbTipoServicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            entServicios servicio = cbTipoServicio.SelectedItem as entServicios;
            panel.Controls.Clear();
            switch (servicio.idServicio)
            {
                case 2:
                    AlquilerMaqReq alquiler = new AlquilerMaqReq();
                    alquiler.TopLevel = false;
                    alquiler.Dock = DockStyle.Fill;
                    panel.Controls.Add(alquiler);
                    alquiler.Show();
                    break;
                case 3:
                    EdificacionesReq edificaciones = new EdificacionesReq();
                    edificaciones.TopLevel = false;
                    edificaciones.Dock = DockStyle.Fill;
                    panel.Controls.Add(edificaciones);
                    edificaciones.Show();
                    break;
                case 4:
                    MuroContencionReq muro = new MuroContencionReq();
                    muro.TopLevel = false;
                    muro.Dock = DockStyle.Fill;
                    panel.Controls.Add(muro);
                    muro.Show();
                    break;
                case 5:
                    DemolicionReq demolicion = new DemolicionReq();
                    demolicion.TopLevel = false;
                    demolicion.Dock = DockStyle.Fill;
                    panel.Controls.Add(demolicion);
                    demolicion.Show();
                    break;
            }
        }
    }
}
