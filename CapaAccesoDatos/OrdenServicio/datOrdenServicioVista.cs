using CapaEntidad.OrdenServicio;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos.OrdenServicio
{
    public class datOrdenServicioVista
    {
        private static readonly datOrdenServicio _instancia = new datOrdenServicio();

        public static datOrdenServicio Instancia
        {
            get { return _instancia; }
        }

        public List<entOrdenServicio> listarOrdenServicio()
        {
            SqlCommand cmd = null;
            List<entOrdenServicio> lista = new List<entOrdenServicio>();
            try
            {
                SqlConnection cn = Conexion.Instacia.Conectar();
                cn.Open();
                cmd = new SqlCommand("listarOrdenServicio", cn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entOrdenServicio nuevo = new entOrdenServicio();
                    lista.Add(nuevo);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }
    }
}
