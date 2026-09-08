using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics;

namespace DotnetWeb.Pages;

public class ProcOtherDetailsModel : PageModel
{
    public void OnGet(int id)
    {
        Proc = Process.GetProcessById(id);
        
    }
}

