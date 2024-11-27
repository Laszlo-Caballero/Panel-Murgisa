using CapaEntidad.Departamento;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos.Departamento
{
    public class datDepartamento
    {
        private static readonly datDepartamento _instancia = new datDepartamento();

        public static datDepartamento Instancia
        {
            get { return _instancia; }
        }

        public List<entDepartamento> listarDepartamento()
        {
            SqlCommand cmd = null;
            List<entDepartamento> lista = new List<entDepartamento>();
            try
            {
                SqlConnection cn = Conexion.Instacia.Conectar();
                cn.Open();
                cmd = new SqlCommand("listarDepartamento", cn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entDepartamento nuevo = new entDepartamento();
                    nuevo.id = Convert.ToInt32(dr["idDepartamento"]);
                    nuevo.nombre = dr["nombre"].ToString();
                    nuevo.desc = dr["descripcion"].ToString();
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

        public bool agregarDepartamento(entDepartamento nuevo)
        {
            SqlCommand cmd = null;
            bool agregar = false;
            try
            {
                SqlConnection cn = Conexion.Instacia.Conectar();
                cn.Open();
                cmd = new SqlCommand("agregarDepartamento", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", nuevo.nombre);
                cmd.Parameters.AddWithValue("@descripcion", nuevo.desc);
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

        public bool actualizarDepartamento(entDepartamento nuevo)
        {
            SqlCommand cmd = null;
            bool actualizar = false;
            try
            {
                SqlConnection cn = Conexion.Instacia.Conectar();
                cn.Open();
                cmd = new SqlCommand("actualizarDepartamento", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idDepartamento", nuevo.id);
                cmd.Parameters.AddWithValue("@nombre", nuevo.nombre);
                cmd.Parameters.AddWithValue("@descripcion", nuevo.desc);
                cmd.Parameters.AddWithValue("@estado", nuevo.estado);
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

        public bool deshabilitarDepartamento(int id)
        {
            SqlCommand cmd = null;
            bool deshabilitar = false;
            try
            {
                SqlConnection cn = Conexion.Instacia.Conectar();
                cn.Open();
                cmd = new SqlCommand("deshabilitarDepartamento", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idDepartamento", id);
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