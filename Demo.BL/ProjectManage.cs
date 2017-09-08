using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Data;
using Demo.Models;
using Demo.IBII;

namespace Demo.BL
{
  public class ProjectManage : IProduct
  {
    /// <summary>
    /// Comments
    /// </summary>
    /// <param name="product"></param>
    /// <returns></returns>
   public bool SaveProducts(ProductDetailModel product)
    {
      using (var db = new ProductContext())
      {
        ProductDetail po = new ProductDetail();
        po.ProductName = product.ProductName;
        po.ProductDetail1 = product.ProductDetail;
        po.ProductType = product.ProductType;
        po.Price = product.Price;
        if (db.SaveChanges() == 1)
        {
          return true;
        }
        else
        {
          return false;
        }
      }
    }
    //search specific product
   public List<ProductDetailModel> searchdetail(string id)
   {
     using (var db = new ProductContext())
     {
       List<ProductDetailModel> li = new List<ProductDetailModel>();
       var details = db.Product.Where(x => x.ProductType == id);
       if (details != null)
       {
         Parallel.ForEach(details, x =>
         {
           ProductDetailModel obj = new ProductDetailModel();
           obj.Sno = x.SnoId;
           obj.ProductName = x.ProductName;
           obj.Price = Convert.ToInt32(x.Price);
           li.Add(obj);

         });
         return li;
       }
       else
       {
         return li;
       }
     }
   }
    //show all details
   public List<ProductDetailModel> showDetails()
   {
     using (var db = new ProductContext())
     {
       List<ProductDetailModel> li = new List<ProductDetailModel>();
       var details = db.Product;
       if (details != null)
       {
         Parallel.ForEach(details, x =>
         {
           ProductDetailModel obj = new ProductDetailModel();
           obj.Sno = x.SnoId;
           obj.ProductName = x.ProductName;
           obj.Price = Convert.ToInt32(x.Price);
           li.Add(obj);
         });
         return li;
       }
       else
       {
         return li;
       }
     }
   }  
  
  }
}
