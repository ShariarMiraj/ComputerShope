using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class TopSearchSelleingproductRepo : Repo, IRepo<TopSearchSelleingproduct, string, TopSearchSelleingproduct>
    {
        public Dictionary<string, decimal> ReadForPieChart()
        {
            throw new NotImplementedException();
        }

        public TopSearchSelleingproduct Create(TopSearchSelleingproduct obj)
        {
            var match = db.TopSearchSelleingproducts.Count(c => c.TopProductName == obj.TopProductName);
            if (match > 0)
            {
                var upd = (from s in db.TopSearchSelleingproducts
                           where s.TopProductName == obj.TopProductName
                           select s).SingleOrDefault();
                obj.Count = upd.Count + 1;
                obj.Id = upd.Id;
                obj.TopProductName = upd.TopProductName;
                db.Entry(upd).CurrentValues.SetValues(obj);
                db.SaveChanges();

            }
            else if (match == 0)
            {
                db.TopSearchSelleingproducts.Add(obj);
                db.SaveChanges();

            }
            return obj;
        }

        public bool Delete(string id)
        {
            var ex = Read(id);
            db.TopSearchSelleingproducts.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<TopSearchSelleingproduct> Read()
        {
            return db.TopSearchSelleingproducts.ToList();
        }

        public TopSearchSelleingproduct Read(string id)
        {
            return db.TopSearchSelleingproducts.Find(id);
        }

        public TopSearchSelleingproduct Update(TopSearchSelleingproduct obj)
        {
            var exdata = db.Products.Find(obj.Id);
            db.Entry(exdata).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
