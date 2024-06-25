using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Web_Watch_Shop.Pages.Cantactus
{
    public class IndexModel : PageModel
    {
        private readonly IEmailSender _emailSender;

        public IndexModel(IEmailSender emailSender)
        {
            _emailSender = emailSender;
        }

        [BindProperty]
        public ContactFormModel ContactForm { get; set; }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var subject = "New Contact Form Submission";
            var message = $"Name: {ContactForm.Name}\nMessage: {ContactForm.Message}";

            await _emailSender.SendEmailAsync("hauhm2323@gmail.com", subject, message);

            return RedirectToPage("Success");
        }
    }
    public class ContactFormModel
    {
        public string Name { get; set; }
        public string Message { get; set; }
    }
}
