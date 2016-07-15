using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Storage.Model;

namespace Storage.WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IProductCreateWcfService" in both code and config file together.
    [ServiceContract]
    public interface IProductCreateWcfService
    {
        [OperationContract]
        //[ReferencePreservingDataContractFormat]
        void AddProduct(Product product, Shelf shelf, ProductCategory productCategory, Trader trader);
    }
}
