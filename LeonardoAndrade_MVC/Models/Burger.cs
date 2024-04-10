using System.ComponentModel.DataAnnotations;

namespace LeonardoAndrade_MVC.Models
{
    public class Burger
    {
       
        public int Id { get; set; }


        [Required]
        public string? Name { get; set; }
        public bool WithCheese { get; set; }
        [Range(0.01, 9999.99)]
        public decimal Costo { get; set; }
    }
}
