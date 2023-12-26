using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class SalaryRepo : Repo, IRepo<Salary, int, bool>
    {
        public bool Create(Salary obj)
        {
            db.Salaris.Add(obj);
            if(db.SaveChanges() > 0)
                return false;
            return true;
        }

        public bool Delete(int id)
        {
            var ex = Read(id);
            db.Salaris.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<Salary> Read()
        {
            return db.Salaris.ToList();
        }

        public Salary Read(int id)
        {

            return db.Salaris.Find(id);
        }

        public bool Update(Salary obj)
        {
            var ex = Read(obj.Id);
            db.Entry(ex).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0)
                return true;
            return false;
        }

        /* public Dictionary<string ,decimal> ReadForPieChart()
         {
             return db.Salaris
                 .GroupBy(s => s.MonthName)
                 .ToDictionary(g => g.Key, g => g.Sum(s => Decimal.Parse(s.Amount))); // Parse Amount as Decimal

         }*/

        public Dictionary<string, decimal> ReadForPieChart()
        {
            return db.Salaris
                .GroupBy(s => s.MonthName)
                .ToDictionary(
                    g => g.Key,
                    g => g.Sum(s => Decimal.TryParse(s.Amount, out var amount) ? amount : 0)
                );
        }
    }
}
