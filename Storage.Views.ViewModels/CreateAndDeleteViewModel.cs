using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mita.DataAccess;
using Mita.Mvvm;
using Storage.BusinessLogic;
using Storage.Model;

namespace Storage.Views.ViewModels
{
    [Export]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class CreateAndDeleteViewModel:ChildViewModel
    {
        //[Import]
        //private IRepositoryProvider RepositoryProvider { get; set; }
        [Import]
        private IProductCreateViewLogic ProductCreateViewLogic { get; set; }

        public ICollection<Product> _Products;

        public Product _Product = new Product();
        public Shelf _Shelf= new Shelf();
        public Trader _Trader = new Trader();
        public ProductCategory _ProductCategory = new ProductCategory();

        public CreateAndDeleteViewModel()
        {
            CreateMaterial = new DelegateCommand(() => Task.Run((Action)Add));
        }

        public DelegateCommand CreateMaterial { get; private set; }

        public Product Product
        {
            get { return _Product; }
            set
            {
                if (!Equals(value, _Product))
                {
                    _Product = value;
                    OnPropertyChanged();
                }
                //OnPropertyChanged("ProductCategory");
                //OnPropertyChanged("Trader");
                //OnPropertyChanged("Shelf");
                }
        }
        public ProductCategory ProductCategory
        {
            get
            {
                //if (_Product == null)
                //{
                //    _ProductCategory = Product.ProductCategory;
                //}
                return _ProductCategory;
            }
            set
            {
                if (!Equals(value, _ProductCategory))
                {
                    _ProductCategory = value;
                    OnPropertyChanged();
                }

              }
        }
        public Trader Trader
        {
            get
            {
                //if (_Product == null)
                //{
                //    _Trader = Product.Trader;
                //}
                return _Trader;
            }
            set
            {
                if (!Equals(value, _Trader))
                {
                    _Trader = value;
                    OnPropertyChanged();
                }

                }
        }

        public Shelf Shelf

        {
            get
            {
                //if (_Product == null)
                //{
                //    _Shelf = Product.Shelf;
                //}
                return _Shelf;
            }
            set
            {
                if (!Equals(value, _Shelf))
                {
                    _Shelf = value;
                    OnPropertyChanged();
                }

               
            }
        }


        public void Add()
        {

            var product = Product;
            var productCategory = ProductCategory;
            var shelf = Shelf;
            var trader = Trader;
            product.Shelf = shelf;
            product.ProductCategory = productCategory;
            product.Trader = trader;

            ProductCreateViewLogic.AddProduct(product,shelf,productCategory,trader);

           // RepositoryProvider.GetRepository<Product>().Add(product);

            
           // RepositoryProvider.GetRepository<Shelf>().Add(Shelf);
           //// int i = 0;
            
           // RepositoryProvider.GetRepository<ProductCategory>().Add(ProductCategory);
            
           // RepositoryProvider.GetRepository<Trader>().Add(Trader);

            
           // RepositoryProvider.SaveChanges();
        }

        protected override void OnClosed()
        {
            base.OnClosed();
            ProductCreateViewLogic.Dispose();
        }
    }
}
