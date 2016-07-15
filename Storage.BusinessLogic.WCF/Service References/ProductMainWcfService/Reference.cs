﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Storage.BusinessLogic.WCF.ProductMainWcfService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ProductMainWcfService.IProductMainWcfService")]
    public interface IProductMainWcfService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductMainWcfService/SearchProducts", ReplyAction="http://tempuri.org/IProductMainWcfService/SearchProductsResponse")]
        System.Collections.Generic.List<Storage.Model.Product> SearchProducts(string productName, string productNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductMainWcfService/SearchProducts", ReplyAction="http://tempuri.org/IProductMainWcfService/SearchProductsResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Storage.Model.Product>> SearchProductsAsync(string productName, string productNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductMainWcfService/ShowAllProducts", ReplyAction="http://tempuri.org/IProductMainWcfService/ShowAllProductsResponse")]
        System.Collections.Generic.List<Storage.Model.Product> ShowAllProducts();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductMainWcfService/ShowAllProducts", ReplyAction="http://tempuri.org/IProductMainWcfService/ShowAllProductsResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Storage.Model.Product>> ShowAllProductsAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IProductMainWcfServiceChannel : Storage.BusinessLogic.WCF.ProductMainWcfService.IProductMainWcfService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ProductMainWcfServiceClient : System.ServiceModel.ClientBase<Storage.BusinessLogic.WCF.ProductMainWcfService.IProductMainWcfService>, Storage.BusinessLogic.WCF.ProductMainWcfService.IProductMainWcfService {
        
        public ProductMainWcfServiceClient() {
        }
        
        public ProductMainWcfServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProductMainWcfServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductMainWcfServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductMainWcfServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.List<Storage.Model.Product> SearchProducts(string productName, string productNumber) {
            return base.Channel.SearchProducts(productName, productNumber);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Storage.Model.Product>> SearchProductsAsync(string productName, string productNumber) {
            return base.Channel.SearchProductsAsync(productName, productNumber);
        }
        
        public System.Collections.Generic.List<Storage.Model.Product> ShowAllProducts() {
            return base.Channel.ShowAllProducts();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Storage.Model.Product>> ShowAllProductsAsync() {
            return base.Channel.ShowAllProductsAsync();
        }
    }
}