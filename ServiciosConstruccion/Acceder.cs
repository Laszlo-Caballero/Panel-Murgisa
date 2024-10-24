using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            // Verificamos si en el comboBox está seleccionada la opción vendedor
            if (cbSistemas.SelectedItem != null && cbSistemas.SelectedItem.ToString() == "Jefe de Mantenimiento")
            {
                // Verificamos si los campos txtUsuario y txtContraseña no están vacíos
                if (!string.IsNullOrWhiteSpace(txtUsuario.Text) && !string.IsNullOrWhiteSpace(txtContraseña.Text))
                {
                    // Crear una instancia del formulario
                    PanelMantenimiento formMantenimiento = new PanelMantenimiento();
                    // Mostrar el formulario
                    formMantenimiento.Show();
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
