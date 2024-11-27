using CapaEntidad.PagoServicio;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos.PagoServicio
{
    public class datPagoServicio
    {
        private static readonly datPagoServicio _instancia = new datPagoServicio();

        public static datPagoServicio Instancia
        {
            get { return _instancia; }
        }

        public List<entPagoServicio> listarPagoServicio()
        {
            SqlCommand cmd = null;
            List<entPagoServicio> lista = new List<entPagoServicio>();
            try
            {
                SqlConnection cn = Conexion.Instacia.Conectar();
                cn.Open();
                cmd = new SqlCommand("listarPagoServicio", cn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entPagoServicio nuevo = new entPagoServicio();
                    nuevo.id = Convert.ToInt32(dr["idPago_Servicio"]);
                    nuevo.idVenta = Convert.ToInt32(dr["idVenta"]);
                    nuevo.nombre = dr["nombre"].ToString();
                    nuevo.dni = dr["dni"].ToString();
                    nuevo.correo = dr["correo"].ToString();
                    nuevo.tipo = dr["tipo"].ToString();
                    nuevo.total = Convert.ToInt32(dr["total"]);
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

        public bool agregarPagoServicio(entPagoServicio nuevo)
        {
            SqlCommand cmd = null;
            bool agregar = false;
            try
            {
                SqlConnection cn = Conexion.Instacia.Conectar();
                cn.Open();
                cmd = new SqlCommand("agregarPagoServicio", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idVenta", nuevo.idVenta);
                cmd.Parameters.AddWithValue("@fecha", nuevo.fecha);
                cmd.Parameters.AddWithValue("@idFormaPago", nuevo.idFormaPago);
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

        public bool deshabilitarPagoServicio(int id)
        {
            SqlCommand cmd = null;
            bool deshabilitar = false;
            try
            {
                SqlConnection cn = Conexion.Instacia.Conectar();
                cn.Open();
                cmd = new SqlCommand("deshabilitarPagoServicio", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idPagoServicio", id);
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