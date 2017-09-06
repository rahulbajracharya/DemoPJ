using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Models;

namespace Demo.IBII
{
 public interface IProduct
  {
   bool SaveProducts(ProductDetailModel product);
   List<ProductDetailModel> searchdetail(string id);
   List<ProductDetailModel> showDetails();
  }
}
