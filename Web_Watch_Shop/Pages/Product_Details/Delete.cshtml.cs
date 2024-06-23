using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Web_Watch_Shop.Data;
using Web_Watch_Shop.Models;

namespace Web_Watch_Shop.Pages.Product_Details
{
    public class DeleteModel : PageModel
    {
        private readonly Web_Watch_Shop.Data.ApplicationDbContext _context;

        public DeleteModel(Web_Watch_Shop.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Product_Detail Product_Detail { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product_detail = await _context.Product_Detail.FirstOrDefaultAsync(m => m.Product_DetailID == id);

            if (product_detail == null)
            {
                return NotFound();
            }
            else
            {
                Product_Detail = product_detail;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product_detail = await _context.Product_Detail.FindAsync(id);
            if (product_detail != null)
            {
                Product_Detail = product_detail;
                _context.Product_Detail.Remove(Product_Detail);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
