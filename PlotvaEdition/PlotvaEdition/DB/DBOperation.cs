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
using System.Data.Entity;
using PlotvaEdition.Models;
using PlotvaEdition.Interfaces;

namespace PlotvaEdition.DB
{
    public class DBOperation : IDBOperation
    {
        private readonly DeliveryDbContext context;
        public DBOperation(DeliveryDbContext context)
        {
            this.context = context;
        }

        public bool AddUser(string phone, string password, string role)
        {
            try
            {
                var existingUser = context.Users.SingleOrDefault(u => u.Phone == phone);
                if (existingUser != null)
                {
                    MessageBox.Show("Пользователь с таким номером телефона уже существует.");
                    return false;
                }

                var newUser = new Users
                {
                    Phone = phone,
                    Password = password,
                    Role = role
                };

                context.Users.Add(newUser);
                context.SaveChanges();

                return true; 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении пользователя: " + ex.Message);
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
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }
        }

        public bool DeleteUser(string phone)
        {
            try
            {
                var user = context.Users.SingleOrDefault(u => u.Phone == phone);
                if (user == null)
                {
                    MessageBox.Show("User not found.");
                    return false;
                }

                context.Users.Remove(user); 
                context.SaveChanges();
                MessageBox.Show("User deleted.");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error delete user: " + ex.Message);
                return false;
            }
        }
    }
}
