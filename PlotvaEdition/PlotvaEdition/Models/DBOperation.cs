using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace PlotvaEdition.Models
{
    internal class DBOperation
    {
        private SqlConnection sqlConnection = null;
        DBOperation()
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DeliveryDB"].ConnectionString);
        }

    }
}
