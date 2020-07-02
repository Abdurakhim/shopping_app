using Microsoft.AspNetCore.Mvc;
using Shopping_app.Data.Interfaces;
using Shopping_app.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping_app.Controllers
{
    public class HomeController : Controller
    {
        private IAllCars _carInterface;

        public HomeController (IAllCars carInterface)
        {
            _carInterface = carInterface;
        }

        public ViewResult Index()
        {
            var homeCars = new HomeViewModel
            {
                favCars = _carInterface.getFavCars
            };
            return View(homeCars);
        }
    }
}
