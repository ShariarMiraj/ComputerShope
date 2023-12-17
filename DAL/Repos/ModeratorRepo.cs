using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class ModeratorRepo : Repo, IRepo<Moderator, int, bool>
    {
        public bool Create(Moderator obj)
        {
           db.Moderators.Add(obj);
            if(db.SaveChanges()  > 0)
                return true;
            return false;
        }

        public bool Delete(int id)
        {
            var ex = Read(id);
            db.Moderators.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<Moderator> Read()
        {
            return db.Moderators.ToList();
        }

        public Moderator Read(int id)
        {
            return db.Moderators.Find(id);
        }

        public bool Update(Moderator obj)
        {
            var ex = Read(obj.Id);
            db.Entry(ex).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0)
                return true;
            return false;
        }
    }
}
