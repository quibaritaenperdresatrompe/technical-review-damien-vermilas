using System;

namespace TestValApi
{
    public class Post
    {
        public string Author { get; set; }
        public DateTime Date { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public string[] Comments { get; set; }
    }
}
