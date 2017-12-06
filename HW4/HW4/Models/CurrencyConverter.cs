using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HW4.Models
{
    public static class CurrencyConverter
    {
        /** converting our first currency to euro, to then convert it to our new currency**/
        public static float Convert(CurrencyDTO currency1, CurrencyDTO currency2, float amount)
        { 
            return amount / currency1.ValueInEuros * currency2.ValueInEuros; 
        }
    }
}