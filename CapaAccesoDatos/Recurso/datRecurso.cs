using CapaEntidad.Recurso;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos.Recurso
{
    public class datRecurso
    {
        private static readonly datRecurso _instancia = new datRecurso();

        public static datRecurso Instancia
        {
            get { return _instancia; }
        }

        public List<entRecurso> listarRecurso()
        {
            SqlCommand cmd = null;
            List<entRecurso> lista = new List<entRecurso>();
            try
            {
                SqlConnection cn = Conexion.Instacia.Conectar();
                cn.Open();
                cmd = new SqlCommand("listarRecurso", cn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entRecurso nuevo = new entRecurso();
                    nuevo.idRecurso = Convert.ToInt32(dr["idRecurso"]);
                    nuevo.idTipoRecurso = Convert.ToInt32(dr["idTipoRecurso"]);
                    nuevo.idDisponiblidad = Convert.ToInt32(dr["idDisponibilidad"]);
                    nuevo.idCondicion = Convert.ToInt32(dr["idCondicion"]);
                    nuevo.idProveedor = Convert.ToInt32(dr["idProveedor"]);
                    nuevo.nombre = dr["nombre"].ToString();
                    nuevo.estado = Convert.ToBoolean(dr["estado"]);
                    nuevo.precio = float.Parse(dr["precio"].ToString());
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

        public List<entRecurso> listarRecursoTipo(entTipoRecurso tipo)
        {
            SqlCommand cmd = null;
            List<entRecurso> lista = new List<entRecurso>();
            try
            {
                SqlConnection cn = Conexion.Instacia.Conectar();
                cn.Open();
                cmd = new SqlCommand("listarRecursoTipo", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idTipo", tipo.idTipoRecurso);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entRecurso nuevo = new entRecurso();
                    nuevo.idRecurso = Convert.ToInt32(dr["idRecurso"]);
                    nuevo.idTipoRecurso = Convert.ToInt32(dr["idTipoRecurso"]);
                    nuevo.idDisponiblidad = Convert.ToInt32(dr["idDisponibilidad"]);
                    nuevo.idCondicion = Convert.ToInt32(dr["idCondicion"]);
                    nuevo.idProveedor = Convert.ToInt32(dr["idProveedor"]);
                    nuevo.nombre = dr["nombre"].ToString();
                    nuevo.estado = Convert.ToBoolean(dr["estado"]);
                    nuevo.precio = float.Parse(dr["precio"].ToString());
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

        public List<entRecurso> listarMaquinaria()
        {
            SqlCommand cmd = null;
            List<entRecurso> lista = new List<entRecurso>();
            try
            {
                SqlConnection cn = Conexion.Instacia.Conectar();
                cn.Open();
                cmd = new SqlCommand("listarMaquinaria", cn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entRecurso nuevo = new entRecurso();
                    nuevo.idRecurso = Convert.ToInt32(dr["idRecurso"]);
                    nuevo.idTipoRecurso = Convert.ToInt32(dr["idTipoRecurso"]);
                    nuevo.idDisponiblidad = Convert.ToInt32(dr["idDisponibilidad"]);
                    nuevo.idCondicion = Convert.ToInt32(dr["idCondicion"]);
                    nuevo.idProveedor = Convert.ToInt32(dr["idProveedor"]);
                    nuevo.nombre = dr["nombre"].ToString();
                    nuevo.estado = Convert.ToBoolean(dr["estado"]);
                    nuevo.precio = float.Parse(dr["precio"].ToString());
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

        public entRecurso buscar(int id)
        {
            SqlCommand cmd = null;
            entRecurso recurso = new entRecurso();

            try
            {
                SqlConnection cn = Conexion.Instacia.Conectar();
                cn.Open();

                cmd = new SqlCommand("buscarMaquinaria", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    recurso.idRecurso = Convert.ToInt32(dr["idRecurso"]);
                    recurso.idTipoRecurso = Convert.ToInt32(dr["idTipoRecurso"]);
                    recurso.idDisponiblidad = Convert.ToInt32(dr["idDisponibilidad"]);
                    recurso.idCondicion = Convert.ToInt32(dr["idCondicion"]);
                    recurso.idProveedor = Convert.ToInt32(dr["idProveedor"]);
                    recurso.nombre = dr["nombre"].ToString();
                    recurso.estado = Convert.ToBoolean(dr["estado"]);
                    recurso.precio = float.Parse(dr["precio"].ToString());
                }
            }
            catch (Exception ex) { return null; }
            finally
            {
                cmd.Connection.Close();
            }
            return recurso;

        }

    }
}