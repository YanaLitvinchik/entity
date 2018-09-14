using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CategoryRepository : IRepository<Category>
    {
        ShopAdoEntities db = new ShopAdoEntities();
        
        public void Create(Category item)
        {
            db.Category.Add(item);
        }

        public void Delete(int id)
        {
            Category cat = db.Category.Find(id);
            if (cat != null)
                db.Category.Remove(cat);
        }

        public Category Get(int id)
        {
            return db.Category.Find(id);
        }

        public IEnumerable<Category> GetAll()
        {
            return db.Category;
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void Update(Category item)
        {
            db.Entry(item).State = EntityState.Modified;
        }
        ~CategoryRepository()
        {
            db.Dispose();
        }
    }
}
