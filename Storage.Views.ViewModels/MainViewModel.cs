using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.Composition;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
using System.Text;
using Mita.Core;
using Mita.DataAccess;
using Mita.Mvvm;
using Storage.DataAccess;

using System.Threading.Tasks;
using Storage.BusinessLogic;
using Storage.Model;


namespace Storage.Views.ViewModels
{
    [Export]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class MainViewModel : ChildViewModel
    {
        //[Import]
        //private IRepositoryProvider RepositoryProvider { get; set; }
       // [Import(RequiredCreationPolicy = CreationPolicy.NonShared)]
       [Import]
        private IProductMainViewLogic ProductMainViewLogic { get; set; }

       // [Import(RequiredCreationPolicy = CreationPolicy.NonShared)]
       [Import]
        private IProductRedactionViewLogic ProductRedactionViewLogic { get; set; }

        private string _searchString;

        private DateTime? _searchDate;
        

        private string _productNumber;
        
        public ICollection<Product> _Products;
        
       


        public MainViewModel()
        {
            SearchCommand = new DelegateCommand(() => Task.Run((Action) Search));

            RedactionMaterialCommand = new DelegateCommand(()=>Task.Run((Action) RedactionMaterial));

           ShowAllCommand = new DelegateCommand(()=>Task.Run((Action) ShowAll));
            
            AddMaterialCommand = new DelegateCommand(()=>Task.Run((Action) AddMaterial));

           
        }


       

        public string SearchBox
        {
            get { return _searchString; }
            set
            {
                if (value == _searchString) return;
                _searchString = value;
                OnPropertyChanged();
            }
        }

        public DateTime? SearchDate {


            get {return _searchDate; }
            set
            {
                if (value == _searchDate) return;
                _searchDate = value;
                OnPropertyChanged();
            }
    }

        
        public string ProductNumber
        {
            get { return _productNumber; }
            set
            {
                if (value == _productNumber) return;
                _productNumber = value;
                OnPropertyChanged();
            }
        }
       

        public ICollection<Product> Products
        {
            get { return _Products = ProductRedactionViewLogic.ReloadProducts(); }
            set
            {
                if (Equals(value, _Products)) return;
                _Products = value;
                OnPropertyChanged();
            }
        }

        


        public DelegateCommand SearchCommand { get; private set; }

        public DelegateCommand RedactionMaterialCommand { get; private set; }

        public DelegateCommand CreateOrderCommand { get; private set; }

        public DelegateCommand ShowAllCommand { get; private set; }

        public DelegateCommand AddMaterialCommand { get; private set; }


        private void Search()
        {
            using (StartOperation())
            {
                #region

                //    var query = RepositoryProvider.GetRepository<Product>()
                //    .GetAll( product => product.Shelf, product => product.Trader, product => product.ProductCategory);

                //    if (!ProductNumber.IsNullOrEmpty())
                //    {
                //        query = query.Where(a=>a.ProductNumber.Contains(ProductNumber));
                //    }

                //    else if (!SearchBox.IsNullOrEmpty())
                //    {

                //        query = query.Where(a => a.ProductName.Contains(SearchBox));
                //        //query = query;

                //    }
                //    else if (SearchDate != null)
                //    {
                //        query = query.Where(a => a.CountDate.ToString().Contains(SearchDate.ToString()));
                //    }
                //    else
                //    {
                //        Products = new Product[] {}; 
                //        return;
                //    }
                //    Products = query.ToList();
                //}

                #endregion

                Products = ProductMainViewLogic.SearchProducts(SearchBox, ProductNumber);
            }
        }

        private void ShowAll()
        {
            
            
            using (StartOperation())
            {
                #region
                //var query = RepositoryProvider.GetRepository<Product>()
                //    .GetAll(product => product.Shelf, product => product.Trader, product => product.ProductCategory);//, 

                //if (ProductNumber.IsNullOrEmpty() || SearchBox.IsNullOrEmpty() || SearchDate == null)
                //{
                //    query = query;
                //}
                //else
                //{
                //    Products = new Product[] { };
                //    return;
                //}
                //Products = query.ToList();
                #endregion
                Products = ProductMainViewLogic.ShowAllProducts();
                OnPropertyChanged("Products");
                
            }
            
        }

        private void RedactionMaterial()
        {
            //RepositoryProvider.Dispose();
            var dn = ServiceLocator.GetInstance<RedactionMaterialViewModel>();
            dn.Parent = this;
            dn.Show();
            //ProductMainViewLogic.Dispose();
            dn.Closed += OnCreateMaterialViewModelClosed;

        }

        private void AddMaterial()
        {
            var dn = ServiceLocator.GetInstance<CreateAndDeleteViewModel>();
            dn.Show();
        }
        #region
        private void OnCreateMaterialViewModelClosed(object sender, EventArgs e)
        {
            var createMaterialViewModel = sender as RedactionMaterialViewModel;
            if (createMaterialViewModel != null && createMaterialViewModel.ModalResult)
            {
                ProductMainViewLogic.Dispose();
                ProductMainViewLogic = ServiceLocator.GetInstance<IProductMainViewLogic>();
                ShowAll();

            }
        }
        #endregion


        //protected override void OnClosed()
        //{
        //    base.OnClosed();
        //    ProductMainViewLogic.Dispose();
        //}



    }
}
    
