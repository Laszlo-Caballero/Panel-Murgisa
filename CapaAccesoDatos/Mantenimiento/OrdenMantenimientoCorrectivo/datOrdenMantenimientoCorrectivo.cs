using CapaEntidad.OrdenMantenimientoCorrectivo;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos.Mantenimiento.OrdenMantenimientoCorrectivo
{
    public class datOrdenMantenimientoCorrectivo
    {
        private static readonly datOrdenMantenimientoCorrectivo _instancia = new datOrdenMantenimientoCorrectivo();

        public static datOrdenMantenimientoCorrectivo Instancia
        {
            get { return _instancia; }
        }

        public List<entOrdenMantenimientoCorrectivo> listarOrdenMantenimientoCorrectivo()
        {
            SqlCommand cmd = null;
            List<entOrdenMantenimientoCorrectivo> lista = new List<entOrdenMantenimientoCorrectivo>();
            try
            {
                SqlConnection cn = Conexion.Instacia.Conectar();
                cn.Open();
                cmd = new SqlCommand("listarOrdenMantenimientoCorrectivo", cn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entOrdenMantenimientoCorrectivo nuevo = new entOrdenMantenimientoCorrectivo();
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

        public bool agregarOrdenMantenimientoCorrectivo(entOrdenMantenimientoCorrectivo nuevo)
        {
            SqlCommand cmd = null;
            bool agregar = false;
            try
            {
                SqlConnection cn = Conexion.Instacia.Conectar();
                cn.Open();
                cmd = new SqlCommand("agregarOrdenMantenimientoCorrectivo", cn);
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

        public bool actualizarOrdenMantenimientoCorrectivo(entOrdenMantenimientoCorrectivo nuevo)
        {
            SqlCommand cmd = null;
            bool actualizar = false;
            try
            {
                SqlConnection cn = Conexion.Instacia.Conectar();
                cn.Open();
                cmd = new SqlCommand("actualizarOrdenMantenimientoCorrectivo", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
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

        public bool deshabilitarOrdenMantenimientoCorrectivo(int id)
        {
            SqlCommand cmd = null;
            bool deshabilitar = false;
            try
            {
                SqlConnection cn = Conexion.Instacia.Conectar();
                cn.Open();
                cmd = new SqlCommand("deshabilitarOrdenMantenimientoCorrectivo", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idOrdenMantenimientoCorrectivo", id);
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