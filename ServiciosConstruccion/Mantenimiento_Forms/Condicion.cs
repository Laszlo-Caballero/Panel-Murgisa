using CapaEntidad.Cliente;
using CapaEntidad.Condicion;
using CapaLogica.Cliente;
using CapaLogica.Condicion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Mantenimiento_Forms
{
    public partial class Condicion : Form
    {
        public Condicion()
        {
            InitializeComponent();
            ListarCondicion();
        }
        private void ListarCondicion()
        {
            dgvCondicion.DataSource = logCondicion.Instancia.listarCondicion();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string Ncondicion = txtCondicion.Text;
            bool estado = cbEstado.Checked;

            entCondicion condicion = new entCondicion();

            condicion.condicion = Ncondicion;
            condicion.estado = estado;

            bool ingreso = logCondicion.Instancia.agregarCondicion(condicion);

            if (ingreso)
            {
                ListarCondicion();
            }
            else
            {
                MessageBox.Show("error al insertar clientes");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }
    }
}
