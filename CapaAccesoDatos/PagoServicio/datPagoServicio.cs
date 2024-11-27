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

        public bool actualizarPagoServicio(entPagoServicio nuevo)
        {
            SqlCommand cmd = null;
            bool actualizar = false;
            try
            {
                SqlConnection cn = Conexion.Instacia.Conectar();
                cn.Open();
                cmd = new SqlCommand("actualizarPagoServicio", cn);
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