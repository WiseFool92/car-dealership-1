using CarDealership.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CarDealership.Controllers
{
  public class CarsController : Controller
  {

    [HttpGet("/cars")]
    public ActionResult Index()
    {
      List<Car> allCars = Car.GetAll();
      return View(allCars);
    }

    [HttpGet("/cars/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/cars")]
    public ActionResult Create(int year, string make, string model, string color, int miles, int price)
    {
      Car myCar = new Car(year, make, model, color, miles, price);
      return RedirectToAction("Index");
    }
  }
}