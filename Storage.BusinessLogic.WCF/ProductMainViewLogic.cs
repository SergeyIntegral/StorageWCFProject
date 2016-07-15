using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Storage.BusinessLogic.WCF.ProductMainWcfService;
using Storage.Model;

namespace Storage.BusinessLogic.WCF
{
    [Export(typeof(IProductMainViewLogic))]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class ProductMainViewLogic:IProductMainViewLogic
    {
        [Import]
        private ProductMainWcfServiceClient ServiceClient { get; set; }
        public void Dispose()
        {
            ServiceClient?.Close();
        }

        public List<Product> SearchProducts(string productName = null, string productNumber = null)
        {
            return ServiceClient.SearchProducts(productName, productNumber);
        }

        public List<Product> ShowAllProducts()
        {
            return ServiceClient.ShowAllProducts();
        }
    }
}
