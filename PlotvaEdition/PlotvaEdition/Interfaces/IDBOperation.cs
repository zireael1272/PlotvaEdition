using PlotvaEdition.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlotvaEdition.Interfaces
{
    internal interface IDBOperation
    {
        bool AddUser(string phone, string password, string role, string name, string surname, string patronymic);
        string GetUserDetails(string phone, string password);
        bool DeleteUser(string phone, string password);
        Users AuthenticateUser(string phone, string password);
        //bool AddParcel();

    }
}
