using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlotvaEdition.Models
{
    public class Parcel
    {
        [Key]
        public int ParcelId { get; set; }

        [Required]
        [MaxLength(10)]
        public string SenderPhone { get; set; }

        [ForeignKey("SenderPhone")]
        public Users Sender { get; set; }

        [Required]
        [MaxLength(50)]
        public string SenderName { get; set; }

        [Required]
        [MaxLength(50)]
        public string SenderSurname { get; set; }

        [Required]
        [MaxLength(50)]
        public string SenderPatronymic { get; set; }

        [Required]
        [MaxLength(10)]
        public string ReceiverPhone { get; set; }

        [ForeignKey("ReceiverPhone")]
        public Users Receiver { get; set; }

        [Required]
        [MaxLength(50)]
        public string ReceiverName { get; set; }

        [Required]
        [MaxLength(50)]
        public string ReceiverSurname { get; set; }

        [Required]
        [MaxLength(50)]
        public string ReceiverPatronymic { get; set; }

        [Required]
        public decimal Weight { get; set; }

        [Required]
        public DateTime DispatchDate { get; set; }

        [Required]
        public DateTime DeliveryDate { get; set; }

        public int StatusId { get; set; }
        [ForeignKey("StatusId")]
        public OrderStatus Status { get; set; }

        [Required]
        public int Integrity { get; set; }
    }
}
