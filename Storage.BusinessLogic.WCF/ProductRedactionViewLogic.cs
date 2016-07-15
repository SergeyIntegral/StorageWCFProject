using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Storage.BusinessLogic.WCF.ProductRedactionWcfService;
using Storage.Model;

namespace Storage.BusinessLogic.WCF
{
    [Export(typeof(IProductRedactionViewLogic))]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class ProductRedactionViewLogic: IProductRedactionViewLogic
    {
        [Import]
        private ProductRedactionWcfServiceClient ServiceClient { get; set; }
        public void Dispose()
        {
            ServiceClient?.Close();
        }

        public void Redaction(Product selectedProduct)
        {
            ServiceClient.Redaction(selectedProduct);
        }

        public void Delete(int selectedProductId, int shelfId, int traderId, int pdId)
        {
            ServiceClient.Delete(selectedProductId,shelfId,traderId,pdId);
        }

        //public void Delete(Product selectedProduct)
        //{
        //    ServiceClient.Delete(selectedProduct);
        //}

        public List<Product> ReloadProducts()
        {
            return ServiceClient.ReloadProducts();
        }

        public List<Shelf> ReloadShelf()
        {
            return ServiceClient.ReloadShelf();
        }

        public List<Trader> ReloadTrader()
        {
            return ServiceClient.ReloadTrader();
        }

        public List<ProductCategory> ReloadProductCategories()
        {
            return ServiceClient.ReloadProductCategories();
        }

        public Shelf GetShelf(int selectedProdictId)
        {
            return ServiceClient.GetShelf(selectedProdictId);
        }
    }
}
