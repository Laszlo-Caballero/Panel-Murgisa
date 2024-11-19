using CapaAccesoDatos;
using CapaEntidad;

namespace CapaLogica
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

        public Boolean agregarCliente(entCliente cliente)
        {
            return datCliente.instacia.agregarCliente(cliente);
        }

        public Boolean deshabilitarCliente(entCliente cliente)
        {
            return datCliente.instacia.deshabilitarCliente(cliente);
        }

        public Boolean actualizarCliente(entCliente cliente)
        {
            return datCliente.instacia.actualizarCliente(cliente);
        }

        public entCliente buscarCliente(string dni)
        {
            return datCliente.instacia.buscarCliente(dni);
        }

    }
}
