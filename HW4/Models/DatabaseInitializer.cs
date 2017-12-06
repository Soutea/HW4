using System.Collections.Generic;

namespace HW4.Models
{
    public class DatabaseInitializer: System.Data.Entity.DropCreateDatabaseIfModelChanges<DB>
    {
        protected override void Seed(DB context)
        {
            var currencies = new List<CurrencyDTO>
            {
                new CurrencyDTO { Name = "USD", ValueInEuros = 1.1787f, Description = "US dollar" },
                new CurrencyDTO { Name = "SEK", ValueInEuros = 9.9372f, Description = "Swedish kronor" },
                new CurrencyDTO { Name = "EUR", ValueInEuros = 1, Description= "Euro"},
                new CurrencyDTO { Name = "HUF", ValueInEuros = 314.336f, Description = "Hungarian forint"},
                new CurrencyDTO { Name = "GPD", ValueInEuros = 0.8808f, Description = "British pound"}
            };
            currencies.ForEach(c => context.Currencies.Add(c));
            context.SaveChanges(); //permanent
            base.Seed(context);
        }
    }
}