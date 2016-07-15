using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mita.Core;
using Storage.Model;
using Storage.DataAccess;

namespace Storage.BusinessLogic.DB
{
    [Export(typeof(IProductRedactionViewLogic))]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class ProductRedactionViewLogic:BusinessLogicBase,IProductRedactionViewLogic
    {
        public void Redaction(Product selectedProduct)
        {
            

           // if (RepositoryProvider.GetRepository<Product>().Find(selectedProduct.Id) != null)

            Product originalSelectedProduct =
                RepositoryProvider.GetRepository<Product>().GetAll().AsQueryable().First(zz => zz.Id == selectedProduct.Id);

            RepositoryProvider.GetRepository<Product>().Detach(originalSelectedProduct);
            RepositoryProvider.GetRepository<Product>().Update(selectedProduct);
            //RepositoryProvider.SaveChanges();




        }

        public void Delete(int selectedProductId, int shelfId, int traderId, int pdId)
        {
            if (RepositoryProvider.GetRepository<Product>().Find(selectedProductId) != null)
            {
                RepositoryProvider.GetRepository<Product>().RemoveById(selectedProductId);
                RepositoryProvider.GetRepository<Product>().RemoveById(shelfId);
                RepositoryProvider.GetRepository<Product>().RemoveById(traderId);
                RepositoryProvider.GetRepository<Product>().RemoveById(pdId);

                RepositoryProvider.SaveChanges();
            }
        }

        //public void Delete(Product selectedProduct)
        //{
        //    if (selectedProduct != null)
        //    {
        //        if (RepositoryProvider.GetRepository<Product>().Find(selectedProduct.Id) != null)
        //        {
        //RepositoryProvider.GetRepository<Product>().Remove(selectedProduct.Id);





        //            RepositoryProvider.SaveChanges();
        //        }
        //    }
        //}

        public Shelf GetShelf(int selectedProdictId)
        {
            Shelf shelf =
                RepositoryProvider.GetRepository<Shelf>()
                    .GetAll(e => e.Products).FirstOrDefault(e => e.Id == selectedProdictId);

            return shelf;
        }

        public List<Product> ReloadProducts()
        {
            return RepositoryProvider.GetRepository<Product>().GetAll(e=>e.Shelf,e=>e.Trader, e=>e.ProductCategory).ToList();
        }

        public List<Shelf> ReloadShelf()
        {
            return RepositoryProvider.GetRepository<Shelf>().GetAll().ToList();
        }

        public List<Trader> ReloadTrader()
        {
            return RepositoryProvider.GetRepository<Trader>().GetAll().ToList();
        }

        public List<ProductCategory> ReloadProductCategories()
        {
            return RepositoryProvider.GetRepository<ProductCategory>().GetAll().ToList();
        }
    }
}
