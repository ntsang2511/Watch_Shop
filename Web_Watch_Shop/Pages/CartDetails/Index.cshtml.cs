using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Web_Watch_Shop.Data;
using Web_Watch_Shop.Models;

namespace Web_Watch_Shop.Pages.CartDetails
{
    public class IndexModel : PageModel
    {
        private readonly Web_Watch_Shop.Data.ApplicationDbContext _context;

        public IndexModel(Web_Watch_Shop.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Cart_Detail> Cart_Detail { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Cart_Detail = await _context.Cart_Detail
                .Include(c => c.Cart).ToListAsync();
        }
    }
}
