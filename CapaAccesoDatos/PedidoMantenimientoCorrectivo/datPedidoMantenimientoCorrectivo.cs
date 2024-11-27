using CapaEntidad.PedidoMantenimientoCorrectivo;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos.PedidoMantenimientoCorrectivo
{
    public class datPedidoMantenimientoCorrectivo
    {
        private static readonly datPedidoMantenimientoCorrectivo _instancia = new datPedidoMantenimientoCorrectivo();

        public static datPedidoMantenimientoCorrectivo Instancia
        {
            get { return _instancia; }
        }

        public List<entPedidoMantenimientoCorrectivo> listarPedidoMantenimientoCorrectivo()
        {
            SqlCommand cmd = null;
            List<entPedidoMantenimientoCorrectivo> lista = new List<entPedidoMantenimientoCorrectivo>();
            try
            {
                SqlConnection cn = Conexion.Instacia.Conectar();
                cn.Open();
                cmd = new SqlCommand("listarPedidoMantenimientoCorrectivo", cn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entPedidoMantenimientoCorrectivo nuevo = new entPedidoMantenimientoCorrectivo();
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

        public bool agregarPedidoMantenimientoCorrectivo(entPedidoMantenimientoCorrectivo nuevo)
        {
            SqlCommand cmd = null;
            bool agregar = false;
            try
            {
                SqlConnection cn = Conexion.Instacia.Conectar();
                cn.Open();
                cmd = new SqlCommand("agregarPedidoMantenimientoCorrectivo", cn);
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

        public bool actualizarPedidoMantenimientoCorrectivo(entPedidoMantenimientoCorrectivo nuevo)
        {
            SqlCommand cmd = null;
            bool actualizar = false;
            try
            {
                SqlConnection cn = Conexion.Instacia.Conectar();
                cn.Open();
                cmd = new SqlCommand("actualizarPedidoMantenimientoCorrectivo", cn);
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

        public bool deshabilitarPedidoMantenimientoCorrectivo(int id)
        {
            SqlCommand cmd = null;
            bool deshabilitar = false;
            try
            {
                SqlConnection cn = Conexion.Instacia.Conectar();
                cn.Open();
                cmd = new SqlCommand("deshabilitarPedidoMantenimientoCorrectivo", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idPedidoMantenimientoCorrectivo", id);
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