﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Mita.DataAccess;

namespace Storage.Model
{
    //[DataContract(IsReference = true)]
    public class ProductCategory : NamedDomainObject
    {
        //[DataMember]
        public string ProductCategoryName { get; set; }
    }
}