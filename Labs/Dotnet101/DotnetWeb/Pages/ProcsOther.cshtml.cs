using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics;

namespace DotnetWeb.Pages;

public class ProcsOtherModel : PageModel
{
    public void OnGet()
    {
        Procs = Process.GetProcesses();
    }
}

