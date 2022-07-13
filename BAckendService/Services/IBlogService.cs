using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackendService.Models;

namespace BackendService.Services
{
    public interface IBlogService
    {
        List<Blog> GetAllBlogs();

        Blog GetBlogById(int Id);

        Blog Add(Blog blog);

        Blog Update(int Id, Blog blog);

        void Delete(int Id);

    }
}
