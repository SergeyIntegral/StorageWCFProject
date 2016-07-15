using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Storage.Model;

namespace Storage.WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IProductRedactionWcfService" in both code and config file together.
    [ServiceContract]
    public interface IProductRedactionWcfService
    {
        [OperationContract]

        //[ReferencePreservingDataContractFormat]
        [ReferencePreservingProxyDataContractFormatAttribute]
        //[ApplyDataContractResolver]
        void Redaction(Product selectedProduct);

        [OperationContract]

        //[ReferencePreservingDataContractFormat]
        //[ApplyDataContractResolver]
        [ReferencePreservingProxyDataContractFormatAttribute]
        void Delete(int selectedProductId, int shelfId, int traderId, int pdId);

        [OperationContract]
        //[ApplyDataContractResolver]
        //[ReferencePreservingDataContractFormat]
        [ReferencePreservingProxyDataContractFormatAttribute]
        List<Product> ReloadProducts();

        [OperationContract]
        //[ApplyDataContractResolver]
        // [ReferencePreservingDataContractFormat]
        [ReferencePreservingProxyDataContractFormatAttribute]
        List<Shelf> ReloadShelf();

        [OperationContract]
        //[ApplyDataContractResolver]
        //[ReferencePreservingDataContractFormat]
        [ReferencePreservingProxyDataContractFormatAttribute]
        List<Trader> ReloadTrader();

        [OperationContract]
        //[ApplyDataContractResolver]
        //[ReferencePreservingDataContractFormat]
        [ReferencePreservingProxyDataContractFormatAttribute]
        List<ProductCategory> ReloadProductCategories();
        //[ApplyDataContractResolver]
        [OperationContract]
        [ReferencePreservingProxyDataContractFormatAttribute]

        Shelf GetShelf(int selectedProdictId);

    }
}
