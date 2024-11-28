using CapaEntidad.Mantenimiento.OrdenManCorr;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos.Mantenimiento.OrdenManCorr
{
    public class datOrdenManCorr
    {
        private static readonly datOrdenManCorr _instancia = new datOrdenManCorr();

        public static datOrdenManCorr Instancia
        {
            get { return _instancia; }
        }

        public List<entOrdenManCorr> listarOrdenManCorr()
        {
            SqlCommand cmd = null;
            List<entOrdenManCorr> lista = new List<entOrdenManCorr>();
            try
            {
                SqlConnection cn = Conexion.Instacia.Conectar();
                cn.Open();
                cmd = new SqlCommand("listarOrdenManCorr", cn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entOrdenManCorr nuevo = new entOrdenManCorr();
                    nuevo.id = Convert.ToInt32(dr["idOrdenManCor"]);
                    nuevo.pedido = Convert.ToInt32(dr["idPedido"]);
                    nuevo.maquinaria = dr["nombre"].ToString();
                    nuevo.proveedor = dr["razSocial"].ToString();
                    nuevo.ruc = dr["ruc"].ToString();
                    nuevo.fecha = Convert.ToDateTime(dr["fecha"]);
                    nuevo.estado = Convert.ToBoolean(dr["estado"]);
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

        public bool agregarOrdenManCorr(entOrdenManCorr nuevo)
        {
            SqlCommand cmd = null;
            bool agregar = false;
            try
            {
                SqlConnection cn = Conexion.Instacia.Conectar();
                cn.Open();
                cmd = new SqlCommand("agregarOrdenManCorr", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idPedido", nuevo.pedido);
                cmd.Parameters.AddWithValue("@estado", nuevo.estado);
                cmd.Parameters.AddWithValue("@fecha", nuevo.fecha);
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
        public bool deshabilitarOrdenManCorr(int id)
        {
            SqlCommand cmd = null;
            bool deshabilitar = false;
            try
            {
                SqlConnection cn = Conexion.Instacia.Conectar();
                cn.Open();
                cmd = new SqlCommand("deshabilitarOrdenManCorr", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idOrdenManCorr", id);
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