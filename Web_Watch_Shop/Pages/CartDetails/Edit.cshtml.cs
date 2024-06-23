using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Web_Watch_Shop.Data;
using Web_Watch_Shop.Models;

namespace Web_Watch_Shop.Pages.CartDetails
{
    public class EditModel : PageModel
    {
        private readonly Web_Watch_Shop.Data.ApplicationDbContext _context;

        public EditModel(Web_Watch_Shop.Data.ApplicationDbContext context)
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

            var cart_detail =  await _context.Cart_Detail.FirstOrDefaultAsync(m => m.Cart_DetailID == id);
            if (cart_detail == null)
            {
                return NotFound();
            }
            Cart_Detail = cart_detail;
           ViewData["CartID"] = new SelectList(_context.Set<Cart>(), "CartID", "CartID");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Cart_Detail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Cart_DetailExists(Cart_Detail.Cart_DetailID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool Cart_DetailExists(int id)
        {
            return _context.Cart_Detail.Any(e => e.Cart_DetailID == id);
        }
    }
}
