using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mita.DataAccess;

namespace Storage.BusinessLogic.DB
{
    public class BusinessLogicBase:IBusinessLogic
    {
        [Import]
        protected IRepositoryProvider RepositoryProvider { get; private set; }

        public void Dispose()
        {
            if (RepositoryProvider != null)
            {
                RepositoryProvider.Dispose();
                RepositoryProvider = null;
            }
        }
    }
}
