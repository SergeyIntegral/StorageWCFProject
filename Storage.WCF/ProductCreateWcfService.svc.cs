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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ProductCreateWcfService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ProductCreateWcfService.svc or ProductCreateWcfService.svc.cs at the Solution Explorer and start debugging.
    public class ProductCreateWcfService : IProductCreateWcfService, IDisposable
    {
        [Import]
        private IProductCreateViewLogic ProductCreateViewLogic { get; set; }

        public ProductCreateWcfService()
        {
            var container = ServiceLocator.Current.GetInstance<CompositionContainer>();
            container.ComposeParts(this);
        }

        public void AddProduct(Product product, Shelf shelf, ProductCategory productCategory, Trader trader)
        {
            ProductCreateViewLogic.AddProduct(product, shelf, productCategory, trader);
        }

        public void Dispose()
        {
            ProductCreateViewLogic?.Dispose();
        }
    }
}
