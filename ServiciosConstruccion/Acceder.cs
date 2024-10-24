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
using CapaPresentacion.Almacen_Forms;

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
            if (cbSistemas.SelectedItem != null)
            {
                string seleccion = cbSistemas.SelectedItem.ToString();
                
                if (seleccion == "Vendedor")
                {
                    
                    if (!string.IsNullOrWhiteSpace(txtUsuario.Text) && !string.IsNullOrWhiteSpace(txtContraseña.Text))
                    {
                       
                        PanelVendedor formVenta = new PanelVendedor();
                        formVenta.Show();
                    }
                    else
                    {
                        
                        MessageBox.Show("Debe llenar todos los campos: usuario y contraseña.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
               
                else if (seleccion == "Jefe de Servicio")
                {
                   
                    if (!string.IsNullOrWhiteSpace(txtUsuario.Text) && !string.IsNullOrWhiteSpace(txtContraseña.Text))
                    {

                        PanelJefeServicio formJefe = new PanelJefeServicio();                     
                        formJefe.Show();
                    }
                    else
                    {
                      
                        MessageBox.Show("Debe llenar todos los campos: usuario y contraseña.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else if (seleccion == "Jefe de Mantenimiento")
                {

                    if (!string.IsNullOrWhiteSpace(txtUsuario.Text) && !string.IsNullOrWhiteSpace(txtContraseña.Text))
                    {

                        PanelMantenimiento formMantenimiento = new PanelMantenimiento();
                        formMantenimiento.Show();
                    }
                    else
                    {

                        MessageBox.Show("Debe llenar todos los campos: usuario y contraseña.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                else if (seleccion == "Jefe de Almacén")
                {
                  
                    if (!string.IsNullOrWhiteSpace(txtUsuario.Text) && !string.IsNullOrWhiteSpace(txtContraseña.Text))
                    {
                        
                        PanelAlmacen formAlmacen = new PanelAlmacen();
                        formAlmacen.Show();
                    }
                    else
                    {
                      
                        MessageBox.Show("Debe llenar todos los campos: usuario y contraseña.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }

        }

        private void cbSistemas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
