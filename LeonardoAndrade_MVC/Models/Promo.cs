using System.ComponentModel.DataAnnotations;

namespace LeonardoAndrade_MVC.Models
{
    public class Promo
    {
        [Key]
        public int PromoID { get; set; }

        public string? Descripcion { get; set; }
        public int FechaPromo { get; set; }

        public int BurgerID { get; set; }
        public Burger? burger { get; set; }

    }
}
