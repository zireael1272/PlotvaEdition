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
using MySqlX.XDevAPI;
using Microsoft.EntityFrameworkCore;
using System.Runtime.Remoting.Contexts;
using PlotvaEdition.Models;
using PlotvaEdition.Interfaces;

namespace PlotvaEdition.DB
{
    public class DBOperationUser : IDBOperationUser
    {
        private readonly DeliveryDbContext context;
        public DBOperationUser(DeliveryDbContext context)
        {
            this.context = context;
        }

        public Users AuthenticateUser(string phone, string password)
        {
            var user = context.Users.SingleOrDefault(u => u.Phone == phone && u.Password == password);
            return user != null ? new Users { Phone = user.Phone, Password = user.Password, Role = user.Role, Name = user.Name, Surname = user.Surname, Patronymic = user.Patronymic} : null;
        }

        public bool AddUser(string phone, string password, string role, string name, string surname, string patronymic)
        {
            try
            {
                var existingUser = context.Users.SingleOrDefault(u => u.Phone == phone);
                if (existingUser != null)
                {
                    MessageBox.Show("Такий користувач вже існує.");
                    return false;
                }

                var newUser = new Users
                {
                    Phone = phone,
                    Password = password,
                    Role = role,
                    Name = name,
                    Surname = surname,
                    Patronymic = patronymic
                };

                context.Users.Add(newUser);
                context.SaveChanges();

                return true; 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка додавання користувача: " + ex.Message);
                return false;
            }
        }

        public bool DeleteUser(string phone, string password)
        {
            try
            {
                var user = context.Users.SingleOrDefault(u => u.Phone == phone && u.Password == password);
                if (user == null)
                {
                    MessageBox.Show("Користувача не знайдено.");
                    return false;
                }

                context.Users.Remove(user); 
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка видалення користувача: " + ex.Message);
                return false;
            }
        }

        public string GetUserDetails(string phone, string password)
        {
            try
            {
                var user = context.Users.SingleOrDefault(u => u.Phone == phone && u.Password == password);
                return user != null ? $"{user.Name} {user.Surname} {user.Patronymic}" : null;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Помилка: " + ex.Message);
                return null;
            }
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
                Console.WriteLine("Помилка: " + ex.Message);
                return null;
            }
        }

        public bool UpdateUserDetails(string phone, string newName, string newSurname, string newPatronymic)
        {
            var user = context.Users.SingleOrDefault(u => u.Phone == phone);
            if (user != null)
            {
                user.Name = newName;
                user.Surname = newSurname;
                user.Patronymic = newPatronymic;

                context.SaveChanges();
                return true;
            }
            else
            {
                MessageBox.Show("Користувача не знайдено.");
                return false;
            }
        }

        public bool UpdatePassword(string phone, string newPassword)
        {
            var user = context.Users.SingleOrDefault(u => u.Phone == phone);
            if (user != null)
            {
                user.Password = newPassword;

                context.SaveChanges();
                return true;
            }
            else
            {
                MessageBox.Show("Користувача не знайдено.");
                return false;
            }
        }

        public void AddParcel(string SenderPhone, string SenderName, string SenderSurname, string SenderPatronymic,string SenderDepartament, 
            string ReceiverPhone, string ReceiverName, string ReceiverSurname, string ReceiverPatronymic, string ReceiverDepartament, 
            decimal Weight, DateTime DispatchDate, DateTime DeliveryDate, int Integrity)
        {
            var status = context.OrderStatus.FirstOrDefault(s => s.StatusName == "В обробці");
            var newParcel = new Parcel
            {
                SenderPhone = SenderPhone,
                SenderName = SenderName,
                SenderSurname = SenderSurname,
                SenderPatronymic = SenderPatronymic,
                SenderDepartament = SenderDepartament,
                ReceiverPhone = ReceiverPhone,
                ReceiverName = ReceiverName,
                ReceiverSurname = ReceiverSurname,
                ReceiverPatronymic = ReceiverPatronymic,
                ReceiverDepartament = ReceiverDepartament,
                Weight = Weight,
                DispatchDate = DispatchDate,
                DeliveryDate = DeliveryDate,
                Status = status,
                Integrity = Integrity
            };

            context.Parcel.Add(newParcel);
            context.SaveChanges();
        }
    }
}
