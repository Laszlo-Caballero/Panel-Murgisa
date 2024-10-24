using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaAccesoDatos;
using CapaPresentacion;

namespace Capa_Presentacion
{
    public partial class Acceder : Form
    {
        public Acceder()
        {
            InitializeComponent();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            // Verificamos si en el comboBox está seleccionada la opción vendedor o jefe de servicio
            if (cbSistemas.SelectedItem != null)
            {
                string seleccion = cbSistemas.SelectedItem.ToString();

                // Si se selecciona "Vendedor"
                if (seleccion == "Vendedor")
                {
                    // Verificamos si los campos txtUsuario y txtContraseña no están vacíos
                    if (!string.IsNullOrWhiteSpace(txtUsuario.Text) && !string.IsNullOrWhiteSpace(txtContraseña.Text))
                    {
                        // Crear una instancia del formulario realizarVenta
                        PanelVendedor formVenta = new PanelVendedor();
                        // Mostrar el formulario de realizarVenta
                        formVenta.Show();
                    }
                    else
                    {
                        // Si algún campo está vacío
                        MessageBox.Show("Debe llenar todos los campos: usuario y contraseña.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                // Si se selecciona "Jefe de Servicio"
                else if (seleccion == "Jefe de Servicio")
                {
                    // Verificamos si los campos txtUsuario y txtContraseña no están vacíos
                    if (!string.IsNullOrWhiteSpace(txtUsuario.Text) && !string.IsNullOrWhiteSpace(txtContraseña.Text))
                    {
                        // Crear una instancia del formulario panelJefeServicio
                        PanelJefeServicio formJefe = new PanelJefeServicio();
                        // Mostrar el formulario de panelJefeServicio
                        formJefe.Show();
                    }
                    else
                    {
                        // Si algún campo está vacío
                        MessageBox.Show("Debe llenar todos los campos: usuario y contraseña.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }

        }
    }
}
