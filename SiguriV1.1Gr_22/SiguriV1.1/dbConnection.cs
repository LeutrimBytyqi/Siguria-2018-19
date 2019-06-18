using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiguriV1._1
{
    class dbConnection
    {
        MySqlConnection connection
            = new MySqlConnection("datasource=localhost;" +
                "port=3306;username=root;password=");
    }
}
