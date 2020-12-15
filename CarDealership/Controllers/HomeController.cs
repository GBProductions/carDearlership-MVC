using Microsoft.AspNetCore.Mvc;
using CarDealership.Models;
using System.Collections.Generic; 

namespace CarDealership.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
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
        public ActionResult Create(string model, int miles, int price)
        {
            Car newCar = new Car (model, miles, price);
            return RedirectToAction("Index");
        }
    }
}