using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Storage.Model;

namespace Storage.BusinessLogic
{
    public interface IProductRedactionViewLogic:IBusinessLogic
    {
        void Redaction(Product selectedProduct);
        //void Delete(Product selectedProduct);
        void Delete(int selectedProductId, int shelfId, int traderId, int pdId);
        Shelf GetShelf(int selectedProdictId);
        List<Product> ReloadProducts();
        List<Shelf> ReloadShelf();
        List<Trader> ReloadTrader();
        List<ProductCategory> ReloadProductCategories();
    }
}
