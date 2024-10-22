using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows;

namespace PlotvaEdition.Models
{
    internal class DBOperation
    {
        private SqlConnection sqlConnection = null;
        public DBOperation()
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DeliveryDB"].ConnectionString);

            try
            {
                sqlConnection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to open database connection: {ex.Message}", "Error");
            }
        }

        public void CloseConnection()
        {
            if (sqlConnection != null && sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

    }
}
