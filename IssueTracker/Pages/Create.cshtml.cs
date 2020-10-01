using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IssueTracker.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace IssueTracker.Pages
{
    public class CreateModel : PageModel
    {
        private readonly IssuesDataContext _context;

        public CreateModel(IssuesDataContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Issue Issue { get; set; }
        public void OnGet()
        {
        }

        public async Task<ActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                _context.Issues.Add(Issue);
                await _context.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
        }
    }
}
