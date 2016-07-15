using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Storage.Model;

namespace Storage.WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IProductMainWcfService" in both code and config file together.
    [ServiceContract]
    public interface IProductMainWcfService
    {
        [OperationContract]

        //[ReferencePreservingDataContractFormat]
        [ReferencePreservingProxyDataContractFormatAttribute]
        //[ApplyDataContractResolver]
       
        List<Product> SearchProducts(string productName = null, string productNumber = null);

        [OperationContract]

        //[ReferencePreservingDataContractFormat]
        [ReferencePreservingProxyDataContractFormatAttribute]
        //[ApplyDataContractResolver]
        List<Product> ShowAllProducts();
    }
}
