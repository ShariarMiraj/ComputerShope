using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    internal class ComputerShopeContext : DbContext
    {
        public DbSet<Moderator> Moderators { get; set; }

        public DbSet<Salary> Salaris { get; set; }

        public DbSet<AttendanceReport> AttendanceReports { get; set; }
    }
}
