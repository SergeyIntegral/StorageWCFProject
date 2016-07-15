using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Mita.DataAccess;


namespace Storage.Model
{
    //[DataContract(IsReference = true)]
    public class Product : TitledDomainObject
    {
        //ProductName - наименование товара
       // [DataMember]

        public string ProductNumber { get; set; }//номенклатурный номер
        //[DataMember]
        public decimal Price { get; set; }
        //[DataMember]
        public int ProductCategoryId { get; set; }
        //[DataMember]
        public virtual ProductCategory ProductCategory { get; set; }
        //[DataMember]
        public double Input { get; set; }
        //[DataMember]
        public DateTime InputDate { get; set; }
        //[DataMember]
        public double Count
        {
            get { return (Input - Sold); }
            set { }
        }
        //[DataMember]
        public DateTime CountDate { get; set; }
        //[DataMember]
        public double Sold { get; set; }
        //[DataMember]
        public DateTime SoldDate { get; set; }
        //[DataMember]
        public int ShelfId { get; set; }
        //[DataMember]
        public virtual Shelf Shelf { get; set; }
        //[DataMember]
        public int TraderId { get; set; }
        //[DataMember]
        public virtual Trader Trader { get; set; }

        //public ICollection<ProductTraders> ProductTraderses { get; set; }



    }
}
