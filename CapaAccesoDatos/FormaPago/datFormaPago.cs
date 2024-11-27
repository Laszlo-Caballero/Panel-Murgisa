using CapaEntidad.FormaPago;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos.FormaPago
{
    public class datFormaPago
    {
        private static readonly datFormaPago _instancia = new datFormaPago();

        public static datFormaPago Instancia
        {
            get { return _instancia; }
        }


        public List<entFormaPago> listarFormaPagos()
        {
            SqlCommand cmd = null;
            List<entFormaPago> lista = new List<entFormaPago>();
            try
            {
                SqlConnection cn = Conexion.Instacia.Conectar();
                cn.Open();
                cmd = new SqlCommand("listarFormaPagos", cn);
                SqlDataReader dr = cmd.ExecuteReader();
                while(dr.Read()){
                    entFormaPago pago = new entFormaPago();
                    pago.idFormaPago = Convert.ToInt32(dr["idFormaPago"]);
                    pago.tipo = dr["tipo"].ToString();
                    pago.estado = Convert.ToBoolean(dr["estado"]);
                    lista.Add(pago);
                }
            }
            catch (Exception ex){
                throw ex;
            }
            finally{
                cmd.Connection.Close();
            }
            return lista;
        }
        public bool actualizarFormaPago(){
            
        }
    }
}