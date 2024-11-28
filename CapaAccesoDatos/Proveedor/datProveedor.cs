using CapaEntidad.Proveedor;
using CapaEntidad.Recurso;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos.Proveedor
{
    public class datProveedor
    {
        private static readonly datProveedor _instancia = new datProveedor();

        public static datProveedor Instancia
        {
            get { return _instancia; }
        }

        public List<entProveedor> listarProveedor()
        {
            SqlCommand cmd = null;
            List<entProveedor> lista = new List<entProveedor>();
            try
            {
                SqlConnection cn = Conexion.Instacia.Conectar();
                cn.Open();
                cmd = new SqlCommand("listarProveedor", cn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entProveedor nuevo = new entProveedor();
                    nuevo.idProveedor = Convert.ToInt32(dr["idRecurso"]);
                    nuevo.razsocial = dr["razSocial"].ToString();
                    nuevo.ruc = dr["ruc"].ToString();
                    nuevo.estado = Convert.ToBoolean(dr["estado"]);
                    lista.Add(nuevo);
                   
                }
            }
            catch (Exception ex) {
                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }

        public bool deshabilitarProveedor(int id)
        {
            SqlCommand cmd = null;
            bool deshabilitar = false;
            try
            {
                SqlConnection cn = Conexion.Instacia.Conectar();
                cn.Open();
                cmd = new SqlCommand("deshabilitarProveedor", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idProveedor", id);
                int rows = cmd.ExecuteNonQuery();
                deshabilitar = rows >= 1;
            }
            catch (Exception ex) { throw ex; }
            finally
            {
                cmd.Connection.Close();
            }
            return deshabilitar;
        }

        public entProveedor buscar(int id)
        {
            SqlCommand cmd = null;
            entProveedor proveedor = new entProveedor();

            try
            {
                SqlConnection cn = Conexion.Instacia.Conectar();
                cn.Open();

                cmd = new SqlCommand("buscarProveedor", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    proveedor.idProveedor = Convert.ToInt32(dr["idProveedor"]);
                    proveedor.razsocial = dr["razSocial"].ToString();
                    proveedor.ruc = dr["ruc"].ToString();
                    proveedor.estado = Convert.ToBoolean(dr["estado"]);
                }
            }
            catch (Exception ex) { return null; }
            finally
            {
                cmd.Connection.Close();
            }
            return proveedor;

        }
    }
}