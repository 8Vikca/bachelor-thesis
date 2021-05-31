using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bakalarska_praca.Models
{
    /// <summary>Class <c>AppDbContext</c> works with local database (migrations) </summary>
    public class AppDbContext : DbContext      
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {

        }
        public DbSet<Attack> Attacks { get; set; }
        public DbSet<User> Logins { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Attack>().HasData(new Attack { Id = 1, Message = "Error Based SQL Injection Detected", Category="SQL" ,Proto = "TCP", Severity = 3, SeverityCategory="low", Timestamp = new DateTime(2021, 3, 20, 15, 17, 49).ToUniversalTime(), Src_ip = "192.168.40.11", Dest_ip = "192.168.40.183" });
            modelBuilder.Entity<Attack>().HasData(new Attack { Id = 2, Message = "Possible ICMP flood PING DoS", Category = "ICMP" ,Proto = "TCP", Severity = 10, SeverityCategory = "critical", Timestamp = new DateTime(2021, 3, 20, 10, 17, 49).ToUniversalTime(), Src_ip = "192.168.50.11", Dest_ip = "192.168.40.183" });
            modelBuilder.Entity<Attack>().HasData(new Attack { Id = 3, Message = "Error Based SQL Injection Detected", Category = "SQL", Proto = "UDP", Severity = 3, SeverityCategory = "low", Timestamp = new DateTime(2021, 3, 20, 15, 17, 49).ToUniversalTime(), Src_ip = "192.168.50.11", Dest_ip = "192.168.40.183" });
            modelBuilder.Entity<Attack>().HasData(new Attack { Id = 4, Message = "Possible ICMP flood PING DoS", Category = "ICMP", Proto = "TCP", Severity = 4, SeverityCategory = "medium", Timestamp = new DateTime(2021, 3, 23, 15, 17, 49).ToUniversalTime(), Src_ip = "192.168.60.11", Dest_ip = "192.168.40.183" });
            modelBuilder.Entity<Attack>().HasData(new Attack { Id = 5, Message = "Error Based SQL Injection Detected", Category = "SQL", Proto = "TCP", Severity = 4, SeverityCategory = "medium", Timestamp = new DateTime(2021, 3, 24, 15, 17, 49).ToUniversalTime(), Src_ip = "192.168.60.11", Dest_ip = "192.168.40.183" });
            modelBuilder.Entity<Attack>().HasData(new Attack { Id = 6, Message = "Possible TCP SYN DoS", Category = "SYN", Proto = "TCP", Severity = 2, SeverityCategory = "low", Timestamp = new DateTime(2021, 3, 25, 8, 17, 49).ToUniversalTime(), Src_ip = "192.168.40.11", Dest_ip = "192.168.60.183" });
            modelBuilder.Entity<Attack>().HasData(new Attack { Id = 7, Message = "Error Based SQL Injection Detected", Category = "SQL", Proto = "TCP", Severity = 1, SeverityCategory = "low", Timestamp = new DateTime(2021, 3, 25, 15, 17, 49).ToUniversalTime(), Src_ip = "192.168.60.11", Dest_ip = "192.168.40.183" });
            modelBuilder.Entity<Attack>().HasData(new Attack { Id = 8, Message = "Possible ICMP flood PING DoS", Category = "ICMP", Proto = "UDP", Severity = 4, SeverityCategory = "medium", Timestamp = new DateTime(2021, 4, 5, 15, 17, 49).ToUniversalTime(), Src_ip = "192.168.20.11", Dest_ip = "192.168.40.183" });
            modelBuilder.Entity<Attack>().HasData(new Attack { Id = 9, Message = "Error Based SQL Injection Detected", Category = "SQL", Proto = "TCP", Severity = 3, SeverityCategory = "low", Timestamp = new DateTime(2021, 4, 5, 19, 17, 49).ToUniversalTime(), Src_ip = "192.168.30.11", Dest_ip = "192.168.40.183" });
            modelBuilder.Entity<Attack>().HasData(new Attack { Id = 10, Message = "Error Based SQL Injection Detected", Category = "SQL", Proto = "TCP", Severity = 2, SeverityCategory = "low", Timestamp = new DateTime(2021, 4, 5, 15, 17, 49).ToUniversalTime(), Src_ip = "192.168.20.11", Dest_ip = "192.168.40.183" });
            modelBuilder.Entity<Attack>().HasData(new Attack { Id = 11, Message = "Possible UDP DoS", Category = "UDP", Proto = "TCP", Severity = 6, SeverityCategory = "medium", Timestamp = new DateTime(2021, 4, 9, 15, 17, 49).ToUniversalTime(), Src_ip = "192.168.40.11", Dest_ip = "192.168.40.183" });
            modelBuilder.Entity<Attack>().HasData(new Attack { Id = 12, Message = "Possible ICMP flood PING DoS", Category = "ICMP", Proto = "TCP", Severity = 7, SeverityCategory = "high", Timestamp = new DateTime(2021, 4, 10, 14, 17, 49).ToUniversalTime(), Src_ip = "192.168.40.11", Dest_ip = "192.168.40.183" });
            modelBuilder.Entity<Attack>().HasData(new Attack { Id = 13, Message = "Error Based SQL Injection Detected", Category = "SQL", Proto = "TCP", Severity = 5, SeverityCategory = "medium", Timestamp = new DateTime(2021, 4, 10, 15, 17, 49).ToUniversalTime(), Src_ip = "192.168.20.11", Dest_ip = "192.168.40.183" });
            modelBuilder.Entity<Attack>().HasData(new Attack { Id = 14, Message = "Error Based SQL Injection Detected", Category = "SQL", Proto = "UDP", Severity = 7, SeverityCategory = "high", Timestamp = new DateTime(2021, 4, 11, 15, 17, 49).ToUniversalTime(), Src_ip = "192.168.40.11", Dest_ip = "192.168.40.183" });
            modelBuilder.Entity<Attack>().HasData(new Attack { Id = 15, Message = "Possible TCP SYN DoS", Category = "SYN", Proto = "TCP", Severity = 2, SeverityCategory = "low", Timestamp = new DateTime(2021, 4, 11, 15, 17, 49).ToUniversalTime(), Src_ip = "192.168.40.11", Dest_ip = "192.168.40.183" });
            modelBuilder.Entity<Attack>().HasData(new Attack { Id = 16, Message = "Error Based SQL Injection Detected", Category = "SQL", Proto = "TCP", Severity = 1, SeverityCategory = "low", Timestamp = new DateTime(2021, 4, 12, 15, 17, 49).ToUniversalTime(), Src_ip = "192.168.30.11", Dest_ip = "192.168.40.183" });
            modelBuilder.Entity<Attack>().HasData(new Attack { Id = 17, Message = "Possible ICMP flood PING DoS", Category = "ICMP", Proto = "UDP", Severity = 4, SeverityCategory = "medium", Timestamp = new DateTime(2021, 4, 13, 15, 17, 49).ToUniversalTime(), Src_ip = "192.168.40.11", Dest_ip = "192.168.40.183" });
            modelBuilder.Entity<Attack>().HasData(new Attack { Id = 18, Message = "Error Based SQL Injection Detected", Category = "SQL", Proto = "TCP", Severity = 9, SeverityCategory = "critical", Timestamp = new DateTime(2021, 4, 14, 15, 17, 49).ToUniversalTime(), Src_ip = "192.168.40.11", Dest_ip = "192.168.40.183" });
            modelBuilder.Entity<Attack>().HasData(new Attack { Id = 19, Message = "Possible UDP DoS", Category = "UDP", Proto = "TCP", Severity = 2, SeverityCategory = "low", Timestamp = new DateTime(2021, 4, 15, 15, 17, 49).ToUniversalTime(), Src_ip = "192.168.40.11", Dest_ip = "192.168.50.183" });
            modelBuilder.Entity<Attack>().HasData(new Attack { Id = 20, Message = "Error Based SQL Injection Detected", Category = "SQL", Proto = "TCP", Severity = 8, SeverityCategory = "high", Timestamp = new DateTime(2021, 4, 15, 15, 17, 49).ToUniversalTime(), Src_ip = "192.168.40.11", Dest_ip = "192.168.40.183" });
            modelBuilder.Entity<Attack>().HasData(new Attack { Id = 21, Message = "Possible ICMP flood PING DoS", Category = "ICMP", Proto = "TCP", Severity = 7, SeverityCategory = "high", Timestamp = new DateTime(2021, 4, 16, 10, 17, 49).ToUniversalTime(), Src_ip = "192.168.40.11", Dest_ip = "192.168.40.183" });
            modelBuilder.Entity<Attack>().HasData(new Attack { Id = 22, Message = "Error Based SQL Injection Detected", Category = "SQL", Proto = "UDP", Severity = 1, SeverityCategory = "low", Timestamp = new DateTime(2021, 4, 17, 15, 17, 49).ToUniversalTime(), Src_ip = "192.168.60.11", Dest_ip = "192.168.40.183" });
            modelBuilder.Entity<Attack>().HasData(new Attack { Id = 23, Message = "Possible TCP SYN DoS", Category = "SYN", Proto = "TCP", Severity = 9, SeverityCategory = "critical", Timestamp = new DateTime(2021, 4, 18, 1, 17, 49).ToUniversalTime(), Src_ip = "192.168.70.11", Dest_ip = "192.168.40.183" });
            modelBuilder.Entity<Attack>().HasData(new Attack { Id = 24, Message = "Error Based SQL Injection Detected", Category = "SQL", Proto = "TCP", Severity = 8, SeverityCategory = "high", Timestamp = new DateTime(2021, 4, 19, 5, 17, 49).ToUniversalTime(), Src_ip = "192.168.40.11", Dest_ip = "192.168.40.183" });
            modelBuilder.Entity<Attack>().HasData(new Attack { Id = 25, Message = "Possible ICMP flood PING DoS", Category = "ICMP", Proto = "TCP", Severity = 7, SeverityCategory = "high", Timestamp = new DateTime(2021, 4, 19, 10, 17, 49).ToUniversalTime(), Src_ip = "192.168.40.11", Dest_ip = "192.168.40.183" });
            modelBuilder.Entity<Attack>().HasData(new Attack { Id = 26, Message = "Error Based SQL Injection Detected", Category = "SQL", Proto = "UDP", Severity = 1, SeverityCategory = "low", Timestamp = new DateTime(2021, 4, 20, 10, 45, 49).ToUniversalTime(), Src_ip = "192.168.60.11", Dest_ip = "192.168.40.183" });
            modelBuilder.Entity<Attack>().HasData(new Attack { Id = 27, Message = "Possible TCP SYN DoS", Category = "SYN", Proto = "TCP", Severity = 9, SeverityCategory = "critical", Timestamp = new DateTime(2021, 4, 21, 21, 17, 49).ToUniversalTime(), Src_ip = "192.168.70.11", Dest_ip = "192.168.40.183" });
            modelBuilder.Entity<Attack>().HasData(new Attack { Id = 28, Message = "Possible ICMP flood PING DoS", Category = "ICMP", Proto = "TCP", Severity = 7, SeverityCategory = "high", Timestamp = new DateTime(2021, 4, 22, 10, 17, 49).ToUniversalTime(), Src_ip = "192.168.40.11", Dest_ip = "192.168.40.183" });
            modelBuilder.Entity<Attack>().HasData(new Attack { Id = 29, Message = "Error Based SQL Injection Detected", Category = "SQL", Proto = "UDP", Severity = 1, SeverityCategory = "low", Timestamp = new DateTime(2021, 4, 23, 10, 45, 49).ToUniversalTime(), Src_ip = "192.168.60.11", Dest_ip = "192.168.40.183" });
            modelBuilder.Entity<Attack>().HasData(new Attack { Id = 30, Message = "Possible TCP SYN DoS", Category = "SYN", Proto = "TCP", Severity = 9, SeverityCategory = "critical", Timestamp = new DateTime(2021, 4, 24, 21, 17, 49).ToUniversalTime(), Src_ip = "192.168.70.11", Dest_ip = "192.168.40.183" });
            modelBuilder.Entity<Attack>().HasData(new Attack { Id = 31, Message = "Possible ICMP flood PING DoS", Category = "ICMP", Proto = "TCP", Severity = 7, SeverityCategory = "high", Timestamp = new DateTime(2021, 4, 25, 10, 17, 49).ToUniversalTime(), Src_ip = "192.168.40.11", Dest_ip = "192.168.40.183" });
            modelBuilder.Entity<Attack>().HasData(new Attack { Id = 32, Message = "Error Based SQL Injection Detected", Category = "SQL", Proto = "UDP", Severity = 1, SeverityCategory = "low", Timestamp = new DateTime(2021, 4, 26, 10, 45, 49).ToUniversalTime(), Src_ip = "192.168.60.11", Dest_ip = "192.168.40.183" });
            modelBuilder.Entity<Attack>().HasData(new Attack { Id = 33, Message = "Possible TCP SYN DoS", Category = "SYN", Proto = "TCP", Severity = 9, SeverityCategory = "critical", Timestamp = new DateTime(2021, 4, 29, 1, 17, 49).ToUniversalTime(), Src_ip = "192.168.70.11", Dest_ip = "192.168.40.183" });
            modelBuilder.Entity<Attack>().HasData(new Attack { Id = 34, Message = "Possible ICMP flood PING DoS", Category = "ICMP", Proto = "TCP", Severity = 7, SeverityCategory = "high", Timestamp = new DateTime(2021, 3, 29, 10, 17, 49).ToUniversalTime(), Src_ip = "192.168.40.11", Dest_ip = "192.168.40.183" });
            modelBuilder.Entity<Attack>().HasData(new Attack { Id = 35, Message = "Error Based SQL Injection Detected", Category = "SQL", Proto = "UDP", Severity = 1, SeverityCategory = "low", Timestamp = new DateTime(2021, 3, 29, 19, 45, 49).ToUniversalTime(), Src_ip = "192.168.60.11", Dest_ip = "192.168.40.183" });
            modelBuilder.Entity<Attack>().HasData(new Attack { Id = 36, Message = "Possible TCP SYN DoS", Category = "SYN", Proto = "TCP", Severity = 9, SeverityCategory = "critical", Timestamp = new DateTime(2021, 3, 30, 21, 17, 49).ToUniversalTime(), Src_ip = "192.168.70.11", Dest_ip = "192.168.40.183" });

        }
    }
}
