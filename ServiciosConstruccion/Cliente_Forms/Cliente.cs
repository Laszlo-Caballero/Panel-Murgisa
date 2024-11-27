using CapaEntidad.Cliente;
using CapaLogica.Cliente;
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
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
            listarCiudades();
            listarClientes();
        }

        private void listarCiudades()
        {
            cbCiudad.Items.Clear();
            cbCiudad.DataSource = logCiudad.Instacia.listarCiudad();
            cbCiudad.DisplayMember = "nombre";

        }

        private void listarClientes()
        {
            dtCliente.DataSource = logCliente.Instancia.listarClientes();
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreRepresentante.Text;
            string dni = txtDni.Text;
            bool estado = cbEstadoCliente.Checked;
            string correo = txtCorreo.Text;
            string telefono = txtTelefono.Text;
            string direccion = txtDireccion.Text;
            string ciudad = (cbCiudad.SelectedValue as entCiudad).nombre;
            entCliente cliente = new entCliente();

            cliente.nombreRepresentatne = nombre;
            cliente.dni = dni;
            cliente.estado = estado;
            cliente.correo = correo;
            cliente.telefono = telefono;
            cliente.direccion = direccion;
            cliente.ciudad = ciudad;

            bool ingreso = logCliente.Instancia.agregarCliente(cliente);

            if (ingreso)
            {
                listarClientes();
            }
            else
            {
                MessageBox.Show("error al insertar clientes");
            }
        }

        private void dtCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActular = dtCliente.Rows[e.RowIndex];
            txtId.Text = filaActular.Cells[0].Value.ToString();
            txtNombreRepresentante.Text = filaActular.Cells[1].Value.ToString();
            txtDni.Text = filaActular.Cells[2].Value.ToString();
            cbEstadoCliente.Checked = Convert.ToBoolean(filaActular.Cells[3].Value);
            txtCorreo.Text = filaActular.Cells[4].Value.ToString();
            txtTelefono.Text = filaActular.Cells[5].Value.ToString();
            txtDireccion.Text = filaActular.Cells[6].Value.ToString();

            string nombre = filaActular.Cells[7].Value.ToString();


            cbCiudad.SelectedItem = cbCiudad.Items.Cast<entCiudad>().FirstOrDefault(item => item.nombre == nombre);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            string nombre = txtNombreRepresentante.Text;
            string dni = txtDni.Text;
            bool estado = cbEstadoCliente.Checked;
            string correo = txtCorreo.Text;
            string telefono = txtTelefono.Text;
            string direccion = txtDireccion.Text;
            string ciudad = (cbCiudad.SelectedValue as entCiudad).nombre;
            entCliente cliente = new entCliente();

            cliente.idCliente = id;
            cliente.nombreRepresentatne = nombre;
            cliente.dni = dni;
            cliente.estado = estado;
            cliente.correo = correo;
            cliente.telefono = telefono;
            cliente.direccion = direccion;
            cliente.ciudad = ciudad;


            bool estadoActualizar = logCliente.Instancia.actualizarCliente(cliente);
            if (estadoActualizar)
            {
                listarClientes();
            }





        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string dni = txtBuscar.Text;
            entCliente cliente = logCliente.Instancia.buscarCliente(dni);
            if(cliente.idCliente != 0)
            {
                MessageBox.Show(cliente.nombreRepresentatne);
            }
            else
            {
                MessageBox.Show("No se encontro cliente");
            }
        }
    }
}
