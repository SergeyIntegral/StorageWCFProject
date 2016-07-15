using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Storage.Model;


namespace Storage.DataAccess
{
    public class Db : DbContext
    {
        public Db() : base("StorageDbLAB")
        {

           Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;

            
        }

        //public IDbSet<User> Users { get; set; }
       
        public IDbSet<Product> Products { get; set; }
        public  IDbSet<ProductCategory> ProductCategories { get; set; }
        //public IDbSet<ProductTraders> ProductTraderses { get; set; }
        public IDbSet<Shelf> Shelfes { get; set; }
        public IDbSet<Trader> Traders { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
             base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

        //    modelBuilder.Entity<Product>()
        //.HasMany(c => c.Traders)
        //.WithMany(p => p.Products)
        //.Map(m =>
        //{
            
        //    m.ToTable("ProductTrader");

            
        //    m.MapLeftKey("ProductId");
        //    m.MapRightKey("TraderId");
        //});


        }

        
    }
}

