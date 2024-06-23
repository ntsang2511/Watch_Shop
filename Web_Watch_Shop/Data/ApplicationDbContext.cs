using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Web_Watch_Shop.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Web_Watch_Shop.Models.Product_Detail> Product_Detail { get; set; } = default!;
        public DbSet<Web_Watch_Shop.Models.Cart_Detail> Cart_Detail { get; set; } = default!;

    }
}
