using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace EFProject
{
    class Program
    {
        static void Ex1()
        {

            using (ShopAdoEntities db = new ShopAdoEntities())
            {
                //var goods = db.Good.ToList();
                ////foreach (var i in goods)
                ////    Console.WriteLine($"{i.GoodName,-30}\t{i.GoodCount,10}\t{i.Price}");
                //foreach (var i in goods)
                //    Console.WriteLine($"{i.GoodName}\t\t{i.Category?.CategoryName}");

                Category c = db.Category.FirstOrDefault(x => x.CategoryName.Contains("Note"));

                Good newgood = new Good
                {
                    GoodName = "Polutov Notebook",
                    Price = 1000,
                    GoodCount = 1,
                    CategoryId = 3
                };
                db.Good.Add(newgood);
                db.SaveChanges();
            }
        }
        static void Main(string[] args)
        {
        
            CategoryRepository repo =
                new CategoryRepository();
            ManufacturerRepository ma_repo =
                new ManufacturerRepository();

            foreach (var i in ma_repo.GetAll())
            {
                if (i.Good.Count > 0)
                Console.WriteLine(i.ManufacturerName);
                foreach (var j in i.Good)
                    Console.WriteLine($"\t\t{j.GoodName}");
            }
            //Category notebook = repo
            //               .GetAll()
            //                 .Single(x => x.CategoryName.Contains("Note"));

            //if (notebook != null)
            //{
            //    notebook.CategoryName = "Ноутбук";
            //    repo.Update(notebook);
            //    repo.Save();
            //}
        }
    }
}
