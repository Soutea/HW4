using System.Collections.Generic;

namespace HW4.Models
{
    public class DatabaseInitializer: System.Data.Entity.DropCreateDatabaseIfModelChanges<DB>
    {
        protected override void Seed(DB context)
        {
            var currencies = new List<CurrencyDTO>
            {
                new CurrencyDTO { Name = "USD", ValueInEuros = 1.1f },
                new CurrencyDTO { Name = "SEK", ValueInEuros = 10.0f }
            };
            currencies.ForEach(c => context.Currencies.Add(c));
            context.SaveChanges(); //permanent
            base.Seed(context);
        }
    }
}