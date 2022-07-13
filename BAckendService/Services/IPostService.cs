using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackendService.Models;

namespace BackendService.Services
{
    public interface IPostService
    {
        IEnumerable<Post> GetAllPosts();

        Post GetBlogById(int Id);

        Post Add(Post post);

        Post Update(int Id, Post post);

        void Delete(int Id);
    }
}
