using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace azure_app_trev.Pages;

public class IndexModel : PageModel
{
    private readonly IConfiguration _configuration;

    public IndexModel(IConfiguration configuration)
    {
        this._configuration = configuration;
    }
    public void OnGet()
    {
        ViewData["Greeting"] = _configuration["Greeting"];
    }
}
