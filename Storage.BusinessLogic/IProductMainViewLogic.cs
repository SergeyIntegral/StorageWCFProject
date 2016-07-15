using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Storage.Model;

namespace Storage.BusinessLogic
{
    public interface IProductMainViewLogic:IBusinessLogic
    {
        List<Product> SearchProducts(string productName = null, string productNumber = null);

        List<Product> ShowAllProducts();
    }
}
