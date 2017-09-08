using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Demo.Models;
using Demo.IBII;

namespace Demo.Controllers
{
  public class HomeController : Controller
  {
    IProduct IProduct;

    public HomeController(IProduct _iproduct)
    {
      IProduct = _iproduct;
    }
    public ActionResult Index()
    {
      ViewBag.Title = "Home Page";
      List<ProductDetailModel> listOfProduct = IProduct.showDetails();
      ViewData["listofProduct"] = listOfProduct;//get list of products
      return View();
    }
    public ActionResult Search()
    {
      ViewBag.Title = "Search";
      return View();
    }
  }
}
