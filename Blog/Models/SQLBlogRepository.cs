using Microsoft.EntityFrameworkCore;
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
            appDbContext.BlogPosts.Add(blogPost);
            appDbContext.SaveChanges();
            return blogPost;
        }

        public Comment AddComment(Comment comment)
        {
            appDbContext.Comments.Add(comment);
            appDbContext.SaveChanges();
            return comment;
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

            return appDbContext.BlogPosts.Include("Comments");
        }

        public BlogPost GetBlogPost(int Id)
        {
            return appDbContext.BlogPosts.Find(Id);
        }

        public Comment GetComment(int id)
        {
            throw new NotImplementedException();
        }

        public ICollection<Comment> GetCommentsOfBlogPost(BlogPost blogPost)
        {
            return appDbContext.Comments.Where(comment => comment.BlogPostId == blogPost.Id).ToList();
        }

        public BlogPost Update(BlogPost blogPost)
        {
            var blogPostDb = appDbContext.BlogPosts.Attach(blogPost);
            blogPostDb.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            appDbContext.SaveChanges();
            return blogPost;
        }

        public Comment UpdateComment(Comment comment)
        {
            throw new NotImplementedException();
        }
    }
}
