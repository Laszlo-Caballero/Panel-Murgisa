using CapaEntidad.Personal;
using CapaEntidad.Recurso;
using CapaEntidad.Venta;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos.Venta
{
    public class datVenta
    {
        private static readonly datVenta _instancia = new datVenta();

        public static datVenta Instancia
        {
            get { return _instancia; }
        }

        public List<entVentaVista> listarVenta()
        {
            SqlCommand cmd = null;
            List<entVentaVista> lista = new List<entVentaVista>();
            try
            {
                SqlConnection cn = Conexion.Instacia.Conectar();
                cn.Open();
                cmd = new SqlCommand("listarVenta", cn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entVentaVista nuevo = new entVentaVista();
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

        public bool agregarVenta(entVenta nuevo)
        {
            SqlCommand cmd = null;
            SqlCommand cmdId = null;
            bool agregar = false;
            try
            {
                SqlConnection cn = Conexion.Instacia.Conectar();
                cn.Open();
                cmd = new SqlCommand("agregarVenta", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idServicio", nuevo.idServicio);
                cmd.Parameters.AddWithValue("@idCliente", nuevo.idCliente);
                cmd.Parameters.AddWithValue("@fechaInicio", nuevo.fIncioServicio);
                cmd.Parameters.AddWithValue("@fechaFin", nuevo.fFinServicio);
                cmd.Parameters.AddWithValue("@fechaVenta", nuevo.fechaVenta);
                cmd.Parameters.AddWithValue("@estado", nuevo.estado);
                int rows = cmd.ExecuteNonQuery();
                int id = 0;
                cmdId = new SqlCommand("buscarUltimaVenta", cn);
                SqlDataReader dr1 = cmdId.ExecuteReader();
                while (dr1.Read()) {
                    id = Convert.ToInt32(dr1["idVenta"]);
                }

                dr1.Close();

                foreach (entRecurso r in nuevo.recursos)
                {
                    cmd = new SqlCommand("agergarDetalleRecurso", cn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idVenta", id);
                    cmd.Parameters.AddWithValue("@idRecurso", r.idRecurso);
                    cmd.Parameters.AddWithValue("@cantidad", r.cantidad);
                    cmd.Parameters.AddWithValue("@precio", r.precio);
                    int rowsd = cmd.ExecuteNonQuery();
                }

                foreach (entPersonalVista p in nuevo.personal) {
                    cmd = new SqlCommand("agregarAsignacionPersonal", cn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idVenta", id);
                    cmd.Parameters.AddWithValue("@idPersonal", p.id);
                    float costo = p.sueldo / 4;
                    cmd.Parameters.AddWithValue("@costo", costo);
                    int rowsp = cmd.ExecuteNonQuery(); 
                }               
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

        public bool deshabilitarVenta(int id)
        {
            SqlCommand cmd = null;
            bool deshabilitar = false;
            try
            {
                SqlConnection cn = Conexion.Instacia.Conectar();
                cn.Open();
                cmd = new SqlCommand("deshabilitarVenta", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idVenta", id);
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

        public List<entVenta> listarVentaCliente(int id)
        {
            SqlCommand cmd = null;
            List<entVenta> lista = new List<entVenta>();
            try
            {
                SqlConnection cn = Conexion.Instacia.Conectar();
                cn.Open();
                cmd = new SqlCommand("listarVentaCliente", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idCliente", id);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entVenta nuevo = new entVenta();
                    nuevo.idVenta = Convert.ToInt32(dr["idVenta"]);
                    nuevo.idServicio = Convert.ToInt32(dr["idServicio"]);
                    nuevo.idCliente = Convert.ToInt32(dr["idCliente"]);
                    nuevo.fIncioServicio = Convert.ToDateTime(dr["fechaInicioServicio"]);
                    nuevo.fFinServicio = Convert.ToDateTime(dr["fechaFFinServicio"]);
                    nuevo.fechaVenta = Convert.ToDateTime(dr["fechaVenta"]);
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
    }
}