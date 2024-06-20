using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Web_Watch_Shop.Models;

namespace Web_Watch_Shop.Data
{
    public class Watch_ShopContext : DbContext
    {
        public Watch_ShopContext (DbContextOptions<Watch_ShopContext> options)
            : base(options)
        {
        }

        public DbSet<Web_Watch_Shop.Models.Product> Product { get; set; } = default!;
    }
}
