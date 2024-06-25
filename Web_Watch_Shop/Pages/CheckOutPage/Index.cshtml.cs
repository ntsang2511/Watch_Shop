using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics;

namespace Web_Watch_Shop.Pages.CheckOutPage
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public string Name { get; set; }
        [BindProperty]
        public string Email { get; set; }
        [BindProperty]
        public string Address { get; set; }
        [BindProperty]
        public string Provice { get; set; }
        [BindProperty]
        public string ZipCode { get; set; }
        [BindProperty]
        public string Phone { get; set; }
        [BindProperty]
        public string Delivery { get; set; }

        public IActionResult OnPost()
        {
            //Debug.WriteLine($"Name: {Name}, Email: {Email}, Address: {Address}, Province: {Provice}, ZipCode: {ZipCode}, Phone: {Phone}, Delivery: {Delivery}");
            if (!string.IsNullOrWhiteSpace(Name) &&
                !string.IsNullOrWhiteSpace(Email) &&
                !string.IsNullOrWhiteSpace(Address) &&
                !string.IsNullOrWhiteSpace(Provice) &&
                !string.IsNullOrWhiteSpace(ZipCode) &&
                !string.IsNullOrWhiteSpace(Phone) &&
                !string.IsNullOrWhiteSpace(Delivery))
            {
                TempData["Name"] = Name;
                TempData["Email"] = Email;
                TempData["Address"] = Address;
                TempData["Provice"] = Provice;
                TempData["ZipCode"] = ZipCode;
                TempData["Phone"] = Phone;
                TempData["Delivery"] = Delivery;
                return RedirectToPage("/SuccessCheckout/Index");
            }
            return Page();
        }
    }
}
