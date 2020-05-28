using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.SqlServer.Server;

namespace Parcial_02.Modelo
{
    public class APPUSER
    {
        
        public string fullname { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        
        public bool userType { get; set; }
        
        public APPUSER()
        {
            fullname = "";
            username = "";
            password = "";
            userType = false;
            
        }
        
        
        
    }
}