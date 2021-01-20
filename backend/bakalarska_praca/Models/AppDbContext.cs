using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bakalarska_praca.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Attack> Attacks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Attack>().HasData(new Attack { Id = 1, Message = "Error Based SQL Injection Detected", Proto = "TCP", Severity = 3, Timestamp = new DateTime(2020, 10, 21, 15, 17, 49), Src_ip = "192.168.40.11", Dest_ip = "192.168.40.183" });
            modelBuilder.Entity<Attack>().HasData(new Attack { Id = 2, Message = "Error Based SQL Injection Detected", Proto = "TCP", Severity = 3, Timestamp = new DateTime(2020, 10, 22, 15, 17, 49), Src_ip = "192.168.40.11", Dest_ip = "192.168.40.183" });
            modelBuilder.Entity<Attack>().HasData(new Attack { Id = 3, Message = "Error Based SQL Injection Detected", Proto = "TCP", Severity = 3, Timestamp = new DateTime(2020, 10, 23, 15, 17, 49), Src_ip = "192.168.40.11", Dest_ip = "192.168.40.183" });
        }
    }
}
