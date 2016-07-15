using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Storage.Model;

namespace Storage.BusinessLogic.DB
{
    [Export(typeof(IProductCreateViewLogic))]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class ProductCreateViewLogic:BusinessLogicBase,IProductCreateViewLogic
    {
        public void AddProduct(Product product, Shelf shelf, ProductCategory productCategory, Trader trader)
        {
            product.InputDate = DateTime.Today;
            product.SoldDate = DateTime.Now;
            product.CountDate = DateTime.Now;
            RepositoryProvider.GetRepository<Product>().Add(product);

            RepositoryProvider.GetRepository<Shelf>().Add(shelf);
            // int i = 0;

            RepositoryProvider.GetRepository<ProductCategory>().Add(productCategory);

            RepositoryProvider.GetRepository<Trader>().Add(trader);


            RepositoryProvider.SaveChanges();
        }
    }
}
