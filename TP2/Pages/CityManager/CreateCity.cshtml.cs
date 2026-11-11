// Exercício: 1
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TP2.Pages.CityManager;

public class CreateCityModel : PageModel
{
    [BindProperty]
    public string CityName { get; set; } = "";

    public void OnGet()
    {
    }

    public void OnPost()
    {
    }
}
