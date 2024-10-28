using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlotvaEdition.Interfaces
{
    internal interface IDBOperation
    {
        bool AddUser(string phone, string password, string role);
        string GetUserDetails(string phone, string password);
        bool DeleteUser(string phone);
        bool AuthenticateUser(string phone, string password);
        //bool AddParcel();

    }
}
