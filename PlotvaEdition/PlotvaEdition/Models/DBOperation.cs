using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

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

        public User AuthenticateUser(string phone, string password)
        {
            string query = "SELECT Phone, Password, Role FROM Users WHERE Phone = @Phone AND Password = @Password";

            try
            {
                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    // Используем параметры для защиты от SQL-инъекций
                    command.Parameters.AddWithValue("@Phone", phone);
                    command.Parameters.AddWithValue("@Password", password);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Чтение данных из результата запроса
                            string dbPhone = reader["Phone"].ToString();
                            string dbPassword = reader["Password"].ToString();
                            string dbRole = reader["Role"].ToString();

                            int.TryParse(dbPhone, out int DBphone);

                            // Возвращаем объект Account с нужными полями
                            return new User(DBphone, dbPassword, dbRole);
                        }
                        else
                        {
                            // Если пользователь не найден, возвращаем null
                            return null;
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                // Ловим ошибки и выводим сообщение в консоль для отладки
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }
        }

       

    }
}
