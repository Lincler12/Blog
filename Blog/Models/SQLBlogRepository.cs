using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models
{
    public class SQLBlogRepository : IBlogRepository
    {


        public BlogPost Add(BlogPost blogPost)
        {
            throw new NotImplementedException();
        }

        public Comment AddComment(Comment comment)
        {
            throw new NotImplementedException();
        }

        public BlogPost Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Comment DeleteComment(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BlogPost> GetAllBlogPosts()
        {
            throw new NotImplementedException();
        }

        public BlogPost GetBlogPost(int id)
        {
            throw new NotImplementedException();
        }

        public Comment GetComment(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Comment> GetCommentsOfBlogPost(BlogPost blogPost)
        {
            throw new NotImplementedException();
        }

        public BlogPost Update(BlogPost blogPost)
        {
            throw new NotImplementedException();
        }

        public Comment UpdateComment(Comment comment)
        {
            throw new NotImplementedException();
        }
    }
}
