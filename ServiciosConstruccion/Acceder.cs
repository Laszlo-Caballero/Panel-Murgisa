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
using CapaPresentacion.Personal_Forms;
using CapaLogica.Usuario;
using CapaEntidad.Usuario;
using System.Diagnostics.Eventing.Reader;

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
            if (txtUsuario.Text == "") {
                MessageBox.Show("Ingrese Usuario");
            }else if (txtContraseña.Text == "")
            {
                MessageBox.Show("Ingrese Contraseña");
            }
            else { 
            entUsuario datos = logUsuario.Instancia.logear(txtUsuario.Text, txtContraseña.Text);
            if(datos == null) {
                MessageBox.Show("Usuario o Contraseña incorrectos", "Campos erroneos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (datos.idCargo == 5)
                {
                    MessageBox.Show("Ingresando al Panel Vendedor");
                    PanelVendedor formVenta = new PanelVendedor();
                    formVenta.Show();
                }
                else if(datos.idCargo==6){
                    MessageBox.Show("Ingresando al Panel Jefe de Servicio");
                    PanelJefeServicio formJefe = new PanelJefeServicio();
                    formJefe.Show();
                }
                else if (datos.idCargo == 7)
                {
                    MessageBox.Show("Ingresando al Panel Jefe de Mantenimiento");
                    PanelMantenimiento formMantenimiento = new PanelMantenimiento();
                    formMantenimiento.Show();
                }
                else if (datos.idCargo == 8)
                {
                    MessageBox.Show("Ingresando al Panel Jefe de Personal");
                    PanelJefePersonal formJefep = new PanelJefePersonal();
                    formJefep.Show();
                }
            }

            }
        }

        private void cbSistemas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
