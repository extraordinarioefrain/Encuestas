using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Encuestas
{
    class Conexion
    {
        
        public static SqlConnection conex = new SqlConnection(@"workstation id=Encuesta123.mssql.somee.com;packet size=4096;user id=Esteban1230_SQLLogin_1;pwd=u1uvbj6j87;data source=Encuesta123.mssql.somee.com;persist security info=False;initial catalog=Encuesta123");

        //Conexion con la base de datos. 
    }
}
