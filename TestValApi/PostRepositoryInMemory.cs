using System;
using System.Collections.Generic;

namespace TestValApi
{
    public static class PostRepositoryInMemory
    {
        private static List<Post> repository = new List<Post>();

        public static void Insert(Post post)
        {
            repository.Add(post);
        }

        public static List<Post> SelectAll()
        {
            return repository;
        }
    }
}