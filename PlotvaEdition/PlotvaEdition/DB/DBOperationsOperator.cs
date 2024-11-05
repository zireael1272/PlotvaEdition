using PlotvaEdition.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlotvaEdition.DB
{
    public class DBOperationsOperator
    {
        private readonly DeliveryDbContext context;
        public DBOperationsOperator(DeliveryDbContext context)
        {
            this.context = context;
        }

        public Users AuthenticateUser(string phone, string password)
        {
            var user = context.Users.SingleOrDefault(u => u.Phone == phone && u.Password == password);
            return user != null ? new Users { Phone = user.Phone, Password = user.Password, Role = user.Role, Name = user.Name, Surname = user.Surname, Patronymic = user.Patronymic } : null;
        }

        public string GetUserRole(string phone, string password)
        {
            try
            {
                var user = context.Users.SingleOrDefault(u => u.Phone == phone && u.Password == password);
                return user != null ? $"{user.Role}" : null;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }
        }
    }
}
