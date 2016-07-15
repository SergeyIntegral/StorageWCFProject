using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.Deployment.Application;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mita.DataAccess;
using Mita.Mvvm;
using Storage.BusinessLogic;
using Storage.DataAccess;
using Storage.Model;


namespace Storage.Views.ViewModels
{

    [Export]
    [PartCreationPolicy(CreationPolicy.NonShared)]

    public class RedactionMaterialViewModel : ChildViewModel
    {
        //[Import]
        //private IRepositoryProvider RepositoryProvider { get; set; 
        [Import]
        private IProductRedactionViewLogic ProductRedactionViewLogic { get; set; }


        private Shelf _shelf;
        //private Trader _trader;
        public ICollection<Product> _Products;

        private ICollection<ProductCategory> _productCategories;

        private ICollection<Shelf> _shelves;

        private ICollection<Trader> _traders; 

        public ICollection<ProductCategory> ProductCategoryes = new List<ProductCategory>();

        public Product _SelecteProduct;

        //private ProductCategory _SelectedPc;//= new ProductCategory() ;

        //private Shelf _SelectedShelf; //= new Shelf();

        private Trader _trader;
        private ProductCategory _productCategory;

        
        

        public RedactionMaterialViewModel()
        {
           //_SelectedPc = new ProductCategory();
            SaveMaterial = new DelegateCommand(() => Task.Run((Action)Save));
            //CreateMaterial = new DelegateCommand(() => Task.Run((Action)Create));
            //SaveCommand = new DelegateCommand(() => Task.Run((Action)SaveR));
            DeleteCommand = new DelegateCommand(() => Task.Run((Action)Delete));
        }

       

        public DelegateCommand SaveMaterial { get; private set; }

        public DelegateCommand CreateMaterial { get; private set; }

        public DelegateCommand DeleteCommand { get; private set; }

        public DelegateCommand SaveCommand { get; private set; }

        public ICollection<Product> Products
        {
            get
            {
                return _Products = ProductRedactionViewLogic.ReloadProducts();
                //RepositoryProvider.GetRepository<Product>().GetAll().ToList(); 
            }

          set
            {
                    if (Equals(value, _Products)) return;
                    _Products = value;
                    OnPropertyChanged();
                }
            }

            public ICollection<ProductCategory> ProductCategories
            {
                get { return _productCategories = ProductRedactionViewLogic.ReloadProductCategories(); }
                set
                {
                    if (Equals(value, _productCategories)) return;
                    _productCategories = value;
                    OnPropertyChanged();
                }
            }

            public ICollection<Shelf> Shelves
            {
                get
                {
                    return _shelves = ProductRedactionViewLogic.ReloadShelf();
                    //RepositoryProvider.GetRepository<Shelf>().GetAll().ToList(); 
                }
                set
                {
                    if (Equals(value, _shelves)) return;
                    _shelves = value;
                    OnPropertyChanged();
                }
            }

            public ICollection<Trader> Traders
            {
                get
                {
                    return _traders = ProductRedactionViewLogic.ReloadTrader();
                    //RepositoryProvider.GetRepository<Trader>().GetAll().ToList();
                }
                set
                {
                    if (Equals(value, _traders)) return;
                    _traders = value;
                    OnPropertyChanged();
                }
            }


            public Product SelectedProduct
        {
            get { return _SelecteProduct; }
            set
            {
                if (!Equals(value, _SelecteProduct))
                {
                    _SelecteProduct = value;
                    OnPropertyChanged();
                }
               
                //OnPropertyChanged("Trader");
                //OnPropertyChanged("Shelf");
                //OnPropertyChanged("ProductCategory");
                //OnPropertyChanged(nameof(SelectedShelf));
            }
        }



        






        public Shelf Shelf
        {

            get
            {
                return _shelf ;
            }
            set
            {
                if (Equals(value, _shelf)) return;
                _shelf = value;
                OnPropertyChanged();
                // OnPropertyChanged("Trader");
                //OnPropertyChanged(nameof(SelectedShelf));
            }
        }

        public ProductCategory ProductCategory
        {
            get
            {


                return _productCategory;
            }
            set
            {
                if (Equals(value, _productCategory)) return;
                _productCategory = value;
                OnPropertyChanged();
                // OnPropertyChanged("Trader");
                //OnPropertyChanged(nameof(SelectedShelf));
            }

        }



        public void Save()
        {
            #region
            //if (RepositoryProvider.GetRepository<Product>().Find(SelectedProduct.Id) != null &&
            //    RepositoryProvider.GetRepository<ProductCategory>().Find(SelectedProduct.ProductCategory.Id) != null&&
            //    RepositoryProvider.GetRepository<Shelf>().Find(SelectedProduct.Shelf.Id) != null&&RepositoryProvider.GetRepository<Trader>().Find(SelectedProduct.Trader.Id)!=null)



            //{
            //    RepositoryProvider.SaveChanges();
            //   // RepositoryProvider.Dispose();

            //}
            //else
            //{
            //    RepositoryProvider.GetRepository<Product>().Add(SelectedProduct);
            //    RepositoryProvider.GetRepository<ProductCategory>().Add(SelectedProduct.ProductCategory);
            //    RepositoryProvider.GetRepository<Shelf>().Add(SelectedProduct.Shelf);
            //    RepositoryProvider.GetRepository<Trader>().Add(SelectedProduct.Trader);

            //    RepositoryProvider.SaveChanges();
#endregion

            SelectedProduct.Shelf.Products = null;
            SelectedProduct.Trader.Products = null;
            
            ProductRedactionViewLogic.Redaction(SelectedProduct);
                ReloadProducts();
                ReloadProductCategoryes();
                ReloadShelves();
                ReloadTraders();
            OnPropertyChanged("Products");
           // Close(true);
               
            }

            //Close(true);
            
        

        


        public void Delete()
        {
            #region
            //if (SelectedProduct != null)
            //{

            //    if (RepositoryProvider.GetRepository<Product>().Find(SelectedProduct.Id) != null)
            //    {
            //        RepositoryProvider.GetRepository<Product>().Remove(SelectedProduct);

            //        RepositoryProvider.SaveChanges();
            //        ReloadProducts();
            //        ReloadProductCategoryes();
            //        ReloadShelves();
            //        ReloadTraders();
            //    }
            //}
#endregion

            ProductRedactionViewLogic.Delete(SelectedProduct.Id, SelectedProduct.ShelfId, SelectedProduct.TraderId, SelectedProduct.ProductCategoryId);
            //ProductRedactionViewLogic.ReloadProducts();
            OnPropertyChanged("Products");
        }


        public void ReloadProducts()
        {

            Products = ProductRedactionViewLogic.ReloadProducts();

        }
        public void ReloadProductCategoryes()
        {

            ProductCategoryes = ProductRedactionViewLogic.ReloadProductCategories();

        }
        public void ReloadShelves()
        {

            Shelves = ProductRedactionViewLogic.ReloadShelf();

        }
        public void ReloadTraders()
        {

            Traders = ProductRedactionViewLogic.ReloadTrader();

        }

        protected override void OnClosed()
        {
            base.OnClosed();
            ProductRedactionViewLogic.Dispose();
        }
    }

}




