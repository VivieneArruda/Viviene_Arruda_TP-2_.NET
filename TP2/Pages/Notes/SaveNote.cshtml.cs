// Exercício: 10
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TP2.Pages.Notes;

public class SaveNoteModel : PageModel
{
    private readonly IWebHostEnvironment _env;

    public SaveNoteModel(IWebHostEnvironment env)
    {
        _env = env;
    }

    [BindProperty]
    public InputModel Input { get; set; } = new();

    public string? FileName { get; set; }

    public class InputModel
    {
        [Required(ErrorMessage = "Escreva alguma coisa antes de salvar.")]
        [Display(Name = "Texto da nota")]
        public string Content { get; set; } = "";
    }

    public void OnGet()
    {
    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        var folder = Path.Combine(_env.WebRootPath, "files");
        Directory.CreateDirectory(folder);

        FileName = $"note-{DateTime.Now:yyyyMMddHHmmss}.txt";
        System.IO.File.WriteAllText(Path.Combine(folder, FileName), Input.Content);

        return Page();
    }
}
