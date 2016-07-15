using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Storage.BusinessLogic.WCF.ProductCreateWcfService;
using Storage.Model;

namespace Storage.BusinessLogic.WCF
{
    [Export(typeof(IProductCreateViewLogic))]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class ProductCreateViewLogic:IProductCreateViewLogic
    {

        [Import]
        private ProductCreateWcfServiceClient ServiceClient { get; set; }

        public void Dispose()
        {
            ServiceClient?.Close();
        }

        public void AddProduct(Product product, Shelf shelf, ProductCategory productCategory, Trader trader)
        {
            ServiceClient.AddProduct(product, shelf, productCategory, trader);
        }
    }
}
