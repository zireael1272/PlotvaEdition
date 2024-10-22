using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlotvaEdition.Interfaces
{
    internal interface IPayment
    {
        int PaymentId { get; set; }
        double Amount { get; set; }
        double Discount { get; set; }
        double FinalAmount { get; set; }
        bool IsPaid { get; set; }
        DateTime PaymentDate { get; set; }
    }
}
