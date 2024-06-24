    using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Web_Watch_Shop.Data;
using Web_Watch_Shop.Models;

namespace Web_Watch_Shop.Pages.Product_Details
{
    [Authorize(Roles = "admin")]
    public class IndexModel : PageModel
    {

        private readonly Web_Watch_Shop.Data.ApplicationDbContext _context;

        public IndexModel(Web_Watch_Shop.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Product_Detail> Product_Detail { get;set; } = default!;

        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }

        public SelectList? Categories { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? ProductCategory { get; set; }
        public async Task OnGetAsync()
        {
            //Product_Detail = await _context.Product_Detail.ToListAsync();
            IQueryable<string> categoryQuery = from m in _context.Product_Detail
                                            orderby m.CategoryName
                                            select m.CategoryName;

            var products = from m in _context.Product_Detail
                         select m;

            if (!string.IsNullOrEmpty(SearchString))
            {
                products = products.Where(s => s.ProductName.Contains(SearchString));
            }

            if (!string.IsNullOrEmpty(ProductCategory))
            {
                products = products.Where(x => x.CategoryName == ProductCategory);
            }
            Categories = new SelectList(await categoryQuery.Distinct().ToListAsync());
            Product_Detail = await products.ToListAsync();
        }
    }
}
