using HW4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HW4.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            /** var numbers = new List<int> { 1, 2, 3, 4, 10, 5 };
            var idk = numbers.First(number => number > 4); **/


            var db = new DB();
            var currency1 = db.Currencies.First(c => c.Id == 1); // taking the first currency
            var currency2 = db.Currencies.First(c => c.Id == 2); // taking the second currency
            CurrencyConverter.Convert(currency1, currency2, 100);

            return View();
        }

        public ActionResult Currencies()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}
