using CapaEntidad.OrdenServicio;
using CapaEntidad.PagoServicio;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos.OrdenServicio
{
    //public class datOrdenServicio
    //{
    //    private static readonly datOrdenServicio _instancia = new datOrdenServicio();

    //    public static datOrdenServicio Instancia
    //    {
    //        get { return _instancia; }
    //    }

    //    public List<entOrdenServicio> listarOrdenServicio()
    //    {
    //        SqlCommand cmd = null;
    //        List<entOrdenServicio> lista = new List<entOrdenServicio>();
    //        try
    //        {
    //            SqlConnection cn = Conexion.Instacia.Conectar();
    //            cn.Open();
    //            cmd = new SqlCommand("listarOrdenServicio", cn);
    //            SqlDataReader dr = cmd.ExecuteReader();
    //            while (dr.Read())
    //            {
    //                entOrdenServicio nuevo = new entOrdenServicio();
    //                nuevo.id = Convert.ToInt32(dr["idOrden_Servicio"]);
    //                nuevo.idVenta = Convert.ToInt32(dr["idVenta"]);
    //                nuevo.fechaRegistro = Convert.ToDateTime(dr["fechaRegistro"]);
    //                nuevo.estado = Convert.ToBoolean(dr["estado"]);
    //                lista.Add(nuevo);
    //            }
    //        }
    //        catch (Exception ex) {
    //            throw ex;
    //        }
    //        finally
    //        {
    //            cmd.Connection.Close();
    //        }
    //        return lista;
    //    }

    //    public bool agregarOrdenServicio(entOrdenServicio ordenServicio)
    //    {
    //        SqlCommand cmd = null;
    //        bool agregar = false;
    //        try
    //        {
    //            SqlConnection cn = Conexion.Instacia.Conectar();
    //            cn.Open();
    //            cmd = new SqlCommand("agregarOrdenServicio", cn);
    //            cmd.CommandType = System.Data.CommandType.StoredProcedure;
    //            cmd.Parameters.AddWithValue("@fecha", nuevo.fecha);
    //            cmd.Parameters.AddWithValue("@idFormaPago", nuevo.idFormaPago);
    //            cmd.Parameters.AddWithValue("@estado", nuevo.estado);
    //            int rows = cmd.ExecuteNonQuery();
    //            agregar = rows >= 1;
    //        }
    //        catch (Exception ex)
    //        {
    //            throw ex;
    //        }
    //        finally
    //        {
    //            cmd.Connection.Close();
    //        }
    //        return agregar;
    //    }

    //    public bool actualizarOrdenServicio(entOrdenServicio nuevo)
    //    {
    //        SqlCommand cmd = null;
    //        bool actualizar = false;
    //        try
    //        {
    //            SqlConnection cn = Conexion.Instacia.Conectar();
    //            cn.Open();
    //            cmd = new SqlCommand("actualizarOrdenServicio", cn);
    //            cmd.CommandType = System.Data.CommandType.StoredProcedure;
    //            int rows = cmd.ExecuteNonQuery();
    //            actualizar = rows >= 1;
    //        }
    //        catch (Exception ex) { 
    //            throw ex;
    //        }
    //        finally
    //        {
    //            cmd.Connection.Close();
    //        }
    //        return actualizar;
    //    }

    //    public bool deshabilitarOrdenServicio(int id)
    //    {
    //        SqlCommand cmd = null;
    //        bool deshabilitar = false;
    //        try
    //        {
    //            SqlConnection cn = Conexion.Instacia.Conectar();
    //            cn.Open();
    //            cmd = new SqlCommand("deshabilitarOrdenServicio", cn);
    //            cmd.CommandType = System.Data.CommandType.StoredProcedure;
    //            cmd.Parameters.AddWithValue("@idOrdenServicio", id);
    //            int rows = cmd.ExecuteNonQuery();
    //            deshabilitar = rows >= 1;
    //        }
    //        catch (Exception ex) { throw ex; }
    //        finally
    //        {
    //            cmd.Connection.Close();
    //        }
    //        return deshabilitar;
      //  }
    //}
}