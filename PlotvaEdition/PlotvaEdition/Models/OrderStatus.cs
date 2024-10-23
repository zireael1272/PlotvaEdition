using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlotvaEdition.Models
{
    public class OrderStatus
    {
        [Key]
        public int StatusId { get; set; }

        [Required]
        [MaxLength(50)]
        public string StatusName { get; set; }
    }
}
