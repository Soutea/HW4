using System.Collections.Generic;

namespace HW4.Models
{
    public class DatabaseInitializer: System.Data.Entity.DropCreateDatabaseIfModelChanges<DB>
    {
        protected override void Seed(DB context)
        {
            var currencies = new List<CurrencyDTO>
            {
                new CurrencyDTO { Name = "USD", ValueInEuros = 1.1787f },
                new CurrencyDTO { Name = "SEK", ValueInEuros = 9.9372f },
                new CurrencyDTO { Name = "EUR", ValueInEuros = 1},
                new CurrencyDTO { Name = "HUF", ValueInEuros = 314.336f},
                new CurrencyDTO { Name = "GPD", ValueInEuros = 0.8808f}
            };
            currencies.ForEach(c => context.Currencies.Add(c));
            context.SaveChanges(); //permanent
            base.Seed(context);
        }
    }
}