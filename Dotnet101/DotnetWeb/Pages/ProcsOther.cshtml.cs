using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics;

namespace DotnetWeb.Pages;

public class ProcsOtherModel : PageModel
{
    // Define the public collection property
    public Process[] Procs { get; set; } = Array.Empty<Process>();

    public void OnGet()
    {
        // Populate the property
        Procs = Process.GetProcesses();
    }
}