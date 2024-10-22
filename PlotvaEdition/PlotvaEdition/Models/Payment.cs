using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlotvaEdition.Models
{
    internal class Payment
    {
        public int PaymentId { get; set; }
        public double Amount { get; set; } 
        public double Discount { get; set; }
        public double FinalAmount
        {
            get
            {
                return Amount - Discount;
            }
        }

        public bool IsPaid { get; set; } 
        public DateTime PaymentDate { get; set; }
    }
}
