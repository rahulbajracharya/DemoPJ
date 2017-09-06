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
    //Home
    public ActionResult Index()
    {
      ViewBag.Title = "Home Page";
      List<ProductDetailModel> listOfProduct = IProduct.showDetails();
      ViewData["listofProduct"] = listOfProduct;

      return View();
    }
    //Add new item
    /// <summary>
    /// laksjdlkasjdlkajsdlkajsdl
    /// </summary>
    /// <returns></returns>
    public ActionResult Add()
    {
      ViewBag.Title = "Add new Product";
      return View();
    }
  }
}
