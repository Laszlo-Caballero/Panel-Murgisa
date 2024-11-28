using CapaAccesoDatos.Servicio.Venta;
using CapaEntidad.Servicio.OrdenServicio;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos.Servicio.OrdenServicio
{
    public class datOrdenServicio
    {
        private static readonly datOrdenServicio _instancia = new datOrdenServicio();

        public static datOrdenServicio Instancia
        {
            get { return _instancia; }
        }

        public List<entOrdenServicioVista> listarOrdenServicio()
        {
            SqlCommand cmd = null;
            List<entOrdenServicioVista> lista = new List<entOrdenServicioVista>();
            try
            {
                SqlConnection cn = Conexion.Instacia.Conectar();
                cn.Open();
                cmd = new SqlCommand("listarOrdenServicio", cn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entOrdenServicioVista nuevo = new entOrdenServicioVista();
                    nuevo.id = Convert.ToInt32(dr["idOrdenServicio"]);
                    nuevo.venta = Convert.ToInt32(dr["idVenta"]);
                    nuevo.nombre = dr["nombreRepresentante"].ToString();
                    nuevo.dni = dr["dni"].ToString();
                    nuevo.estado = Convert.ToBoolean(dr["estado"]);
                    nuevo.fecha = Convert.ToDateTime(dr["fechaRegistro"]);
                    lista.Add(nuevo);
                }
                dr.Close();
                foreach (entOrdenServicioVista o in lista)
                {
                    o.recursos = datVenta.Instancia.listarDetalleVenta(o.venta);
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

        public bool agregarOrdenServicio(entOrdenServicio nuevo)
        {
            SqlCommand cmd = null;
            bool agregar = false;
            try
            {
                SqlConnection cn = Conexion.Instacia.Conectar();
                cn.Open();
                cmd = new SqlCommand("agregarOrdenServicio", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idVenta", nuevo.idVenta);
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

        public bool deshabilitarOrdenServicio(int id)
        {
            SqlCommand cmd = null;
            bool deshabilitar = false;
            try
            {
                SqlConnection cn = Conexion.Instacia.Conectar();
                cn.Open();
                cmd = new SqlCommand("deshabilitarOrdenServicio", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idOrden", id);
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