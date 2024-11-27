using CapaEntidad.Personal;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos.Personal
{
    public class datPersonal
    {
        private static readonly datPersonal _instancia = new datPersonal();

        public static datPersonal Instancia
        {
            get { return _instancia; }
        }

        public bool agregarPersonal(entPersonal nuevo)
        {
            SqlCommand cmd = null;
            bool agregar = false;
            try
            {
                SqlConnection cn = Conexion.Instacia.Conectar();
                cn.Open();
                cmd = new SqlCommand("agregarPersonal", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idCargo", nuevo.idCargo);
                cmd.Parameters.AddWithValue("@idProf", nuevo.idProf);
                cmd.Parameters.AddWithValue("@idDep", nuevo.idDepa);
                cmd.Parameters.AddWithValue("@nombre", nuevo.nombre);
                cmd.Parameters.AddWithValue("@parterno", nuevo.paterno);
                cmd.Parameters.AddWithValue("@materno", nuevo.materno);
                cmd.Parameters.AddWithValue("@sueldo", nuevo.sueldo);
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

        public bool actualizarPersonal(entPersonal nuevo)
        {
            SqlCommand cmd = null;
            bool actualizar = false;
            try
            {
                SqlConnection cn = Conexion.Instacia.Conectar();
                cn.Open();
                cmd = new SqlCommand("actualizarPersonal", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idPersonal", nuevo.id);
                cmd.Parameters.AddWithValue("@idCargo", nuevo.idCargo);
                cmd.Parameters.AddWithValue("@idProf", nuevo.idProf);
                cmd.Parameters.AddWithValue("@idDep", nuevo.idDepa);
                cmd.Parameters.AddWithValue("@nombre", nuevo.nombre);
                cmd.Parameters.AddWithValue("@parterno", nuevo.paterno);
                cmd.Parameters.AddWithValue("@materno", nuevo.materno);
                cmd.Parameters.AddWithValue("@sueldo", nuevo.sueldo);
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

        public bool deshabilitarPersonal(int id)
        {
            SqlCommand cmd = null;
            bool deshabilitar = false;
            try
            {
                SqlConnection cn = Conexion.Instacia.Conectar();
                cn.Open();
                cmd = new SqlCommand("deshabilitarPersonal", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idPersonal", id);
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