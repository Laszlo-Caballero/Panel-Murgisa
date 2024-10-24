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
            // Inicializamos los groupBox como invisibles
            gbAlquilerMaquinaria.Visible = false;
            gbEdificaciones.Visible = false;
            gbMurosContencion.Visible = false;
            gbDemolicion.Visible = false;

            // Suscribimos el evento SelectedIndexChanged del ComboBox
            cbTipoServicio.SelectedIndexChanged += new EventHandler(cbTipoServicio_SelectedIndexChanged);

            // Añadir opciones al ComboBox (Alquiler de Maquinarias, Edificaciones)
            cbTipoServicio.Items.Add("Alquiler de maquinarias");
            cbTipoServicio.Items.Add("Edificaciones");
            cbTipoServicio.Items.Add("Muro de Contención");
            cbTipoServicio.Items.Add("Demoliciones");
        }

        private void cbTipoServicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Ocultar todos los GroupBox inicialmente
            gbAlquilerMaquinaria.Visible = false;
            gbEdificaciones.Visible = false;
            gbMurosContencion.Visible = false;
            gbDemolicion.Visible = false;

            // Verificar si hay un item seleccionado
            if (cbTipoServicio.SelectedItem != null)
            {
                // Obtener el valor seleccionado del ComboBox
                string servicioSeleccionado = cbTipoServicio.SelectedItem.ToString();

                // Mostrar el GroupBox correspondiente según la selección
                switch (servicioSeleccionado)
                {
                    case "Alquiler de maquinarias":
                        gbAlquilerMaquinaria.Visible = true;
                        break;
                    case "Edificaciones":
                        gbEdificaciones.Visible = true;
                        break;
                    case "Muro de Contención":
                        gbMurosContencion.Visible = true;
                        break;
                    case "Demoliciones":
                        gbDemolicion.Visible = true;
                        break;
                }
            }
        }
    }
}
