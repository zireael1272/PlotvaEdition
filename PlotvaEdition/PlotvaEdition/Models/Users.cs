using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlotvaEdition.Models
{
    public class Users
    {
        [Key]
        public string Phone { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(50)]
        public string Surname { get; set; }

        [Required]
        [MaxLength(50)]
        public string Patronymic { get; set; }

    }
}
