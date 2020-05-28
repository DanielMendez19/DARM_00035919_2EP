using System.Data;
using Npgsql;

namespace Parcial_02.Modelo
{
    public static class Conexion
    {
        private static string CadenaConexion = 
            "Server=127.0.0.1;Port=5432;User Id=postgres;Password=uca;Database=Parcial";


        public static DataTable realizarConsulta(string sql)
        {
            NpgsqlConnection con = new NpgsqlConnection(CadenaConexion);
            DataSet ds = new DataSet();
            
            con.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, con);
            da.Fill(ds);
            con.Close();
            
            return ds.Tables[0];
        }

        public static void ExecuteNonQuery(string sql)
        {
            NpgsqlConnection conn = new NpgsqlConnection(CadenaConexion);
            conn.Open();
            NpgsqlCommand nc =new NpgsqlCommand(sql, conn);
            nc.ExecuteNonQuery();
            conn.Close();

        }
    }
}