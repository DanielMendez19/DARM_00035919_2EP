using System;
using Parcial_02.Modelo;

namespace Parcial_02
{
    public class ADDRESS1
    {
        public static void nuevaDireccion(int idUser,string address)
        {
            string sql = String.Format(
                "insert into ADDRESS(idUser,address) " +
                "values('idUser', '{0} ';",
                idUser, address);
                
            Conexion.ExecuteNonQuery(sql);
        }
    }
}