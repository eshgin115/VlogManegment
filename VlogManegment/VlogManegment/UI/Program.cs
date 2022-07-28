using System;
using System.Collections.Generic;

namespace VlogManegment.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Blog> blogs = new List<Blog>()
            {
                new Blog("Alyo","Belde",new List<string>{"salam","Kim"},Status.Rejected),
                 new Blog("Alyo","Belde",new List<string>{"salam","Kim"},Status.confirmed),

            };


        }
    }
    class Blog
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public List<string> Tag { get; set; }
        public DateTime CreateTimeContent { get; set; } = DateTime.Now;
        public Status Status1 { get; set; }
        public Blog(string title, string content, List<string> tag, Status status)
        {
            Title = title;
            Content = content;
            Tag = tag;
            Status1 = status;

        }


    }

    enum Status
    {
        Sented = 1,
        confirmed = 2,
        Rejected = 3
    }
}
