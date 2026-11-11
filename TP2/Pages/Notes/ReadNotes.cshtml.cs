// Exercício: 11
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TP2.Pages.Notes;

public class ReadNotesModel : PageModel
{
    private readonly IWebHostEnvironment _env;

    public ReadNotesModel(IWebHostEnvironment env)
    {
        _env = env;
    }

    public List<string> Files { get; set; } = new();

    public string? SelectedFile { get; set; }

    public string? FileContent { get; set; }

    public void OnGet(string? file)
    {
        var folder = Path.Combine(_env.WebRootPath, "files");

        if (Directory.Exists(folder))
        {
            foreach (var path in Directory.GetFiles(folder, "*.txt"))
            {
                Files.Add(Path.GetFileName(path));
            }
        }

        if (!string.IsNullOrEmpty(file))
        {
            var name = Path.GetFileName(file);
            var fullPath = Path.Combine(folder, name);

            if (System.IO.File.Exists(fullPath))
            {
                SelectedFile = name;
                FileContent = System.IO.File.ReadAllText(fullPath);
            }
        }
    }
}
