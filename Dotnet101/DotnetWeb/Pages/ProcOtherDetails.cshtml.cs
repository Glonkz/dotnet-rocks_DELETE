using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics;

namespace DotnetWeb.Pages;

public class ProcOtherDetailsModel : PageModel
{
    // Ensure this property exists and is public
    public Process? Proc { get; set; }

    public void OnGet(int id)
    {
        // Retrieve the process by id (or whatever your lab logic uses)
        try
        {
            Proc = Process.GetProcessById(id);
        }
        catch
        {
            Proc = null;
        }
    }
}