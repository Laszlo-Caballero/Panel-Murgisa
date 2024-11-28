using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos.Usuario;
using CapaEntidad.Usuario;
using CapaEntidad.OrdenMantenimientoPreventivo;

namespace CapaAccesoDatos.Usuario
{
    public class datUsuario
    {
        private static readonly datUsuario _instancia = new datUsuario();

        public static datUsuario Instancia
        {
            get { return _instancia; }
        }

        public List<entUsuario> ListarUsuarios()
        {
            SqlCommand cmd = null;
            List<entUsuario> lista = new List<entUsuario>();
            try
            {
                SqlConnection cn = Conexion.Instacia.Conectar();
                cn.Open();
                cmd = new SqlCommand("listarUsuariosConCargo", cn);
                cmd.CommandType = CommandType.StoredProcedure; 
                SqlDataReader dr = cmd.ExecuteReader();

                // Lectura de los datos
                while (dr.Read())
                {
                    entUsuario usuario = new entUsuario();
                    usuario.idUsuario = Convert.ToInt32(dr["idUsuario"]);
                    usuario.Usuario = dr["Usuario"].ToString();
                    usuario.Contrasena = dr["Contrasena"].ToString();
                    usuario.idCargo = Convert.ToInt32(dr["idCargo"]);
                    lista.Add(usuario);
                }
                dr.Close();
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
            return lista;
        }

        public entUsuario logear(string usuario, string contrasena)
        {
            SqlCommand cmd = null;
            entUsuario entUsuario = null;
            try
            {
                using (SqlConnection cn = Conexion.Instacia.Conectar())
                {
                    cn.Open();
                    cmd = new SqlCommand("Logear", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@contrasena", contrasena);
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            entUsuario = new entUsuario
                            {
                                idUsuario = Convert.ToInt32(dr["idUsuario"]),
                                idCargo = Convert.ToInt32(dr["idCargo"]),
                                Usuario = Convert.ToString(dr["usuario"]),
                                Contrasena = Convert.ToString(dr["contrasena"])
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
            }

            return entUsuario;
        }
    }
}
