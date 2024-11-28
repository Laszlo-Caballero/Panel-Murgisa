using CapaEntidad.PedidoManCor;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos.PedidoManCor
{
    public class datDetPedidoCorr
    {
        private static readonly datDetPedidoCorr _instancia = new datDetPedidoCorr();

        public static datDetPedidoCorr Instancia
        {
            get { return _instancia; }
        }

        public bool agregarDetOrdenCorr(List<entDetPedidoCorr> detalle, int id)
        {
            SqlCommand cmd = null;
            bool agregar = false;
            try
            {
                SqlConnection cn = Conexion.Instacia.Conectar();
                cn.Open();
                foreach(entDetPedidoCorr item in detalle)
                {
                    cmd = new SqlCommand("agregarDetallePedido", cn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@pedido", id);
                    cmd.Parameters.AddWithValue("@tipo", item.mantenimiento);
                    cmd.Parameters.AddWithValue("@estado", item.estado);
                    int rows = cmd.ExecuteNonQuery();
                    if (rows == 0)
                        break;
                }
                agregar = true;
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
        public bool deshabilitarDetOrdenCorr(int id)
        {
            SqlCommand cmd = null;
            bool deshabilitar = false;
            try
            {
                SqlConnection cn = Conexion.Instacia.Conectar();
                cn.Open();
                cmd = new SqlCommand("deshabilitarDetOrdenCorr", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idDetOrdenCorr", id);
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