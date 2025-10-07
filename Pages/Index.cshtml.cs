using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using project.Data;
using project.Model;

namespace project.Pages;

public class IndexModel : PageModel
{
    private readonly AppDbContext _context;
    public IndexModel(AppDbContext context)
    {
        _context = context;
    }

    public List<Post> Posts { get; set; }
    
    
    public void OnGet()
    {
        Posts = _context.Posts.ToList();
    }
}
