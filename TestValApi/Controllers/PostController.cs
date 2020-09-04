using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace TestValApi.Controllers
{
    public class Payload
    {
        public string author { get; set; }
        public string content { get; set; }
    }

    [ApiController]
    [Route("[controller]")]
    public class PostController : ControllerBase
    {

        [HttpPost]
        public Post AddPost([FromBody] Payload payload)
        {
            var result = new Post
            {
                Author = payload.author,
                Content = payload.content,
                Likes = 0,
                Comments = new string[] { },
                Date = DateTime.Now

            };
            PostRepositoryInMemory.Insert(result);
            return result;
        }

        [HttpGet]
        public List<Post> GetAll()
        {
            return PostRepositoryInMemory.SelectAll();
        }

    }
}
