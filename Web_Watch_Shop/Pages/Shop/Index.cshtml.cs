using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Web_Watch_Shop.Models;
namespace Web_Watch_Shop.Pages.Shop
{
    public class IndexModel : PageModel
    {
        private readonly Web_Watch_Shop.Data.ApplicationDbContext _context;

        public IndexModel(Web_Watch_Shop.Data.ApplicationDbContext context)
        {
            _context = context;
        }
        public IList<Product_Detail> Product_Detail { get; set; } = default!;

        public async Task OnGetAsync()
        {
            Product_Detail = await _context.Product_Detail.ToListAsync();
        }
    }
}
