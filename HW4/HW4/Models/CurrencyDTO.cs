using System.ComponentModel.DataAnnotations;

namespace HW4.Models
{
    public class CurrencyDTO
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public float ValueInEuros { get; set; }
    }
    
}



