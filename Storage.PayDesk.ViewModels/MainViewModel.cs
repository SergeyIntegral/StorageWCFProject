using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Composition;
using Mita.Core;
using Mita.DataAccess;
using Mita.Mvvm;

namespace Storage.PayDesk.ViewModels
{
    [Export]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class MainViewModel : ChildViewModel
    {
        public MainViewModel()
        {
            
        }
    }
}
