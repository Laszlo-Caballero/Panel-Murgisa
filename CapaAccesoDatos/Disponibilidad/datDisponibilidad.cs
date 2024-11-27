using CapaEntidad.Disponibilidad;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos.Disponibilidad
{
    public class datDisponibilidad
    {
        private static readonly datDisponibilidad _instancia = new datDisponibilidad();

        public static datDisponibilidad Instancia
        {
            get { return _instancia; }
        }

        public List<entDisponibilidad> listarDisponibilidad()
        {
            SqlCommand cmd = null;
            List<entDisponibilidad> lista = new List<entDisponibilidad>();
            try
            {
                SqlConnection cn = Conexion.Instacia.Conectar();
                cn.Open();
                cmd = new SqlCommand("listarDisponibilidad", cn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entDisponibilidad disponibilidad = new entDisponibilidad();
                    disponibilidad.idDisponibilidad = Convert.ToInt32(dr["idDisponibilidad"]);
                    disponibilidad.disponibilidad = dr["disponibilidad"].ToString();
                    disponibilidad.estado = Convert.ToBoolean(dr["estado"]);
                    lista.Add(disponibilidad);
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

        public bool agregarDisponibilidad(entDisponibilidad disponibilidad)
        {
            SqlCommand cmd = null;
            bool agregar = false;
            try
            {
                SqlConnection cn = Conexion.Instacia.Conectar();
                cn.Open();
                cmd = new SqlCommand("agregarDisponibilidad", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@disponibilidad", disponibilidad.disponibilidad);
                cmd.Parameters.AddWithValue("@estado", disponibilidad.estado);

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

        public bool actualizarDisponibilidad(entDisponibilidad disponibilidad)
        {
            SqlCommand cmd = null;
            bool actualizar = false;
            try
            {
                SqlConnection cn = Conexion.Instacia.Conectar();
                cn.Open();
                cmd = new SqlCommand("actualizarDisponibilidad", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@disponibilidad", disponibilidad.disponibilidad);
                cmd.Parameters.AddWithValue("@estado", disponibilidad.estado);

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

        public bool deshabilitarDisponibilidad(entDisponibilidad disponibilidad)
        {
            SqlCommand cmd = null;
            bool deshabilitar = false;
            try
            {
                SqlConnection cn = Conexion.Instacia.Conectar();
                cn.Open();
                cmd = new SqlCommand("deshabilitarDisponibilidad", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idDisponibilidad", disponibilidad.idDisponibilidad);
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