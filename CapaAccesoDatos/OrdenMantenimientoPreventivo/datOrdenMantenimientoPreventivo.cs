using CapaEntidad.MantenimientoPlanificacion;
using CapaEntidad.OrdenMantenimientoPreventivo;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos.OrdenMantenimientoPreventivo
{
    public class datOrdenMantenimientoPreventivo
    {
        private static readonly datOrdenMantenimientoPreventivo _instancia = new datOrdenMantenimientoPreventivo();

        public static datOrdenMantenimientoPreventivo Instancia
        {
            get { return _instancia; }
        }
        public entOrdenMantenimientoPreventivo buscarPorId(int id)
        {
            SqlCommand cmd = null;
            entOrdenMantenimientoPreventivo entMantenimiento = null;
            try
            {
                using (SqlConnection cn = Conexion.Instacia.Conectar())
                {
                    cn.Open();
                    cmd = new SqlCommand("mantenimientoPreventivo_buscarXId", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idOrdenMantenimiento", id);
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            entMantenimiento = new entOrdenMantenimientoPreventivo
                            {
                                idOrdenMantenimiento = Convert.ToInt32(dr["idOrdenMantenimiento"]),
                                idPlanificacion = Convert.ToInt32(dr["idPlanificacion"]),
                                fecha = dr["fecha"] != DBNull.Value ? Convert.ToDateTime(dr["fecha"]) : (DateTime?)null,
                                ResultadoEjecucion = dr["resultadoEjecucion"] != DBNull.Value ? dr["resultadoEjecucion"].ToString() : string.Empty,
                                Comentarios = dr["comentarios"] != DBNull.Value ? dr["comentarios"].ToString() : string.Empty,
                                RequerimientosEspeciales = dr["requerimientosEspeciales"] != DBNull.Value ? dr["requerimientosEspeciales"].ToString() : string.Empty,
                                DuracionEstimadaHoras = dr["duracionEstimadaHoras"] != DBNull.Value ? Convert.ToDouble(dr["duracionEstimadaHoras"]) : (double?)null,
                                estado = dr["estado"] != DBNull.Value ? Convert.ToBoolean(dr["estado"]) : (bool?)null
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al buscar la orden de mantenimiento preventivo por ID", ex);
            }

            return entMantenimiento;
        }

        public DataTable listarMantenimientoPreventivoParaGrid(int? idOrdenMantenimiento = null, DateTime? fecha = null)
        {
            SqlCommand cmd = null;
            DataTable dt = new DataTable();
            try
            {
                SqlConnection cn = Conexion.Instacia.Conectar();
                cn.Open();
                cmd = new SqlCommand("listarMantenimientoPreventivo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idOrdenMantenimiento",
                    idOrdenMantenimiento.HasValue ? (object)idOrdenMantenimiento.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@fecha",
                    fecha.HasValue ? (object)fecha.Value : DBNull.Value);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar el mantenimiento preventivo", ex);
            }
            finally
            {
                if (cmd.Connection != null && cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
            }
            return dt;
        }

        public bool existeOrdenMantenimientoPrev(int IdPlanificacion)
        {
            SqlCommand cmd = null;
            bool existe = false;
            try
            {
                SqlConnection cn = Conexion.Instacia.Conectar();
                cn.Open();
                cmd = new SqlCommand("mantenimientoPreventivo_buscarXId", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdPlanificacion", IdPlanificacion);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    existe = true; 
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al verificar la existencia de la orden de mantenimiento: " + ex.Message);
            }
            finally
            {
                if (cmd.Connection != null && cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
            }
            return existe;
        }
        public List<entOrdenMantenimientoPreventivo> listarOrdenMantenimientoPreventivo()
        {
            SqlCommand cmd = null;
            List<entOrdenMantenimientoPreventivo> lista = new List<entOrdenMantenimientoPreventivo>();
            try
            {
                SqlConnection cn = Conexion.Instacia.Conectar();
                cn.Open();
                cmd = new SqlCommand("listarOrdenMantenimientoPreventivo", cn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entOrdenMantenimientoPreventivo nuevo = new entOrdenMantenimientoPreventivo();
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

        public bool agregarOrdenMantenimientoPreventivo(entOrdenMantenimientoPreventivo nuevo)
        {
            SqlCommand cmd = null;
            bool agregar = false;
            try
            {
                SqlConnection cn = Conexion.Instacia.Conectar();
                cn.Open();
                cmd = new SqlCommand("agregarOrdenMantenimientoPreventivo", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idPlanificacion", nuevo.idPlanificacion);
                cmd.Parameters.AddWithValue("@fecha", nuevo.fecha);
                cmd.Parameters.AddWithValue("@resultadoEjecucion", (object)nuevo.ResultadoEjecucion ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@comentarios", (object)nuevo.Comentarios ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@requerimientosEspeciales", (object)nuevo.RequerimientosEspeciales ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@duracionEstimadaHoras", (object)nuevo.DuracionEstimadaHoras ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@estado", nuevo.estado ?? true); 
                int rows = cmd.ExecuteNonQuery();
                agregar = rows >= 1;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar la orden de mantenimiento preventivo.", ex);
            }
            finally
            {
                if (cmd?.Connection != null && cmd.Connection.State == System.Data.ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
            }
            return agregar;
        }

        public bool actualizarOrdenMantenimientoPreventivo(entOrdenMantenimientoPreventivo nuevo)
        {
            SqlCommand cmd = null;
            bool actualizado = false;
            try
            {
                SqlConnection cn = Conexion.Instacia.Conectar();
                cn.Open();

                cmd = new SqlCommand("actualizarOrdenMantenimientoPreventivo", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idOrdenMantenimiento", nuevo.idOrdenMantenimiento); 
                cmd.Parameters.AddWithValue("@idPlanificacion", nuevo.idPlanificacion);
                cmd.Parameters.AddWithValue("@fecha", nuevo.fecha); 
                cmd.Parameters.AddWithValue("@resultadoEjecucion", nuevo.ResultadoEjecucion); 
                cmd.Parameters.AddWithValue("@comentarios", nuevo.Comentarios);
                cmd.Parameters.AddWithValue("@requerimientosEspeciales", nuevo.RequerimientosEspeciales);
                cmd.Parameters.AddWithValue("@duracionEstimadaHoras", nuevo.DuracionEstimadaHoras.HasValue ? nuevo.DuracionEstimadaHoras.Value : (object)DBNull.Value);
                int rows = cmd.ExecuteNonQuery();
                actualizado = rows >= 1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (cmd?.Connection != null && cmd.Connection.State == System.Data.ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
            }
            return actualizado;
        }

        public bool deshabilitarOrdenMantenimientoPreventivo(int id)
        {
            SqlCommand cmd = null;
            bool deshabilitar = false;
            try
            {
                SqlConnection cn = Conexion.Instacia.Conectar();
                cn.Open();
                cmd = new SqlCommand("deshabilitarOrdenMantenimientoPreventivo", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idOrdenMantenimiento", id);
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