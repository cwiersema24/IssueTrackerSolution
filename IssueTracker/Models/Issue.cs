using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IssueTracker.Models
{
    public class Issue
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Tell us what is wrong")]
        [MaxLength(200)]
        public string Description { get; set; }
        [MaxLength(100000)]
        [DisplayName("Long Description")]
        public string Narrative { get; set; }
        [Required]
        [DisplayName("Created By")]
        public string AddedBy { get; set; }
        [Required]
        public string Status { get; set; }
        public bool Closed { get; set; }
    }
}
