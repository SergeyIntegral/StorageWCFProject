using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Storage.Model;

namespace Storage.BusinessLogic
{
    public interface IProductCreateViewLogic: IBusinessLogic
    {
        void AddProduct(Product product, Shelf shelf, ProductCategory productCategory, Trader trader);
    }
}
