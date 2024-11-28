using CapaEntidad.Servicio.Servicios;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos.Servicio.Servicios
{
    public class datServicios
    {
        private static readonly datServicios _instancia = new datServicios();

        public static datServicios Instancia
        {
            get { return _instancia; }
        }

        public List<entServicios> listarServicios()
        {
            SqlCommand cmd = null;
            List<entServicios> lista = new List<entServicios>();
            try
            {
                SqlConnection cn = Conexion.Instacia.Conectar();
                cn.Open();
                cmd = new SqlCommand("listarServicios", cn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entServicios servicio = new entServicios();
                    servicio.idServicio = Convert.ToInt32(dr["idServicio"]);
                    servicio.nombre = dr["nombre"].ToString();
                    servicio.precio = float.Parse(dr["precio"].ToString());
                    servicio.estado = Convert.ToBoolean(dr["estado"]);
                    lista.Add(servicio);
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

        public bool agregarServicio(entServicios servicio)
        {
            SqlCommand cmd = null;
            bool agregar = false;
            try
            {
                SqlConnection cn = Conexion.Instacia.Conectar();
                cn.Open();
                cmd = new SqlCommand("agregarServicio", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", servicio.nombre);
                cmd.Parameters.AddWithValue("@precio", servicio.precio);
                cmd.Parameters.AddWithValue("@estado", servicio.estado);
                int rows = cmd.ExecuteNonQuery();
                agregar = rows >= 1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return agregar;
        }

        public bool actualizarServicio(entServicios servicio)
        {
            SqlCommand cmd = null;
            bool actualizar = false;
            try
            {
                SqlConnection cn = Conexion.Instacia.Conectar();
                cn.Open();
                cmd = new SqlCommand("actualizarServicio", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idServicio", servicio.idServicio);
                cmd.Parameters.AddWithValue("@nombre", servicio.nombre);
                cmd.Parameters.AddWithValue("@precio", servicio.precio);
                cmd.Parameters.AddWithValue("@estado", servicio.estado);
                int rows = cmd.ExecuteNonQuery();
                actualizar = rows >= 1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return actualizar;
        }
        public bool deshabilitarServicio(int id)
        {
            SqlCommand cmd = null;
            bool deshabilitar = false;
            try
            {
                SqlConnection cn = Conexion.Instacia.Conectar();
                cn.Open();
                cmd = new SqlCommand("deshabilitarServicio", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idServicio", id);
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
    }
}