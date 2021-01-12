using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models
{
    public class SQLBlogRepository : IBlogRepository
    {
        private readonly AppDbContext appDbContext;

        public SQLBlogRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
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
            return appDbContext.BlogPosts;
        }

        public BlogPost GetBlogPost(int Id)
        {
            return appDbContext.BlogPosts.Find(Id);
        }

        public Comment GetComment(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Comment> GetCommentsOfBlogPost(BlogPost blogPost)
        {
            return appDbContext.Comments.Where(comment => comment.BlogPostId == blogPost.Id);
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
