using CapaEntidad.PedidoManCor;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos.PedidoManCor
{
    public class datPedidoManCor
    {
        private static readonly datPedidoManCor _instancia = new datPedidoManCor();

        public static datPedidoManCor Instancia
        {
            get { return _instancia; }
        }

        public List<entPedidoManCor> listarPedidoManCor()
        {
            SqlCommand cmd = null;
            List<entPedidoManCor> lista = new List<entPedidoManCor>();
            try
            {
                SqlConnection cn = Conexion.Instacia.Conectar();
                cn.Open();
                cmd = new SqlCommand("listarPedidoManCor", cn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entPedidoManCor nuevo = new entPedidoManCor();
                    nuevo.id = Convert.ToInt32(dr["idPedidoMan"]);
                    nuevo.recurso = Convert.ToInt32(dr["idRecurso"]);
                    nuevo.nombre = dr["nombre"].ToString();
                    nuevo.fecha = Convert.ToDateTime(dr["fecha"]);
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

        public bool agregarPedidoManCor(entPedidoManCor nuevo)
        {
            SqlCommand cmd = null;
            bool agregar = false;
            try
            {
                SqlConnection cn = Conexion.Instacia.Conectar();
                cn.Open();
                cmd = new SqlCommand("agregarPedidoManCor", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@recurso", nuevo.recurso);
                cmd.Parameters.AddWithValue("@fecha", nuevo.fecha);
                cmd.Parameters.AddWithValue("@estado", nuevo.estado);
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
        public bool deshabilitarPedidoManCor(int id)
        {
            SqlCommand cmd = null;
            bool deshabilitar = false;
            try
            {
                SqlConnection cn = Conexion.Instacia.Conectar();
                cn.Open();
                cmd = new SqlCommand("deshabilitarPedidoManCor", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idPedidoManCor", id);
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

        public int ultimoPedido()
        {
            SqlCommand cmd = null;
            int id = -1;
            try
            {
                SqlConnection cn = Conexion.Instacia.Conectar();
                cn.Open();
                cmd = new SqlCommand("ultimoPedido", cn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    id = Convert.ToInt32(dr["idPedidoMan"]);
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
            return id;
        }
    }
}