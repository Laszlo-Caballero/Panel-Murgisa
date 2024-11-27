using CapaEntidad.Personal;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos.Personal
{
    public class datPersonalVista
    {
        private static readonly datPersonalVista _instancia = new datPersonalVista();

        public static datPersonalVista Instancia
        {
            get { return _instancia; }
        }

        public List<entPersonalVista> listarPersonal()
        {
            SqlCommand cmd = null;
            List<entPersonalVista> lista = new List<entPersonalVista>();
            try
            {
                SqlConnection cn = Conexion.Instacia.Conectar();
                cn.Open();
                cmd = new SqlCommand("listarPersonal", cn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entPersonalVista nuevo = new entPersonalVista();
                    nuevo.id = Convert.ToInt32(dr["idPersonal"]);
                    nuevo.nombre = dr["nombre"].ToString();
                    nuevo.paterno = dr["apellido_parterno"].ToString();
                    nuevo.materno = dr["apellido_materno"].ToString();
                    nuevo.cargo = dr["cargo"].ToString();
                    nuevo.prof = dr["titulo"].ToString();
                    nuevo.depa = dr["departamento"].ToString();
                    nuevo.sueldo = Convert.ToSingle(dr["sueldo"]);
                    nuevo.estado = Convert.ToBoolean(dr["estado"]);
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
    }
}
