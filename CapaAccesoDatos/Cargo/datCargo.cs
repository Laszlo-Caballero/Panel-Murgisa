using CapaEntidad.Cargo;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos.Cargo
{
    public class datCargo
    {
        private static readonly datCargo _instancia = new datCargo();

        public static datCargo Instancia
        {
            get { return _instancia; }
        }

        public List<entCargo> listarCargo()
        {
            SqlCommand cmd = null;
            List<entCargo> lista = new List<entCargo>();
            try
            {
                SqlConnection cn = Conexion.Instacia.Conectar();
                cn.Open();
                cmd = new SqlCommand("listarCargo", cn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entCargo nuevo = new entCargo();
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

        public bool agregarCargo(entCargo nuevo)
        {
            SqlCommand cmd = null;
            bool agregar = false;
            try
            {
                SqlConnection cn = Conexion.Instacia.Conectar();
                cn.Open();
                cmd = new SqlCommand("agregarCargo", cn);
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

        public bool actualizarCargo(entCargo nuevo)
        {
            SqlCommand cmd = null;
            bool actualizar = false;
            try
            {
                SqlConnection cn = Conexion.Instacia.Conectar();
                cn.Open();
                cmd = new SqlCommand("actualizarCargo", cn);
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

        public bool deshabilitarCargo(int id)
        {
            SqlCommand cmd = null;
            bool deshabilitar = false;
            try
            {
                SqlConnection cn = Conexion.Instacia.Conectar();
                cn.Open();
                cmd = new SqlCommand("deshabilitarCargo", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idCargo", id);
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