using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IssueTracker.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace IssueTracker.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IssuesDataContext _context;

        public IndexModel(ILogger<IndexModel> logger, IssuesDataContext context)
        {
            _logger = logger;
            _context = context;
        }
        public string Caption { get; set; } = "Your OpenIssues";
        public IList<Issue> Issues { get; set; }
        public async Task OnGet()
        {
            Issues = await _context.Issues.
                Where(issue=> issue.Closed == false)
                .ToListAsync();
            _logger.LogInformation("They hit the page! We have a visitor!");

        }
    }
}
