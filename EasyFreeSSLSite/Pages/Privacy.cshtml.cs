using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EasyFreeSSLSite.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;

        public PrivacyModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            ViewData["CurrentUrl"] = Request.GetCurrentUrl();
        }
    }
}