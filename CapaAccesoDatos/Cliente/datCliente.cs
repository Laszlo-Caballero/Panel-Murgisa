using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad.Cliente;
using Microsoft.Data.SqlClient;

namespace CapaAccesoDatos.Cliente
{
    public class datCliente
    {
        private static readonly datCliente _instacia = new datCliente();

        public static datCliente instacia { get { return _instacia; } }

        public List<entCliente> listaClientes()
        {
            SqlCommand cmd = null;
            List<entCliente> lista = new List<entCliente>();
            try
            {
                SqlConnection cn = Conexion.Instacia.Conectar();
                cn.Open();
                cmd = new SqlCommand("listarClientes", cn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entCliente cliente = new entCliente();
                    cliente.idCliente = Convert.ToInt32(dr["idCliente"]);
                    cliente.nombreRepresentatne = dr["nombreRepresentante"].ToString();
                    cliente.dni = dr["dni"].ToString();
                    cliente.estado = Convert.ToBoolean(dr["estado"]);
                    cliente.correo = dr["correo"].ToString();
                    cliente.telefono = dr["telefono"].ToString();
                    cliente.direccion = dr["direccion"].ToString();
                    cliente.ciudad = dr["Ciudad"].ToString();
                    lista.Add(cliente);
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

        public bool agregarCliente(entCliente cliente)
        {
            SqlCommand cmd = null;
            bool estado = false;

            try
            {
                SqlConnection cn = Conexion.Instacia.Conectar();
                cn.Open();
                cmd = new SqlCommand("agregarCliente", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@nombreRepresentante", cliente.nombreRepresentatne);
                cmd.Parameters.AddWithValue("@dni", cliente.dni);
                cmd.Parameters.AddWithValue("@estado", cliente.estado);
                cmd.Parameters.AddWithValue("@correo", cliente.correo);
                cmd.Parameters.AddWithValue("@telefono", cliente.telefono);
                cmd.Parameters.AddWithValue("@direccion", cliente.direccion);
                cmd.Parameters.AddWithValue("@ciudad", cliente.ciudad);

                int row = cmd.ExecuteNonQuery();
                estado = row >= 1;
            }
            catch (Exception ex) { throw ex; }
            finally
            {
                cmd.Connection.Close();
            }

            return estado;
        }

        public bool deshabilitarCliente(entCliente cliente)
        {
            SqlCommand cmd = null;
            bool estado = false;
            try
            {
                SqlConnection cn = Conexion.Instacia.Conectar();
                cn.Open();
                cmd = new SqlCommand("deshabilitarCliente", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idCliente", cliente.idCliente);
                int row = cmd.ExecuteNonQuery();
                estado = row >= 1;
            }
            catch (Exception ex) { throw ex; }
            finally
            {
                cmd.Connection.Close();
            }
            return estado;
        }

        public bool actualizarCliente(entCliente cliente)
        {
            SqlCommand cmd = null;
            bool estado = false;
            try
            {
                SqlConnection cn = Conexion.Instacia.Conectar();
                cn.Open();
                cmd = new SqlCommand("actualizarCliente", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idCliente", cliente.idCliente);
                cmd.Parameters.AddWithValue("@nombreRepresentante", cliente.nombreRepresentatne);
                cmd.Parameters.AddWithValue("@dni", cliente.dni);
                cmd.Parameters.AddWithValue("@estado", cliente.estado);
                cmd.Parameters.AddWithValue("@correo", cliente.correo);
                cmd.Parameters.AddWithValue("@telefono", cliente.telefono);
                cmd.Parameters.AddWithValue("@direccion", cliente.direccion);
                cmd.Parameters.AddWithValue("@ciudad", cliente.ciudad);

                int row = cmd.ExecuteNonQuery();
                estado = row >= 1;
            }
            catch (Exception ex) { throw ex; }
            finally
            {
                cmd.Connection.Close();
            }
            return estado;
        }

        public entCliente buscarCliente(string dni)
        {
            SqlCommand cmd = null;
            entCliente cliente = new entCliente();
            try
            {
                SqlConnection cn = Conexion.Instacia.Conectar();
                cn.Open();
                cmd = new SqlCommand("buscarCliente", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@dni", dni);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cliente.idCliente = Convert.ToInt32(dr["idCliente"]);
                    cliente.nombreRepresentatne = dr["nombreRepresentante"].ToString();
                    cliente.dni = dr["dni"].ToString();
                    cliente.estado = Convert.ToBoolean(dr["estado"]);
                    cliente.correo = dr["correo"].ToString();
                    cliente.telefono = dr["telefono"].ToString();
                    cliente.direccion = dr["direccion"].ToString();
                    cliente.ciudad = dr["Ciudad"].ToString();
                }
            }
            catch (Exception ex) { throw ex; }
            finally
            {
                cmd.Connection.Close();
            }
            return cliente;
        }


    }
}
