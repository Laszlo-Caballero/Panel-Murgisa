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
        public bool agregarFormaPago(entFormaPago pago){
            SqlCommand cmd = null;
            bool agregarEstado = false;

            try
            {
                SqlConnection cn = Conexion.Instacia.Conectar();
                cn.Open();
                cmd = new SqlCommand("agregarPago", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@tipo", pago.tipo);

                cmd.Parameters.AddWithValue("@estado", pago.estado);
                int rows = cmd.ExecuteNonQuery();
                
                agregarEstado = rows >= 1;
            }
            catch (Exception ex) { throw ex; }
            finally { 
                cmd.Connection.Close();
            }
            return agregarEstado;
        }
        public bool deshabilitarFormaPago(int id)
        {
            SqlCommand cmd = null;
            bool deshabilitado = false;
            try
            {
                SqlConnection cn = Conexion.Instacia.Conectar();
                cn.Open();
                cmd = new SqlCommand("deshabilitarPago", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idPago", id);
                int rows = cmd.ExecuteNonQuery();
                deshabilitado = rows >= 1;
            }
            catch (Exception ex) { throw ex; }
            finally
            {
                cmd.Connection.Close();
            }
            return deshabilitado;
        }

        public bool actualizarPago(entFormaPago pago)
        {
            SqlCommand cmd = null;
            bool actalizar = false;
            try
            {
                SqlConnection cn = Conexion.Instacia.Conectar();
                cn.Open();
                cmd = new SqlCommand("actualizarPago", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idPago", pago.idFormaPago);
                cmd.Parameters.AddWithValue("@tipo", pago.tipo);
                cmd.Parameters.AddWithValue("@estado", pago.estado);
                int rows = cmd.ExecuteNonQuery();
                actalizar = rows >= 1;
            }
            catch (Exception ex) { throw ex; }
            finally {
                cmd.Connection.Close();
            }
            return actalizar;
        }
    }
}