using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IssueTracker.Models
{
    public class IssuesDataContext : DbContext
    {
        public IssuesDataContext (DbContextOptions<IssuesDataContext> options): base(options)
        {

        }
        public virtual DbSet<Issue> Issues {get;set;}
    }
}
