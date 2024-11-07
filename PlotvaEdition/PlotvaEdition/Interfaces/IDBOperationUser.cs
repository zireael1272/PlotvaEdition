using PlotvaEdition.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlotvaEdition.Interfaces
{
    internal interface IDBOperationUser
    {
        bool AddUser(string phone, string password, string role, string name, string surname, string patronymic);
        string GetUserDetails(string phone, string password);
        bool DeleteUser(string phone, string password);
        Users AuthenticateUser(string phone, string password);
        void AddParcel(string SenderPhone, string SenderName, string SenderSurname, string SenderPatronymic, string SenderDepartament,
            string ReceiverPhone, string ReceiverName, string ReceiverSurname, string ReceiverPatronymic, string ReceiverDepartament,
            decimal Weight, DateTime DispatchDate, DateTime DeliveryDate, int Integrity);
        bool UpdateUserDetails(string phone, string newName, string newSurname, string newPatronymic);
        bool UpdatePassword(string phone, string newPassword);

    }
}
