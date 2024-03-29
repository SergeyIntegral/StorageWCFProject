﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Storage.BusinessLogic.WCF.ProductRedactionWcfService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ProductRedactionWcfService.IProductRedactionWcfService")]
    public interface IProductRedactionWcfService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductRedactionWcfService/Redaction", ReplyAction="http://tempuri.org/IProductRedactionWcfService/RedactionResponse")]
        void Redaction(Storage.Model.Product selectedProduct);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductRedactionWcfService/Redaction", ReplyAction="http://tempuri.org/IProductRedactionWcfService/RedactionResponse")]
        System.Threading.Tasks.Task RedactionAsync(Storage.Model.Product selectedProduct);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductRedactionWcfService/Delete", ReplyAction="http://tempuri.org/IProductRedactionWcfService/DeleteResponse")]
        void Delete(int selectedProductId, int shelfId, int traderId, int pdId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductRedactionWcfService/Delete", ReplyAction="http://tempuri.org/IProductRedactionWcfService/DeleteResponse")]
        System.Threading.Tasks.Task DeleteAsync(int selectedProductId, int shelfId, int traderId, int pdId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductRedactionWcfService/ReloadProducts", ReplyAction="http://tempuri.org/IProductRedactionWcfService/ReloadProductsResponse")]
        System.Collections.Generic.List<Storage.Model.Product> ReloadProducts();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductRedactionWcfService/ReloadProducts", ReplyAction="http://tempuri.org/IProductRedactionWcfService/ReloadProductsResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Storage.Model.Product>> ReloadProductsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductRedactionWcfService/ReloadShelf", ReplyAction="http://tempuri.org/IProductRedactionWcfService/ReloadShelfResponse")]
        System.Collections.Generic.List<Storage.Model.Shelf> ReloadShelf();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductRedactionWcfService/ReloadShelf", ReplyAction="http://tempuri.org/IProductRedactionWcfService/ReloadShelfResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Storage.Model.Shelf>> ReloadShelfAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductRedactionWcfService/ReloadTrader", ReplyAction="http://tempuri.org/IProductRedactionWcfService/ReloadTraderResponse")]
        System.Collections.Generic.List<Storage.Model.Trader> ReloadTrader();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductRedactionWcfService/ReloadTrader", ReplyAction="http://tempuri.org/IProductRedactionWcfService/ReloadTraderResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Storage.Model.Trader>> ReloadTraderAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductRedactionWcfService/ReloadProductCategories", ReplyAction="http://tempuri.org/IProductRedactionWcfService/ReloadProductCategoriesResponse")]
        System.Collections.Generic.List<Storage.Model.ProductCategory> ReloadProductCategories();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductRedactionWcfService/ReloadProductCategories", ReplyAction="http://tempuri.org/IProductRedactionWcfService/ReloadProductCategoriesResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Storage.Model.ProductCategory>> ReloadProductCategoriesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductRedactionWcfService/GetShelf", ReplyAction="http://tempuri.org/IProductRedactionWcfService/GetShelfResponse")]
        Storage.Model.Shelf GetShelf(int selectedProdictId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductRedactionWcfService/GetShelf", ReplyAction="http://tempuri.org/IProductRedactionWcfService/GetShelfResponse")]
        System.Threading.Tasks.Task<Storage.Model.Shelf> GetShelfAsync(int selectedProdictId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IProductRedactionWcfServiceChannel : Storage.BusinessLogic.WCF.ProductRedactionWcfService.IProductRedactionWcfService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ProductRedactionWcfServiceClient : System.ServiceModel.ClientBase<Storage.BusinessLogic.WCF.ProductRedactionWcfService.IProductRedactionWcfService>, Storage.BusinessLogic.WCF.ProductRedactionWcfService.IProductRedactionWcfService {
        
        public ProductRedactionWcfServiceClient() {
        }
        
        public ProductRedactionWcfServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProductRedactionWcfServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductRedactionWcfServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductRedactionWcfServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void Redaction(Storage.Model.Product selectedProduct) {
            base.Channel.Redaction(selectedProduct);
        }
        
        public System.Threading.Tasks.Task RedactionAsync(Storage.Model.Product selectedProduct) {
            return base.Channel.RedactionAsync(selectedProduct);
        }
        
        public void Delete(int selectedProductId, int shelfId, int traderId, int pdId) {
            base.Channel.Delete(selectedProductId, shelfId, traderId, pdId);
        }
        
        public System.Threading.Tasks.Task DeleteAsync(int selectedProductId, int shelfId, int traderId, int pdId) {
            return base.Channel.DeleteAsync(selectedProductId, shelfId, traderId, pdId);
        }
        
        public System.Collections.Generic.List<Storage.Model.Product> ReloadProducts() {
            return base.Channel.ReloadProducts();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Storage.Model.Product>> ReloadProductsAsync() {
            return base.Channel.ReloadProductsAsync();
        }
        
        public System.Collections.Generic.List<Storage.Model.Shelf> ReloadShelf() {
            return base.Channel.ReloadShelf();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Storage.Model.Shelf>> ReloadShelfAsync() {
            return base.Channel.ReloadShelfAsync();
        }
        
        public System.Collections.Generic.List<Storage.Model.Trader> ReloadTrader() {
            return base.Channel.ReloadTrader();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Storage.Model.Trader>> ReloadTraderAsync() {
            return base.Channel.ReloadTraderAsync();
        }
        
        public System.Collections.Generic.List<Storage.Model.ProductCategory> ReloadProductCategories() {
            return base.Channel.ReloadProductCategories();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Storage.Model.ProductCategory>> ReloadProductCategoriesAsync() {
            return base.Channel.ReloadProductCategoriesAsync();
        }
        
        public Storage.Model.Shelf GetShelf(int selectedProdictId) {
            return base.Channel.GetShelf(selectedProdictId);
        }
        
        public System.Threading.Tasks.Task<Storage.Model.Shelf> GetShelfAsync(int selectedProdictId) {
            return base.Channel.GetShelfAsync(selectedProdictId);
        }
    }
}
