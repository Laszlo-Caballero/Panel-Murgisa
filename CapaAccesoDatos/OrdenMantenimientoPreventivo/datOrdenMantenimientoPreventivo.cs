using CapaEntidad.OrdenMantenimientoPreventivo;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos.OrdenMantenimientoPreventivo
{
    public class datOrdenMantenimientoPreventivo
    {
        private static readonly datOrdenMantenimientoPreventivo _instancia = new datOrdenMantenimientoPreventivo();

        public static datOrdenMantenimientoPreventivo Instancia
        {
            get { return _instancia; }
        }

        public List<entOrdenMantenimientoPreventivo> listarOrdenMantenimientoPreventivo()
        {
            SqlCommand cmd = null;
            List<entOrdenMantenimientoPreventivo> lista = new List<entOrdenMantenimientoPreventivo>();
            try
            {
                SqlConnection cn = Conexion.Instacia.Conectar();
                cn.Open();
                cmd = new SqlCommand("listarOrdenMantenimientoPreventivo", cn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entOrdenMantenimientoPreventivo nuevo = new entOrdenMantenimientoPreventivo();
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

        public bool agregarOrdenMantenimientoPreventivo(entOrdenMantenimientoPreventivo nuevo)
        {
            SqlCommand cmd = null;
            bool agregar = false;
            try
            {
                SqlConnection cn = Conexion.Instacia.Conectar();
                cn.Open();
                cmd = new SqlCommand("agregarOrdenMantenimientoPreventivo", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
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

        public bool actualizarOrdenMantenimientoPreventivo(entOrdenMantenimientoPreventivo nuevo)
        {
            SqlCommand cmd = null;
            bool actualizar = false;
            try
            {
                SqlConnection cn = Conexion.Instacia.Conectar();
                cn.Open();
                cmd = new SqlCommand("actualizarOrdenMantenimientoPreventivo", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                int rows = cmd.ExecuteNonQuery();
                actualizar = rows >= 1;
            }
            catch (Exception ex) { 
                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return actualizar;
        }

        public bool deshabilitarOrdenMantenimientoPreventivo(int id)
        {
            SqlCommand cmd = null;
            bool deshabilitar = false;
            try
            {
                SqlConnection cn = Conexion.Instacia.Conectar();
                cn.Open();
                cmd = new SqlCommand("deshabilitarOrdenMantenimientoPreventivo", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idOrdenMantenimientoPreventivo", id);
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