using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackendService.Models;

namespace BackendService.Services
{
    public class PostService : IPostService
    {
        public IEnumerable<Post> GetAllPosts()
        {
            throw new NotImplementedException();
        }

        public Post GetBlogById(int Id)
        {
            throw new NotImplementedException();
        }

        public Post Add(Post post)
        {
            throw new NotImplementedException();
        }

        public Post Update(int Id, Post post)
        {
            throw new NotImplementedException();
        }

        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
