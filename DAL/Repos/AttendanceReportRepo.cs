using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class AttendanceReportRepo : Repo, IRepo<AttendanceReport, int, bool>
    {
        public bool Create(AttendanceReport obj)
        {
            db.AttendanceReports.Add(obj);
            if (db.SaveChanges() > 0)
                return true;
            return false;
        }

        public bool Delete(int id)
        {
            var ex = Read(id);
            db.AttendanceReports.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<AttendanceReport> Read()
        {
            return db.AttendanceReports.ToList();
        }

        public AttendanceReport Read(int id)
        {
            return db.AttendanceReports.Find(id);
        }

        public bool Update(AttendanceReport obj)
        {

            var ex = Read(obj.Id);
            db.Entry(ex).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0)
                return true;
            return false;
        }

        public Dictionary<string, decimal> ReadForPieChart()
        {
            return db.AttendanceReports
                .GroupBy(a => new { a.EmployeeName, a.DateTime.Date }) // Group by EmployeeName and Date
                .ToDictionary(
                    g => $"{g.Key.EmployeeName} - {g.Key.Date.ToShortDateString()}",
                    g => (decimal)g.Count() // Convert count to decimal
                );
        }


    }
}
