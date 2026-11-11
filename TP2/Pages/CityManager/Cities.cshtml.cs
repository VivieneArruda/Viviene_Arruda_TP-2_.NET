// Exercício: 9
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TP2.Pages.CityManager;

public class CitiesModel : PageModel
{
    public List<string> Cities { get; set; } = ["Rio", "São Paulo", "Brasília"];

    public void OnGet()
    {
    }
}
