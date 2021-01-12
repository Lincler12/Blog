using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Author { get; set; } = "Anonymous";
        [Required]
        public string CommentMessage { get; set; }
        [Required]
        public int BlogPostId { get; set; }
        public BlogPost BlogPost { get; set; }
    }
}
