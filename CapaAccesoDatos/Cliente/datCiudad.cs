using CapaEntidad.Cliente;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos.Cliente
{
    public class datCiudad
    {
        private static readonly datCiudad _instancia = new datCiudad();

        public static datCiudad Instancia { get { return _instancia; } }

        public List<entCiudad> listarCiudad()
        {
            SqlCommand cmd = null;
            List<entCiudad> lista = new List<entCiudad>();

            try
            {
                SqlConnection cn = Conexion.Instacia.Conectar();
                cn.Open();
                cmd = new SqlCommand("listarCiudades", cn);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    entCiudad ciudad = new entCiudad();
                    ciudad.idCiudad = Convert.ToInt32(dr["idCiudad"]);
                    ciudad.nombre = dr["nombre"].ToString();
                    lista.Add(ciudad);
                }
            }
            catch (Exception ex) { throw ex; }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }

    }
}
