using System.Data.Entity;

namespace HW4.Models
{

    public class DB: DbContext
    {
        public DB(string name = "CurrencyDatabase") : base(name) { } // constructor

        public DbSet<CurrencyDTO> Currencies { get; set; } // Currency table in the database
    }
}