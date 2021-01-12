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
                },
                new BlogPost
                {
                    Id = 3,
                    Author = "Eva V.",
                    Title = "7 Books That Will Help You Stand Out As A Junior UX/UI Designer",
                    SubTitle = "Designing a new product is all about making a series of decisions.",
                    Introduction = "There have been several books that helped my career and made me look smarter. I wanted to share them in this article. Hoping that they can lead to a positive change in your career too. \n\n(Note that there are NO affiliate links.You should google the titles if you want to purchase)",
                    Content = @"“UX Design involves a process very similar to doing science: you do research to understand the users, you develop ideas to solve users’ need — and the needs of the business — and you build and measure those solutions in the real world to see if they work.”
So the rubber duck on the title indicates it’s an easy and fun to read type. But at the same time, there are many pro tips with practical examples covering 2–3 pages with illustrations and large prints.
The author talks about the psychology of the user experience and how to analyze it. And provides some test ideas and methods.
This book is definitely a great introduction to prepare you for the next level. Because of the good humor and clear explanations, you’ll realize why it’s a good read.
#2 Don’t Make Me Think (2014)
by Steve Krug
Image for post
Don’t Make Me Think
“First Law: Don’t make me think. Second Law: It doesn’t matter how many times I have to click, as long as each click is a mindless, unambiguous choice. Third Law: Get rid of half the words on each page, then get rid of half of what’s left.”
You know this book. You have seen it. Everyone recommends it. Now is the perfect time to finally sit down and read this short classic.
The book talks about making things obvious and self-evident because people scan. They don’t read. So you have to make choices mindless for ease of use.
Also, people think users hate making lots of clicks to find their way. Steve says that’s not the case. Users generally want to find the right buttons. And they want to be able to retrace their steps if they accidentally go down the wrong path.
#3 The Moderator’s Survival Guide: Handling Common, Tricky, and Sticky Situations in User Research (2014)
by Donna Tedesco
Image for post
The Moderator’s Survival Guide: Handling Common, Tricky, and Sticky Situations in User Research
“One of the most important principles in moderating is to let the participant do most of the talking, but when you do speak — whether it’s to provide direction, probe for more detail, or give neutral reassurance — you need to choose your words, and your tone, carefully.”
If you do any usability testing, you should definitely check out this one. The authors said that they had written this book for both beginners and expert user researchers. They’ve exceeded their goal.
It starts with an introduction to a wide variety of situations that you might face. Then, it gives you practical advice on how to deal with specific problems during user research. The example stories may range from drunk participants to earthquakes.
At the very end, the authors bring everything together into useful checklists. I think these checklists are absolute. I intend to make use of them to identify my steps and react appropriately. Hoping that I can survive any challenge that comes the way.
#4 Making and Breaking the Grid (2017)
by Timothy Samara
Image for post
Making and Breaking the Grid
“The grid system is an aid, not a guarantee. It permits a number of possible uses and each designer can look for a solution that is appropriate to his or her personal style. But one must learn how to use the grid; it is an art that requires practice.”
This book is divided into 2 parts. The first part is about the creation of grid-based designs and their usages. And the second part explains the deconstruction of the grid, a different approach to design.
If you have changed your career to become a UX designer or product designer, Making and Breaking the Grid will help you quickly get insight into the grid's evolution.
Even though the author has written this book for the designers in the printing field, digital designers, too, can benefit.
#5 Laws of UX: Using Psychology to Design Better Products & Services (2020)
by Jon Yablonski
Image for post
Laws of UX: Using Psychology to Design Better Products & Services
“As designers, it is our objective to ensure people successfully achieve their goals when using the interfaces we’ve built by eliminating as much friction as possible. Not all friction is bad — in fact, sometimes it is even necessary. But when there is an opportunity to remove or avoid extraneous friction, then we should do so.”
It’s a short book packed with a lot of knowledge. Easy to read. Easy to understand. The references are for anyone who works in the tech field. The author compiled them in a way that’s easy to digest.
You should expect some great examples of psychological rules that have an impact on user experience. Although it's not a full-blown comprehensive resource for psychology in design, it does gives you a concise guide of essential UX/UI tips backed up by logical principles.
I always find myself coming back to this book during the course of a project.
#6 Just Enough Research
by Erika Hall
Image for post
Just Enough Research (2013) by Erika Hall
“Research is simply a systematic inquiry. You want to know more about a particular topic, so you go through a process to increase your knowledge. The type of process depends on who you are and what you need to know. ”
Designers do research all the time. In the middle of research, sometimes I lose myself. Sometimes I don’t know what I’m looking for after consuming almost all the information out there.
But this book gives me guidelines. I learned that asking the right questions and being organized about the answers is just enough. That will always keep me on track and prevent wasting time and money.
You’ll get specific advice on what to ask and how to work on various types of research. If you have a product or target users in mind, you can test your assumptions based on what you learned.
#7 Design for Kids (2014)
by Debra Levin Gelman
Image for post
Design for Kids
“This generation of kids is digitally native, meaning that technology has and always will be a part of their lives. Unlike previous generations, these digital natives believe that technology exists to serve them, instead of the other way around. They have always known “reset” and “undo” and “play again.” They see technology as a tool for expression, experimentation, and communication.”
A book like this one is rare. We don’t usually learn to design for kids. But thanks to Debra’s research and experience, we now have access to examples of child-friendly media.
You can learn about how child development takes such leaps during different ages. And why children of various ages require different user experiences. Also, how you should design for these needs.
If you are looking for a comprehensive book on user research and designing for kids, this is the must-read. It is exactly what you’re looking for.
",
                }
            );

            modelBuilder.Entity<Comment>().HasData(
                new Comment
                {
                    Id = 1,
                    Author = "Giannis E.",
                    BlogPostId = 3,
                    CommentMessage = "Excellent suggestion of books. I have a question though, on the third book there is a page that says it's better to wait and see how the code reacts to changes, is this a good suggestion?"
                }
               );
         
        }
    }
}
