using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models
{
    public class BlogPost
    {

        public int Id { get; set; }
        [Required]
        public string Author { get; set; }
        [MaxLength(1000, ErrorMessage = "Title should be below 1000 characters") ]
        [Required]
        public string Title { get; set; }
        [MaxLength(2000, ErrorMessage = "Subtitle should below 2000 characters")]
        [Required]
        public string SubTitle { get; set; }
        [Required]
        public string Introduction { get; set; }
        [MinLength(2000, ErrorMessage = "Not enough content")]
        [Required]
        public string Content { get; set; }
        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
        public int Likes { get; set; } = 0;

    }
}
