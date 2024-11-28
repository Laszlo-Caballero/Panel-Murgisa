using CapaEntidad.MantenimientoPlanificacion;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos.MantenimientoPlanificacion
{
    public class datMantenimientoPlanificacion
    {
        private static readonly datMantenimientoPlanificacion _instancia = new datMantenimientoPlanificacion();

        public static datMantenimientoPlanificacion Instancia
        {
            get { return _instancia; }
        }
        public DataTable listarMantenimientoPlanificacionParaGrid(int? idPlanificacion = null, DateTime? fechaMantenimiento = null)
        {
            SqlCommand cmd = null;
            DataTable dt = new DataTable();
            try
            {
                SqlConnection cn = Conexion.Instacia.Conectar();
                cn.Open();

                cmd = new SqlCommand("listarMantenimientoPlanificacion", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdPlanificacion", (object)idPlanificacion ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@FechaMantenimiento", (object)fechaMantenimiento ?? DBNull.Value);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return dt;
        }



        public List<entMantenimientoPlanificacion> listarMantenimientoPlanificacion()
        {
            SqlCommand cmd = null;
            List<entMantenimientoPlanificacion> lista = new List<entMantenimientoPlanificacion>();
            try
            {
                SqlConnection cn = Conexion.Instacia.Conectar();
                cn.Open();
                cmd = new SqlCommand("listarMantenimientoPlanificacion", cn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entMantenimientoPlanificacion nuevo = new entMantenimientoPlanificacion();
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
        public entMantenimientoPlanificacion buscarPorId(int id)
        {
            SqlCommand cmd = null;
            entMantenimientoPlanificacion entMantenimiento = null; 
            try
            {
                SqlConnection cn = Conexion.Instacia.Conectar();
                cn.Open();
                cmd = new SqlCommand("mantenimientoPlanificacion_buscarXId", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdPlanificacion", id);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    entMantenimiento = new entMantenimientoPlanificacion
                    {
                        IdPlanificacion = Convert.ToInt32(dr["IdPlanificacion"]),
                        IdRecurso = dr["IdRecurso"] != DBNull.Value ? Convert.ToInt32(dr["IdRecurso"]) : (int?)null,
                        IdPersonal = dr["IdPersonal"] != DBNull.Value ? Convert.ToInt32(dr["IdPersonal"]) : (int?)null,
                        IdHorario = dr["IdHorario"] != DBNull.Value ? Convert.ToInt32(dr["IdHorario"]) : (int?)null,
                        FechaMantenimiento = dr["FechaMantenimiento"] != DBNull.Value ? Convert.ToDateTime(dr["FechaMantenimiento"]) : (DateTime?)null,
                        Prioridad = dr["Prioridad"] != DBNull.Value ? dr["Prioridad"].ToString() : string.Empty
                    };
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (cmd.Connection != null && cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
            }
            return entMantenimiento;
        }

        public bool agregarMantenimientoPlanificacion(entMantenimientoPlanificacion nuevo)
        {
            SqlCommand cmd = null;
            bool agregar = false;
            try
            {
                SqlConnection cn = Conexion.Instacia.Conectar();
                cn.Open();
                cmd = new SqlCommand("agregarMantenimientoPlanificacion", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdRecurso", nuevo.IdRecurso ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@IdPersonal", nuevo.IdPersonal ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@IdHorario", nuevo.IdHorario ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@FechaMantenimiento", nuevo.FechaMantenimiento ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Prioridad", nuevo.Prioridad ?? (object)DBNull.Value);

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

        public bool actualizarMantenimientoPlanificacion(entMantenimientoPlanificacion nuevo)
        {
            SqlCommand cmd = null;
            bool actualizar = false;
            try
            {
                SqlConnection cn = Conexion.Instacia.Conectar();
                cn.Open();
                cmd = new SqlCommand("actualizarMantenimientoPlanificacion", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdPlanificacion", nuevo.IdPlanificacion);
                cmd.Parameters.AddWithValue("@FechaMantenimiento", nuevo.FechaMantenimiento ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Prioridad", nuevo.Prioridad ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@IdRecurso", nuevo.IdRecurso ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@IdPersonal", nuevo.IdPersonal ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@IdHorario", nuevo.IdHorario ?? (object)DBNull.Value);
                int rows = cmd.ExecuteNonQuery();

                actualizar = rows >= 1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (cmd != null && cmd.Connection != null)
                {
                    cmd.Connection.Close();
                }
            }

            return actualizar;
        }

        public bool deshabilitarMantenimientoPlanificacion(int id)
        {
            SqlCommand cmd = null;
            bool deshabilitar = false;
            try
            {
                SqlConnection cn = Conexion.Instacia.Conectar();
                cn.Open();
                cmd = new SqlCommand("deshabilitarMantenimientoPlanificacion", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idMantenimientoPlanificacion", id);
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