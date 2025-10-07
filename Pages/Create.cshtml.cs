using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;
using project.Data;
using project.Model;

namespace project.Pages
{
  public class CreateModel : PageModel
  {
    private readonly AppDbContext _context;
    public CreateModel(AppDbContext context)
    {
      _context = context;
    }

    [BindProperty]
    public Post Post { get; set; }

    public void OnGet()
    {

    }

    public IActionResult OnPost()
    {
      if (!ModelState.IsValid)
      {
        return Page();
      }

      Post.Slug = SlugHelper.GenerateSlug(Post.Slug);
      Post.IsPolished = true;

      _context.Posts.Add(Post);
      _context.SaveChanges();

      return RedirectToPage("Index");
    }

    public static class SlugHelper
    {
      public static string GenerateSlug(string title)
      {
        // Lowercase
        string slug = title.ToLowerInvariant();

        // Replace spaces with hyphens
        slug = Regex.Replace(slug, @"\s+", "-");

        // Remove invalid chars
        slug = Regex.Replace(slug, @"[^a-z0-9\-]", "");

        // Remove multiple hyphens
        slug = Regex.Replace(slug, @"-+", "-");

        // Trim hyphens
        slug = slug.Trim('-');

        return slug;
      }
    }
  }
}