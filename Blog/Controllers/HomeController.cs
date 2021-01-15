using Blog.Models;
using Blog.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBlogRepository blogRepository;

        public HomeController(IBlogRepository blogRepository)
        {
            this.blogRepository = blogRepository;
        }
        public IActionResult Index()
        {
            var model = blogRepository.GetAllBlogPosts().OrderByDescending(model => model.Id);
            return View(model);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(BlogPost blogPost)
        {
            if (ModelState.IsValid)
            {

                BlogPost newBlogPost = blogRepository.Add(blogPost);
                return RedirectToAction("ShowPost", new { id = blogPost.Id });
            }
            return View();
        }

        public IActionResult ShowPost(int? id)
        {
            var model = blogRepository.GetBlogPost(id.Value);
            if(model == null)
            {
                Response.StatusCode = 404;
                return View("PostNotFound", id.Value);
            }
            model.Comments = blogRepository.GetCommentsOfBlogPost(model);
            return View(model);
        }

        public IActionResult Edit(int id)
        {
            BlogPost blogPost = blogRepository.GetBlogPost(id);
            BlogPostEditViewmodel blogPostEditViewmodel = new BlogPostEditViewmodel
            {
                Id = blogPost.Id,
                Author = blogPost.Author,
                Content = blogPost.Content,
                Introduction = blogPost.Introduction,
                SubTitle = blogPost.SubTitle,
                Title = blogPost.Title
            };
            return View(blogPostEditViewmodel);
        }

        [HttpPost]
        public IActionResult Edit(BlogPostEditViewmodel model)
        {
            if (ModelState.IsValid)
            {
                BlogPost blogPost = blogRepository.GetBlogPost(model.Id);
                blogPost.Content = model.Content;
                blogPost.Author = model.Author;
                blogPost.Introduction = model.Introduction;
                blogPost.SubTitle = model.SubTitle;
                blogPost.Title = model.Title;
                blogRepository.Update(blogPost);
                return RedirectToAction("ShowPost", new { id = blogPost.Id });
            }
            return View();
        }
    }
}
