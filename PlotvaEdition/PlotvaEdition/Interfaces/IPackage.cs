using PlotvaEdition.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlotvaEdition.Interfaces
{
    internal interface IPackage
    {
        int Id { get; set; }
        string Sender { get; set; }
        string Recipient { get; set; }
        OrderStatus CurrentStatus { get; set; }
        List<OrderStatus> StatusHistory { get; set; }

        double price { get; set; }
        DateTime CriticalDate { get; set; }
        DateTime DeliveryDate { get; set; }

        Payment PaymentDetails { get; set; }
    }
}
