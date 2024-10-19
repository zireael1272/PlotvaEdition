using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlotvaEdition.Models
{
    internal class OrderStatus
    {
        public int StatusId { get; set; }
        public string StatusName { get; set; }
        public DateTime StatusChangeDate { get; set; }
    }
}
