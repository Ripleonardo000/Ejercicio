using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LeonardoAndrade_MVC.Models;

namespace LeonardoAndrade_MVC.Data
{
    public class LeonardoAndrade_MVCContext : DbContext
    {
        public LeonardoAndrade_MVCContext (DbContextOptions<LeonardoAndrade_MVCContext> options)
            : base(options)
        {
        }

        public DbSet<LeonardoAndrade_MVC.Models.Burger> Burger { get; set; } = default!;
        public DbSet<LeonardoAndrade_MVC.Models.Promo> Promo { get; set; } = default!;
    }
}
