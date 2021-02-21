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
            modelBuilder.Entity<Attack>().HasData(new Attack { Id = 1, Message = "Error Based SQL Injection Detected", Proto = "TCP", Severity = 3, Timestamp = new DateTime(2020, 10, 10, 15, 17, 49).ToUniversalTime(), Src_ip = "192.168.40.11", Dest_ip = "192.168.40.183" });
            modelBuilder.Entity<Attack>().HasData(new Attack { Id = 2, Message = "Error Based SQL Injection Detected", Proto = "TCP", Severity = 3, Timestamp = new DateTime(2020, 10, 11, 15, 17, 49).ToUniversalTime(), Src_ip = "192.168.40.11", Dest_ip = "192.168.40.183" });
            modelBuilder.Entity<Attack>().HasData(new Attack { Id = 3, Message = "Error Based SQL Injectio n Detected", Proto = "TCP", Severity = 3, Timestamp = new DateTime(2020, 10, 12, 15, 17, 49).ToUniversalTime(), Src_ip = "192.168.40.11", Dest_ip = "192.168.40.183" });
            modelBuilder.Entity<Attack>().HasData(new Attack { Id = 4, Message = "Error Based SQL Injection Detected", Proto = "TCP", Severity = 4, Timestamp = new DateTime(2020, 10, 13, 15, 17, 49).ToUniversalTime(), Src_ip = "192.168.40.11", Dest_ip = "192.168.40.183" });
            modelBuilder.Entity<Attack>().HasData(new Attack { Id = 5, Message = "Error Based SQL Injection Detected", Proto = "TCP", Severity = 4, Timestamp = new DateTime(2020, 10, 14, 15, 17, 49).ToUniversalTime(), Src_ip = "192.168.40.11", Dest_ip = "192.168.40.183" });
            modelBuilder.Entity<Attack>().HasData(new Attack { Id = 6, Message = "Error Based SQL Injection Detected", Proto = "TCP", Severity = 5, Timestamp = new DateTime(2020, 10, 15, 15, 17, 49).ToUniversalTime(), Src_ip = "192.168.40.11", Dest_ip = "192.168.40.183" });
            modelBuilder.Entity<Attack>().HasData(new Attack { Id = 7, Message = "Error Based SQL Injection Detected", Proto = "TCP", Severity = 5, Timestamp = new DateTime(2020, 10, 16, 15, 17, 49).ToUniversalTime(), Src_ip = "192.168.40.11", Dest_ip = "192.168.40.183" });
            modelBuilder.Entity<Attack>().HasData(new Attack { Id = 8, Message = "Error Based SQL Injection Detected", Proto = "TCP", Severity = 4, Timestamp = new DateTime(2020, 10, 17, 15, 17, 49).ToUniversalTime(), Src_ip = "192.168.40.11", Dest_ip = "192.168.40.183" });
            modelBuilder.Entity<Attack>().HasData(new Attack { Id = 9, Message = "Error Based SQL Injection Detected", Proto = "TCP", Severity = 4, Timestamp = new DateTime(2020, 10, 18, 15, 17, 49).ToUniversalTime(), Src_ip = "192.168.40.11", Dest_ip = "192.168.40.183" });
            modelBuilder.Entity<Attack>().HasData(new Attack { Id = 10, Message = "Error Based SQL Injection Detected", Proto = "TCP", Severity = 2, Timestamp = new DateTime(2020, 10, 19, 15, 17, 49).ToUniversalTime(), Src_ip = "192.168.40.11", Dest_ip = "192.168.40.183" });
            modelBuilder.Entity<Attack>().HasData(new Attack { Id = 11, Message = "Error Based SQL Injection Detected", Proto = "TCP", Severity = 6, Timestamp = new DateTime(2020, 10, 20, 15, 17, 49).ToUniversalTime(), Src_ip = "192.168.40.11", Dest_ip = "192.168.40.183" });
            modelBuilder.Entity<Attack>().HasData(new Attack { Id = 12, Message = "Error Based SQL Injection Detected", Proto = "TCP", Severity = 7, Timestamp = new DateTime(2020, 10, 21, 15, 17, 49).ToUniversalTime(), Src_ip = "192.168.40.11", Dest_ip = "192.168.40.183" });
            modelBuilder.Entity<Attack>().HasData(new Attack { Id = 13, Message = "Error Based SQL Injection Detected", Proto = "TCP", Severity = 5, Timestamp = new DateTime(2020, 10, 22, 15, 17, 49).ToUniversalTime(), Src_ip = "192.168.40.11", Dest_ip = "192.168.40.183" });
            modelBuilder.Entity<Attack>().HasData(new Attack { Id = 14, Message = "Error Based SQL Injection Detected", Proto = "TCP", Severity = 4, Timestamp = new DateTime(2020, 10, 23, 15, 17, 49).ToUniversalTime(), Src_ip = "192.168.40.11", Dest_ip = "192.168.40.183" });
            modelBuilder.Entity<Attack>().HasData(new Attack { Id = 15, Message = "Error Based SQL Injection Detected", Proto = "TCP", Severity = 2, Timestamp = new DateTime(2020, 10, 24, 15, 17, 49).ToUniversalTime(), Src_ip = "192.168.40.11", Dest_ip = "192.168.40.183" });
            modelBuilder.Entity<Attack>().HasData(new Attack { Id = 16, Message = "Error Based SQL Injection Detected", Proto = "TCP", Severity = 2, Timestamp = new DateTime(2020, 10, 25, 15, 17, 49).ToUniversalTime(), Src_ip = "192.168.40.11", Dest_ip = "192.168.40.183" });
            modelBuilder.Entity<Attack>().HasData(new Attack { Id = 17, Message = "Error Based SQL Injection Detected", Proto = "TCP", Severity = 1, Timestamp = new DateTime(2020, 10, 26, 15, 17, 49).ToUniversalTime(), Src_ip = "192.168.40.11", Dest_ip = "192.168.40.183" });
            modelBuilder.Entity<Attack>().HasData(new Attack { Id = 18, Message = "Error Based SQL Injection Detected", Proto = "TCP", Severity = 4, Timestamp = new DateTime(2020, 10, 27, 15, 17, 49).ToUniversalTime(), Src_ip = "192.168.40.11", Dest_ip = "192.168.40.183" });
            modelBuilder.Entity<Attack>().HasData(new Attack { Id = 19, Message = "Error Based SQL Injection Detected", Proto = "TCP", Severity = 5, Timestamp = new DateTime(2020, 10, 28, 15, 17, 49).ToUniversalTime(), Src_ip = "192.168.40.11", Dest_ip = "192.168.40.183" });
            modelBuilder.Entity<Attack>().HasData(new Attack { Id = 20, Message = "Error Based SQL Injection Detected", Proto = "TCP", Severity = 6, Timestamp = new DateTime(2020, 10, 29, 15, 17, 49).ToUniversalTime(), Src_ip = "192.168.40.11", Dest_ip = "192.168.40.183" });
            modelBuilder.Entity<Attack>().HasData(new Attack { Id = 21, Message = "Error Based SQL Injection Detected", Proto = "TCP", Severity = 6, Timestamp = new DateTime(2021, 2, 21, 10, 17, 49).ToUniversalTime(), Src_ip = "192.168.40.11", Dest_ip = "192.168.40.183" });
            modelBuilder.Entity<Attack>().HasData(new Attack { Id = 22, Message = "Error Based SQL Injection Detected", Proto = "TCP", Severity = 6, Timestamp = new DateTime(2021, 2, 21, 15, 17, 49).ToUniversalTime(), Src_ip = "192.168.40.11", Dest_ip = "192.168.40.183" });
            modelBuilder.Entity<Attack>().HasData(new Attack { Id = 23, Message = "Error Based SQL Injection Detected", Proto = "TCP", Severity = 6, Timestamp = new DateTime(2021, 2, 21, 21, 17, 49).ToUniversalTime(), Src_ip = "192.168.40.11", Dest_ip = "192.168.40.183" });
        }
    }
}
