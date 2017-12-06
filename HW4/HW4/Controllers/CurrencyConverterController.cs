using HW4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HW4.Controllers
{

    public class CurrencyConverterController : ApiController
    {
        [HttpGet]
        [Route("currency/list")]
        public HttpResponseMessage ListCurrencies()
        {
            var database = new Models.DB(); //connecting to the database
        
            return Request.CreateResponse(HttpStatusCode.OK, database.Currencies.ToList()); // return the list of currencies
        }

        [HttpGet]
        [Route("currency/convert/{currency1}/{currency2}/{amount}")]
        public HttpResponseMessage ConvertCurrency(string currency1, string currency2, float amount )
        {
            var database = new Models.DB();
            /*
             *CurrencyDTO c1;
            foreach(var c in database.Currencies)
            {
                if (c.Name == currency1)
                {
                    c1 = c;
                    break;
                }
            }
            */
            var c1 = database.Currencies.First(c => c.Name == currency1);
            var c2 = database.Currencies.First(c => c.Name == currency2);

            return Request.CreateResponse(HttpStatusCode.OK, CurrencyConverter.Convert(c1, c2, amount));
        }
    }
}
