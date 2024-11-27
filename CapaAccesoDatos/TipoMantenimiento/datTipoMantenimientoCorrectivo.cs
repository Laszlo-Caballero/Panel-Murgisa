using CapaEntidad.TipoMantenimiento;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos.TipoMantenimiento
{
    public class datTipoMantenimientoCorrectivo
    {
        private static readonly datTipoMantenimientoCorrectivo _instancia = new datTipoMantenimientoCorrectivo();

        public static datTipoMantenimientoCorrectivo Instancia
        {
            get { return _instancia; }
        }

        public List<entTipoMantenimientoCorrectivo> listarTipoMantenimientoCorrectivo()
        {
            SqlCommand cmd = null;
            List<entTipoMantenimientoCorrectivo> lista = new List<entTipoMantenimientoCorrectivo>();
            try
            {
                SqlConnection cn = Conexion.Instacia.Conectar();
                cn.Open();
                cmd = new SqlCommand("listarTipoMantenimientoCorrectivo", cn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entTipoMantenimientoCorrectivo nuevo = new entTipoMantenimientoCorrectivo();
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

        public bool agregarTipoMantenimientoCorrectivo(entTipoMantenimientoCorrectivo nuevo)
        {
            SqlCommand cmd = null;
            bool agregar = false;
            try
            {
                SqlConnection cn = Conexion.Instacia.Conectar();
                cn.Open();
                cmd = new SqlCommand("agregarTipoMantenimientoCorrectivo", cn);
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

        public bool actualizarTipoMantenimientoCorrectivo(entTipoMantenimientoCorrectivo nuevo)
        {
            SqlCommand cmd = null;
            bool actualizar = false;
            try
            {
                SqlConnection cn = Conexion.Instacia.Conectar();
                cn.Open();
                cmd = new SqlCommand("actualizarTipoMantenimientoCorrectivo", cn);
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

        public bool deshabilitarTipoMantenimientoCorrectivo(int id)
        {
            SqlCommand cmd = null;
            bool deshabilitar = false;
            try
            {
                SqlConnection cn = Conexion.Instacia.Conectar();
                cn.Open();
                cmd = new SqlCommand("deshabilitarTipoMantenimientoCorrectivo", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idTipoMantenimientoCorrectivo", id);
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