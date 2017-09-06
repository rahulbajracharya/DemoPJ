using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;

namespace Demo.Data
{
  public class ProductContext:DbContext
  {
    public ProductContext(): base("name=ProductDBConnectionString")
    { 
    
    }
    public DbSet<ProductDetail> Product { get; set; }
    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
      //Configure primary key
      modelBuilder.Entity<ProductDetail>().HasKey<int>(s => s.SnoId);
      base.OnModelCreating(modelBuilder);
    }
   
  }
}
