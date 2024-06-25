using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Web_Watch_Shop.Pages.SuccessCheckout
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
            TempData.Keep();
        }
    }
}
