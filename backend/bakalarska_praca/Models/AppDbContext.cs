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
        public DbSet<Login> Logins { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Attack>().HasData(new Attack { Id = 1, Message = "Error Based SQL Injection Detected", Category="SQL" ,Proto = "TCP", Severity = 3, SeverityCategory="low", Timestamp = new DateTime(2021, 2, 10, 15, 17, 49).ToUniversalTime(), Src_ip = "192.168.40.11", Dest_ip = "192.168.40.183" });
            modelBuilder.Entity<Attack>().HasData(new Attack { Id = 2, Message = "Possible ICMP flood PING DoS", Category = "ICMP" ,Proto = "TCP", Severity = 10, SeverityCategory = "critical", Timestamp = new DateTime(2021, 2, 11, 15, 17, 49).ToUniversalTime(), Src_ip = "192.168.50.11", Dest_ip = "192.168.40.183" });
            modelBuilder.Entity<Attack>().HasData(new Attack { Id = 3, Message = "Error Based SQL Injection Detected", Category = "SQL", Proto = "UDP", Severity = 3, SeverityCategory = "low", Timestamp = new DateTime(2021, 2, 12, 15, 17, 49).ToUniversalTime(), Src_ip = "192.168.50.11", Dest_ip = "192.168.40.183" });
            modelBuilder.Entity<Attack>().HasData(new Attack { Id = 4, Message = "Possible ICMP flood PING DoS", Category = "ICMP", Proto = "TCP", Severity = 4, SeverityCategory = "medium", Timestamp = new DateTime(2021, 2, 13, 15, 17, 49).ToUniversalTime(), Src_ip = "192.168.60.11", Dest_ip = "192.168.40.183" });
            modelBuilder.Entity<Attack>().HasData(new Attack { Id = 5, Message = "Error Based SQL Injection Detected", Category = "SQL", Proto = "TCP", Severity = 4, SeverityCategory = "medium", Timestamp = new DateTime(2021, 2, 14, 15, 17, 49).ToUniversalTime(), Src_ip = "192.168.60.11", Dest_ip = "192.168.40.183" });
            modelBuilder.Entity<Attack>().HasData(new Attack { Id = 6, Message = "Possible TCP SYN DoS", Category = "SYN", Proto = "TCP", Severity = 5, SeverityCategory = "low", Timestamp = new DateTime(2021, 2, 15, 15, 17, 49).ToUniversalTime(), Src_ip = "192.168.40.11", Dest_ip = "192.168.60.183" });
            modelBuilder.Entity<Attack>().HasData(new Attack { Id = 7, Message = "Error Based SQL Injection Detected", Category = "SQL", Proto = "TCP", Severity = 5, SeverityCategory = "low", Timestamp = new DateTime(2021, 2, 16, 15, 17, 49).ToUniversalTime(), Src_ip = "192.168.60.11", Dest_ip = "192.168.40.183" });
            modelBuilder.Entity<Attack>().HasData(new Attack { Id = 8, Message = "Possible ICMP flood PING DoS", Category = "ICMP", Proto = "UDP", Severity = 4, SeverityCategory = "medium", Timestamp = new DateTime(2021, 2, 17, 15, 17, 49).ToUniversalTime(), Src_ip = "192.168.20.11", Dest_ip = "192.168.40.183" });
            modelBuilder.Entity<Attack>().HasData(new Attack { Id = 9, Message = "Error Based SQL Injection Detected", Category = "SQL", Proto = "TCP", Severity = 4, SeverityCategory = "low", Timestamp = new DateTime(2021, 2, 18, 15, 17, 49).ToUniversalTime(), Src_ip = "192.168.30.11", Dest_ip = "192.168.40.183" });
            modelBuilder.Entity<Attack>().HasData(new Attack { Id = 10, Message = "Error Based SQL Injection Detected", Category = "SQL", Proto = "TCP", Severity = 2, SeverityCategory = "low", Timestamp = new DateTime(2021, 2, 19, 15, 17, 49).ToUniversalTime(), Src_ip = "192.168.20.11", Dest_ip = "192.168.40.183" });
            modelBuilder.Entity<Attack>().HasData(new Attack { Id = 11, Message = "Possible UDP DoS", Category = "UDP", Proto = "TCP", Severity = 6, SeverityCategory = "medium", Timestamp = new DateTime(2021, 2, 20, 15, 17, 49).ToUniversalTime(), Src_ip = "192.168.40.11", Dest_ip = "192.168.40.183" });
            modelBuilder.Entity<Attack>().HasData(new Attack { Id = 12, Message = "Possible ICMP flood PING DoS", Category = "ICMP", Proto = "TCP", Severity = 7, SeverityCategory = "low", Timestamp = new DateTime(2021, 2, 21, 15, 17, 49).ToUniversalTime(), Src_ip = "192.168.40.11", Dest_ip = "192.168.40.183" });
            modelBuilder.Entity<Attack>().HasData(new Attack { Id = 13, Message = "Error Based SQL Injection Detected", Category = "SQL", Proto = "TCP", Severity = 5, SeverityCategory = "medium", Timestamp = new DateTime(2021, 2, 22, 15, 17, 49).ToUniversalTime(), Src_ip = "192.168.20.11", Dest_ip = "192.168.40.183" });
            modelBuilder.Entity<Attack>().HasData(new Attack { Id = 14, Message = "Error Based SQL Injection Detected", Category = "SQL", Proto = "UDP", Severity = 7, SeverityCategory = "high", Timestamp = new DateTime(2021, 2, 23, 15, 17, 49).ToUniversalTime(), Src_ip = "192.168.40.11", Dest_ip = "192.168.40.183" });
            modelBuilder.Entity<Attack>().HasData(new Attack { Id = 15, Message = "Possible TCP SYN DoS", Category = "SYN", Proto = "TCP", Severity = 2, SeverityCategory = "low", Timestamp = new DateTime(2021, 2, 24, 15, 17, 49).ToUniversalTime(), Src_ip = "192.168.40.11", Dest_ip = "192.168.40.183" });
            modelBuilder.Entity<Attack>().HasData(new Attack { Id = 16, Message = "Error Based SQL Injection Detected", Category = "SQL", Proto = "TCP", Severity = 1, SeverityCategory = "low", Timestamp = new DateTime(2021, 2, 25, 15, 17, 49).ToUniversalTime(), Src_ip = "192.168.30.11", Dest_ip = "192.168.40.183" });
            modelBuilder.Entity<Attack>().HasData(new Attack { Id = 17, Message = "Possible ICMP flood PING DoS", Category = "ICMP", Proto = "UDP", Severity = 4, SeverityCategory = "medium", Timestamp = new DateTime(2021, 2, 26, 15, 17, 49).ToUniversalTime(), Src_ip = "192.168.40.11", Dest_ip = "192.168.40.183" });
            modelBuilder.Entity<Attack>().HasData(new Attack { Id = 18, Message = "Error Based SQL Injection Detected", Category = "SQL", Proto = "TCP", Severity = 9, SeverityCategory = "critical", Timestamp = new DateTime(2021, 2, 27, 15, 17, 49).ToUniversalTime(), Src_ip = "192.168.40.11", Dest_ip = "192.168.40.183" });
            modelBuilder.Entity<Attack>().HasData(new Attack { Id = 19, Message = "Possible UDP DoS", Category = "UDP", Proto = "TCP", Severity = 2, SeverityCategory = "low", Timestamp = new DateTime(2021, 2, 28, 15, 17, 49).ToUniversalTime(), Src_ip = "192.168.40.11", Dest_ip = "192.168.50.183" });
            modelBuilder.Entity<Attack>().HasData(new Attack { Id = 20, Message = "Error Based SQL Injection Detected", Category = "SQL", Proto = "TCP", Severity = 8, SeverityCategory = "high", Timestamp = new DateTime(2021, 2, 9, 15, 17, 49).ToUniversalTime(), Src_ip = "192.168.40.11", Dest_ip = "192.168.40.183" });
            modelBuilder.Entity<Attack>().HasData(new Attack { Id = 21, Message = "Possible ICMP flood PING DoS", Category = "ICMP", Proto = "TCP", Severity = 7, SeverityCategory = "high", Timestamp = new DateTime(2021, 2, 8, 10, 17, 49).ToUniversalTime(), Src_ip = "192.168.40.11", Dest_ip = "192.168.40.183" });
            modelBuilder.Entity<Attack>().HasData(new Attack { Id = 22, Message = "Error Based SQL Injection Detected", Category = "SQL", Proto = "UDP", Severity = 1, SeverityCategory = "low", Timestamp = new DateTime(2021, 3, 1, 15, 17, 49).ToUniversalTime(), Src_ip = "192.168.60.11", Dest_ip = "192.168.40.183" });
            modelBuilder.Entity<Attack>().HasData(new Attack { Id = 23, Message = "Possible TCP SYN DoS", Category = "SYN", Proto = "TCP", Severity = 9, SeverityCategory = "critical", Timestamp = new DateTime(2021, 3, 1, 21, 17, 49).ToUniversalTime(), Src_ip = "192.168.70.11", Dest_ip = "192.168.40.183" });
        }
    }
}
