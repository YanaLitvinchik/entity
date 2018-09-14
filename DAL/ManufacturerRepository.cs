using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ManufacturerRepository : IRepository<Manufacturer>
    {
        ShopAdoEntities db = new ShopAdoEntities();

        public void Create(Manufacturer item)
        {
            db.Manufacturer.Add(item);
        }

        public void Delete(int id)
        {
            Manufacturer cat = db.Manufacturer.Find(id);
            if (cat != null)
                db.Manufacturer.Remove(cat);
        }

        public Manufacturer Get(int id)
        {
            return db.Manufacturer.Find(id);
        }

        public IEnumerable<Manufacturer> GetAll()
        {
            return db.Manufacturer;
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void Update(Manufacturer item)
        {
            db.Entry(item).State = EntityState.Modified;
        }
        ~ManufacturerRepository()
        {
            db.Dispose();
        }
    }
}
