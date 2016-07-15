using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Microsoft.Practices.ServiceLocation;
using Storage.BusinessLogic;
using Storage.Model;

namespace Storage.WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ProductMainWcfService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ProductMainWcfService.svc or ProductMainWcfService.svc.cs at the Solution Explorer and start debugging.
    [ServiceBehavior(InstanceContextMode =
    InstanceContextMode.Single)]
    [KnownType(typeof(Product))]
    public class ProductMainWcfService : IProductMainWcfService, IDisposable
    {
        [Import]
        private IProductMainViewLogic ProductMainViewLogic { get; set; }

        public ProductMainWcfService()
        {
            var container = ServiceLocator.Current.GetInstance<CompositionContainer>();
            container.ComposeParts(this);
        }

        public List<Product> SearchProducts(string productName = null, string productNumber = null)
        {
            var searchProducts = ProductMainViewLogic.SearchProducts(productName, productNumber);
            return searchProducts;
        }
        
        public List<Product> ShowAllProducts()
        {
            var showAllProducts = ProductMainViewLogic.ShowAllProducts();
            return showAllProducts;
        }

        public void Dispose()
        {
            ProductMainViewLogic?.Dispose();
        }
    }
}
