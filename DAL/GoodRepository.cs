using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class GoodRepository : IRepository<Good>
    {
        ShopAdoEntities db = new ShopAdoEntities();

        public void Create(Good item)
        {
            db.Good.Add(item);
        }

        public void Delete(int id)
        {
            Good cat = db.Good.Find(id);
            if (cat != null)
                db.Good.Remove(cat);
        }

        public Good Get(int id)
        {
            return db.Good.Find(id);
        }

        public IEnumerable<Good> GetAll()
        {
            return db.Good;
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void Update(Good item)
        {
            db.Entry(item).State = EntityState.Modified;
        }
        ~GoodRepository()
        {
            db.Dispose();
        }
    }
}
