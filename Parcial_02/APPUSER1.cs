using System;
using System.Collections.Generic;
using System.Data;
using Parcial_02.Modelo;

namespace Parcial_02
{
    public class APPUSER1
    {
        public static List<APPUSER> getLista()
        {
            string sql = "select * from APPUSER";

            DataTable dt = Conexion.realizarConsulta(sql);

            List<APPUSER> lista = new List<APPUSER>();
            foreach (DataRow fila in dt.Rows)
            {
                APPUSER u = new APPUSER();
                u.username = fila[2].ToString();
                u.fullname = fila[1].ToString();
                u.password = fila[3].ToString();
                u.userType = Convert.ToBoolean(fila[4].ToString());
                
                lista.Add(u);
            }
            return lista;
        }
        
        public static void actualizarContra(string usuario, string nuevaContra)
        {
            string sql = String.Format(
                "update APPUSER set password='{0}' where idUser='1';",
                nuevaContra, usuario);
            
            Conexion.ExecuteNonQuery(sql);
        }
        
        public  static void crearNuevo(string idUser)
        {
            string sql = String.Format(
                "insert into APPUSER(fullname, username, password, userType) " +
                "values('{0}', '{0}', {1}, true);",
                idUser);
            
            Conexion.ExecuteNonQuery(sql);
        }
        
     
        
        public static void actualizarPermisos(string username, bool userType)
        {
            string sql = String.Format(
                "update APPUSER set userType={0}, where username='{2}';",
                userType ? "true" : "false", username);
            
            Conexion.ExecuteNonQuery(sql);
        }
        
    }
}