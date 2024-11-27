using Microsoft.Data.SqlClient;

namespace CapaAccesoDatos
{
    public class Conexion
    {
        private static readonly Conexion _instacia = new Conexion();
        private static string server = "LASZLO\\SQLEXPRESS";
        public static Conexion Instacia
        {
            get { return Conexion._instacia; }
        }
        public SqlConnection Conectar()
        {
            try
            {
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = "Data Source=" + server + "; Initial Catalog=murgisa;" +//"User ID=sa; Password=123";
                                    "Integrated Security=true; TrustServerCertificate=True;";

                return cn;
            }
            catch (Exception ex) {

                throw new Exception("Error al conectar a la base de datos", ex);
            }
        }
    }
}
