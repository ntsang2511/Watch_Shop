using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics;

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
            var message = $"Name: {ContactForm.Name}\nEmail: {ContactForm.Email}\nMessage: {ContactForm.Message}";
            try
            {
                await _emailSender.SendEmailAsync("hauhm2323@gmail.com", subject, message);
            }
            catch (Exception ex)
            {
                string errorMessage = $"Lỗi gửi email: {ex.Message}\nStack Trace: {ex.StackTrace}";
                Debug.WriteLine(errorMessage);
                ModelState.AddModelError(string.Empty, "Không thể gửi email. Lỗi: " + ex.Message);
                return Page();
            }

            
            return Page();
        }
    }
    public class ContactFormModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
    }
}
