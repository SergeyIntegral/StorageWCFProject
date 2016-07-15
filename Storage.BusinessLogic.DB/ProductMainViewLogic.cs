using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mita.Core;
using Storage.Model;
using Storage.DataAccess;

namespace Storage.BusinessLogic.DB
{
    [Export(typeof(IProductMainViewLogic))]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class ProductMainViewLogic:BusinessLogicBase,IProductMainViewLogic
    {
        
        public List<Product> SearchProducts(string productName = null, string productNumber = null)
        {
            var query = RepositoryProvider.GetRepository<Product>().GetAll(zz=>zz.ProductCategory,zz=>zz.Shelf,zz=>zz.Trader);

            if (!productNumber.IsNullOrEmpty())
            {
                query = query.Where(ba => ba.ProductNumber.Contains(productNumber));

            }
            else if(!productName.IsNullOrEmpty())
            {
                query = query.Where(ba => ba.ProductName.Contains(productName));
            }

            return query.ToList();
        }

        public List<Product> ShowAllProducts()
        {
            return RepositoryProvider.GetRepository<Product>().GetAll(zz=>zz.Shelf, zz=>zz.Trader, zz=>zz.ProductCategory).ToList();
            
        }
    }
}
