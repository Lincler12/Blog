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
            var model = blogRepository.GetAllBlogPosts();
            
            return View(model);
        }

        public IActionResult ShowPost(int? id)
        {
            var model = blogRepository.GetBlogPost(id??1);
            model.Comments = blogRepository.GetCommentsOfBlogPost(model).ToList();
            return View(model);
        }
    }
}
