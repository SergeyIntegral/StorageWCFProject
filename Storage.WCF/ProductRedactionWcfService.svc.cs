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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ProductRedactionWcfService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ProductRedactionWcfService.svc or ProductRedactionWcfService.svc.cs at the Solution Explorer and start debugging.
    public class ProductRedactionWcfService : IProductRedactionWcfService,IDisposable
    {
        [Import]
        private IProductRedactionViewLogic ProductRedactionViewLogic { get; set; }

        public ProductRedactionWcfService()
        {
            var container = ServiceLocator.Current.GetInstance<CompositionContainer>();
            container.ComposeParts(this);
        }

        public void DoWork()
        {
        }

        public void Redaction(Product selectedProduct)
        {
           ProductRedactionViewLogic.Redaction(selectedProduct);
        }

        public void Delete(int selectedProductId, int shelfId, int traderId, int pdId)
        {
            ProductRedactionViewLogic.Delete(selectedProductId, shelfId, traderId, pdId);
        }

        public List<Product> ReloadProducts()
        {
            return ProductRedactionViewLogic.ReloadProducts();
        }

        public List<Shelf> ReloadShelf()
        {
            return ProductRedactionViewLogic.ReloadShelf();
        }

        public List<Trader> ReloadTrader()
        {
            return ProductRedactionViewLogic.ReloadTrader();
        }

        public List<ProductCategory> ReloadProductCategories()
        {
            return ProductRedactionViewLogic.ReloadProductCategories();
        }

        public Shelf GetShelf(int selectedProdictId)
        {
            return ProductRedactionViewLogic.GetShelf(selectedProdictId);
        }

        public void Dispose()
        {
            ProductRedactionViewLogic?.Dispose();
        }
    }
}
