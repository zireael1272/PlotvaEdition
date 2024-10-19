using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlotvaEdition.Models
{
    internal class PackageInfo
    {
        public int Id { get; set; }
        public string Sender { get; set; }
        public string Recipient { get; set; }
        public OrderStatus CurrentStatus { get; set; }
        public List<OrderStatus> StatusHistory { get; set; }

        public double price { get; set; }
        public DateTime CriticalDate { get; set; }
        public DateTime DeliveryDate { get; set; }

        public Payment PaymentDetails { get; set; }
    }
}
