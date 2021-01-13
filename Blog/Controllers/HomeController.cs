using Blog.Models;
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
            var model = blogRepository.GetBlogPost(id??1);
            model.Comments = blogRepository.GetCommentsOfBlogPost(model);
            return View(model);
        }
    }
}
