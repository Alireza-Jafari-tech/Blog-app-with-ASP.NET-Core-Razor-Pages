using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using project.Data;
using project.Model;

namespace project.Pages;

public class DeleteModel : PageModel
{
  private readonly AppDbContext _context;
  
  [BindProperty]
  public Post Post { get; set; }
  [BindProperty]
  public int PostID { get; set; }
  
  
  
  public DeleteModel(AppDbContext context)
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

  public IActionResult OnPost()
  {
    if (!ModelState.IsValid)
      return Page();

    var post = _context.Posts.Find(Post.Id);

    if (post == null)
            return RedirectToPage("/NotFound");

    _context.Posts.Remove(post);
    _context.SaveChanges();

    return RedirectToPage("Index");
  }
}