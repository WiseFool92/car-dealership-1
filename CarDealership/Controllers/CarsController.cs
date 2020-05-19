using CarDealership.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CarDealership.Controllers
{
  public class CarsController : Controller
  {

    // [HttpGet("/cars")]
    // public ActionResult Index()
    // {
    //   List<Cars> _carList = Cars.GetAll();
    //   return View(carList);
    // }

    // [HttpGet("/cars/new")]
    // public ActionResult CreateForm()
    // {
    //   return View();
    // }

    [HttpPost("/cars")]
    public ActionResult Create(string year, string makeModel, string color, string miles, string price)
    {
      Cars newCar = new Cars(year, makeModel, color, miles, price);
      return RedirectToAction("Index");
    }
    [HttpGet("/createForm")]
    public ActionResult CreateForm() 
    { 
      return View(); 
    }

    [HttpGet("/cars")]
    public ActionResult Index()
    {
      return View(Cars.CarList);
    }
  }
}