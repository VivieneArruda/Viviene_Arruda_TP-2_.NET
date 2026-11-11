// Exercício: 2
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TP2.Pages.CityManager;

public class CreateCityHandlerModel : PageModel
{
    public string? Message { get; set; }

    public void OnGet()
    {
    }

    public void OnPost(string cityName)
    {
        Message = $"Cidade recebida pelo handler: {cityName}";
    }
}
