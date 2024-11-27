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

        public List<entVenta> listarVenta()
        {
            SqlCommand cmd = null;
            List<entVenta> lista = new List<entVenta>();
            try
            {
                SqlConnection cn = Conexion.Instacia.Conectar();
                cn.Open();
                cmd = new SqlCommand("listarVenta", cn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entVenta nuevo = new entVenta();
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
            bool agregar = false;
            try
            {
                SqlConnection cn = Conexion.Instacia.Conectar();
                cn.Open();
                cmd = new SqlCommand("agregarVenta", cn);
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
    }
}