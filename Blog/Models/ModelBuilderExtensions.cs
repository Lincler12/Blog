using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BlogPost>().HasData(
                new BlogPost
                {
                    Id = 1,
                    Author = "Nikolaos Kalogeropoulos",
                    Title = "To be or not to be",
                    SubTitle = "An ode to a very strange existance",
                    Introduction = "The feeling of being lonely is something many people have experienced, in this blog post I will explain how you can fight this feeling of loneliness",
                    Content = "To fight this feeling you have to be very brave with yourself and others and and and nad To fight this feeling you have to be very brave with yourself and others and and and nad To fight this feeling you have to be very brave with yourself and others and and and nad To fight this feeling you have to be very brave with yourself and others and and and nad To fight this feeling you have to be very brave with yourself and others and and and nad",
                },
                new BlogPost
                {
                    Id = 2,
                    Author = "John Wick",
                    Title = "To kill or not to kill",
                    SubTitle = "An ode to a very strange killing",
                    Introduction = "The feeling of killing  is something many people have experienced, in this blog post I will explain how you can fight this feeling of killing",
                    Content = "To fight this feeling you have to be very brave with yourself and others and and and nad To fight this feeling you have to be very brave with yourself and others and and and nad To fight this feeling you have to be very brave with yourself and others and and and nad To fight this feeling you have to be very brave with yourself and others and and and nad To fight this feeling you have to be very brave with yourself and others and and and nad",
                }

            );
        }
    }
}
