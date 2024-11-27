using CapaEntidad.Recurso;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos.Recurso
{
    public class datTipoRecurso
    {
        private static readonly datTipoRecurso _instancia = new datTipoRecurso();

        public static datTipoRecurso Instancia
        {
            get { return _instancia; }
        }

        public List<entTipoRecurso> listarTipoRecurso()
        {
            SqlCommand cmd = null;
            List<entTipoRecurso> lista = new List<entTipoRecurso>();
            try
            {
                SqlConnection cn = Conexion.Instacia.Conectar();
                cn.Open();
                cmd = new SqlCommand("listarTipoRecurso", cn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entTipoRecurso nuevo = new entTipoRecurso();
                    nuevo.idTipoRecurso = Convert.ToInt32(dr["idTipoRecurso"]);
                    nuevo.tipo = dr["tipo"].ToString();
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