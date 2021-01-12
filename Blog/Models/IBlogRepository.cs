using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models
{
    public interface IBlogRepository
    {
        BlogPost GetBlogPost(int id);
        IEnumerable<BlogPost> GetAllBlogPosts();
        BlogPost Add(BlogPost blogPost);
        BlogPost Delete(int id);
        BlogPost Update(BlogPost blogPost);

        Comment GetComment(int id);
        Comment AddComment(Comment comment);
        Comment DeleteComment(int id);
        Comment UpdateComment(Comment comment);

        IEnumerable<Comment> GetCommentsOfBlogPost(BlogPost blogPost);
    }
}
