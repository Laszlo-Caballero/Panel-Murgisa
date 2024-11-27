using CapaAccesoDatos.Cliente;
using CapaEntidad.Cliente;

namespace CapaLogica.Cliente
{
    public class logCliente
    {
        private static readonly logCliente _instancia = new logCliente();

        public static logCliente Instancia
        {
            get { return _instancia; }
        }

        public List<entCliente> listarClientes()
        {
            return datCliente.instacia.listaClientes();
        }

        public bool agregarCliente(entCliente cliente)
        {
            return datCliente.instacia.agregarCliente(cliente);
        }

        public bool deshabilitarCliente(entCliente cliente)
        {
            return datCliente.instacia.deshabilitarCliente(cliente);
        }

        public bool actualizarCliente(entCliente cliente)
        {
            return datCliente.instacia.actualizarCliente(cliente);
        }

        public entCliente buscarCliente(string dni)
        {
            return datCliente.instacia.buscarCliente(dni);
        }

    }
}
