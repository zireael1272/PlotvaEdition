using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlotvaEdition.Interfaces
{
    internal interface IOrderStatus
    {
        int StatusId { get; set; }
        string StatusName { get; set; }
        DateTime StatusChangeDate { get; set; }
    }
}
