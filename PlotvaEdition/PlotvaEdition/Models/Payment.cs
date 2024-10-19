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
        public decimal Amount { get; set; } 
        public decimal Discount { get; set; }
        public decimal FinalAmount
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
