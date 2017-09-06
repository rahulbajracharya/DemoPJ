using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Demo.Data
{
 public class ProductDetail
  {
   public ProductDetail()
   { 
   }
   public int SnoId { get; set; }
   public string ProductName { get; set; }
   public string ProductDetail1 { get; set; }
   public decimal Price { get; set; }
   public string ProductType { get; set; }
  }
}
