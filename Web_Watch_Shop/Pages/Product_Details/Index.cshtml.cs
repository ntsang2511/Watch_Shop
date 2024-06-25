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
using Microsoft.Extensions.Configuration;

namespace Web_Watch_Shop.Pages.Product_Details
{
    //[Authorize(Roles = "admin")]
    public class IndexModel : PageModel
    {

        private readonly ApplicationDbContext _context;
        private readonly IConfiguration Configuration;

        public IndexModel(ApplicationDbContext context, IConfiguration configuration)
        {
            _context = context;
            Configuration = configuration;
        }
        public string NameSort { get; set; }
        public string CategorySort { get; set; }
        public string CurrentSort { get; set; }
        public string CurrentFilter { get; set; }
        public PaginatedList<Product_Detail> Product_Detailss { get; set; }
        public IList<Product_Detail> Product_Detail { get;set; } = default!;

        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }

        public SelectList? Categories { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? ProductCategory { get; set; }
        public async Task OnGetAsync(string sortOrder,
           string currentFilter, string searchString, int? pageIndex)
        {
            CurrentSort = sortOrder;
            NameSort = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            CategorySort = String.IsNullOrEmpty(sortOrder) ? "category_desc" : "";
            if (searchString != null)
            {
                pageIndex = 1;
            }
            else
            {
                searchString = currentFilter;
            }
            CurrentFilter = searchString;
            IQueryable<Product_Detail> Product_DetailIQ = from s in _context.Product_Detail
                                                          select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                Product_DetailIQ = Product_DetailIQ.Where(s => s.ProductName.Contains(searchString)
                                       || s.CategoryName.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "name_desc":
                    Product_DetailIQ = Product_DetailIQ.OrderByDescending(s => s.ProductName);
                    break;
                case "category_desc":
                    Product_DetailIQ = Product_DetailIQ.OrderByDescending(s => s.CategoryName);
                    break;
                default:
                    Product_DetailIQ = Product_DetailIQ.OrderBy(s => s.ProductName);
                    break;
            }

            var pageSize = Configuration.GetValue("PageSize", 4);
			//Product_Detailss = await PaginatedList<Product_Detail>.CreateAsync(
			//    Product_DetailIQ.AsNoTracking(), pageIndex ?? 1, pageSize);
			//CurrentSort = sortOrder;
			//NameSort = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
			//if (searchString != null)
			//{
			//    pageIndex = 1;
			//}
			//else
			//{
			//    searchString = currentFilter;
			//}
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
