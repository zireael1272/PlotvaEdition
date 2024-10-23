using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Packaging;

namespace PlotvaEdition.Models
{
    public class Payments
    {
        [Key]
        public int PaymentId { get; set; } 

        [Required]
        public decimal Amount { get; set; } 

        public int ParcelId { get; set; } 
        [ForeignKey("ParcelId")]
        public Parcel Parcel { get; set; } 

        [Required]
        public DateTime PaymentDate { get; set; }
    }
}
