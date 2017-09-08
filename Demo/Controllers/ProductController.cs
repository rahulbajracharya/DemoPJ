using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Threading.Tasks;
using Demo.IBII;
using Demo.Models;

namespace Demo.Controllers
{
   [RoutePrefix("api/Product")] 
  //product controller
  public class ProductController : ApiController
  {
    IProduct iproducts;
    public ProductController(IProduct _iproductdetails)
    {
      iproducts = _iproductdetails;
    }

    [Route("addProduct")]
    [HttpPost]
    public async Task<HttpResponseMessage> saveProductDetails(ProductDetailModel pod)
    {
      var message="";
      bool res = false;
      res = iproducts.SaveProducts(pod);
        if(res==true)
        {
         message ="Product Saved success";
         return Request.CreateResponse(HttpStatusCode.OK, message);
        }
        else
        {
          message = "Product not saved";
          return Request.CreateResponse(HttpStatusCode.BadRequest, message);
        }

    }
    [Route("showlist")]
    [HttpGet]
    public async Task<HttpResponseMessage> listProductdetails()
    {
      List<ProductDetailModel> productDetail = iproducts.showDetails();
      return Request.CreateResponse(HttpStatusCode.OK, productDetail);
    }

    public IEnumerable<string> Get()
    {
      return new string[] { "value1", "value2" };
    }
    [Route("showproductlist")]
    [HttpGet]
    public List<ProductDetailModel> listProducts()
    {
      List<ProductDetailModel> productDetail = iproducts.showDetails();
      return productDetail;
    }
    // GET api/<controller>/5
    public string Get(int id)
    {
      return "value";
    }

    // POST api/<controller>
    public void Post([FromBody]string value)
    {
    }

    // PUT api/<controller>/5
    public void Put(int id, [FromBody]string value)
    {
    }

    // DELETE api/<controller>/5
    public void Delete(int id)
    {
    }
  }
}