using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Web_Watch_Shop.Pages.CartPage
{
    public class IndexModel : PageModel
    {
        public void OnGet(string Image, string Price)
        {
            ViewData["Image"] = Image;
            ViewData["Price"] = Price;
        }
    }
}

