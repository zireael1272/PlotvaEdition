using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Microsoft.EntityFrameworkCore;
using PlotvaEdition.Models;
using PlotvaEdition.Interfaces;

namespace PlotvaEdition.Models
{
    public class DeliveryDbContext : DbContext
    {
        public DbSet<Users> Users { get; set; }
        public DbSet<Parcel> Parcels { get; set; }
        public DbSet<OrderStatus> OrderStatuses { get; set; }
        public DbSet<Payments> Payments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["DeliveryDB"].ConnectionString);
        }

    }
}
