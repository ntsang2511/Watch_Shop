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
    public class DeleteModel : PageModel
    {
        private readonly Web_Watch_Shop.Data.ApplicationDbContext _context;

        public DeleteModel(Web_Watch_Shop.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Cart_Detail Cart_Detail { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cart_detail = await _context.Cart_Detail.FirstOrDefaultAsync(m => m.Cart_DetailID == id);

            if (cart_detail == null)
            {
                return NotFound();
            }
            else
            {
                Cart_Detail = cart_detail;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cart_detail = await _context.Cart_Detail.FindAsync(id);
            if (cart_detail != null)
            {
                Cart_Detail = cart_detail;
                _context.Cart_Detail.Remove(Cart_Detail);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
