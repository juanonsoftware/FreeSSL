using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EasyFreeSSLSite.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IWebHostEnvironment _host;

        public IndexModel(ILogger<IndexModel> logger, IWebHostEnvironment host)
        {
            _logger = logger;
            _host = host;
        }

        public void OnGet()
        {
            ViewData["IndexContent"] = _host.ReadAppDataFile("IndexContent.html");
        }
    }
}