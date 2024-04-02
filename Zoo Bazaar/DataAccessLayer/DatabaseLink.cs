using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace DataAccessLayer
{
    public class DatabaseLink
    {
        public static MySqlConnection CreateConnection()
        {
            return new MySqlConnection("Server=studmysql01.fhict.local;Uid=dbi477553;Database=dbi477553;Pwd=Milan;");

        }

    }
}
