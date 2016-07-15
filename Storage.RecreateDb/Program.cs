using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Storage.DataAccess;
using Storage.Model;

namespace Storage.RecreateDb
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Check DB exists...");
            if (Database.Exists("StorageDbLAB"))
            {
                Console.WriteLine("DB exists. Deleting...");
                Database.Delete("StorageDbLAB");
            }
            else
            {
                Console.WriteLine("DB does not exist. Skip deleting.");
            }

            using (var db = new Db())
            {
                Console.WriteLine("Полка");
                var sh1 = new Shelf {Number = 1};
                var sh2 = new Shelf {Number = 2};
                db.Shelfes.Add(sh1);
                db.Shelfes.Add(sh2);
                db.SaveChanges();


                Console.WriteLine("Категории Товаров");
                var Sol = new ProductCategory {Number = 123231, ProductCategoryName = "Пищевые продукты"};
                var sahar = new ProductCategory {Number = 14441, ProductCategoryName = "Пищевые продукты"};
                db.ProductCategories.Add(Sol);
                db.ProductCategories.Add(sahar);
                db.SaveChanges();

                Console.WriteLine("Поставщики");

                var tr1 = new Trader {Adress = "Иркутск", Name = "ООО ываыв", PostIndex = "3454353"};
                var tr2 = new Trader { Adress = "Новосибирск", Name = "ООО аааа", PostIndex = "126666" };
                db.Traders.Add(tr1);
                db.Traders.Add(tr2);
                db.SaveChanges();

                Console.WriteLine("Товары");
                int k = 0;

                var pr1 = new Product
                {
                    ProductCategory = Sol,
                    ProductNumber = "999999",
                    ProductName = "Соль",
                    Price = 500,

                    //Traders = new List<Trader>
                    //{
                    //    tr1 //m-t-m

                    //},
                    Trader = tr2,
                    Input = 300,
                    InputDate = DateTime.Today,
                    Sold = 100,
                    SoldDate = DateTime.Today,
                    CountDate = DateTime.Today,
                    Shelf = sh1


                };
                var pr2 = new Product
                {
                    ProductCategory = sahar,
                    ProductNumber = "455555",
                    ProductName = "Сахар",
                    Price = 600,
                    //Traders = new List<Trader>
                    //{
                    //    tr2  //m-to-m

                    //},
                    Trader = tr1,
                    Input = 500,
                    InputDate = DateTime.Today,
                    Sold = 200,
                    SoldDate = DateTime.Today,
                    CountDate = DateTime.Today,
                    Shelf = sh2,

                };


            



                db.Products.Add(pr1);
                db.Products.Add(pr2);
                        
                  
                db.SaveChanges();

                Console.WriteLine("DONE!");
                Console.ReadKey();

            };
        }
            
        }
    }

