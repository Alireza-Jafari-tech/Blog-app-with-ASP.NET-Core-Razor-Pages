using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using project.Data;
using project.Model;

namespace project.Pages
{
  public class ReadModel : PageModel
  {
    private readonly AppDbContext _context;

    public Post Post { get; set; }
    
    
    public ReadModel(AppDbContext context)
    {
      _context = context;
    }

    public IActionResult OnGet(int id)
    {
      Post = _context.Posts.Find(id);
      if (Post == null)
        return RedirectToPage("/NotFound");

      return Page();
    }
  }
}