using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackendService.Models;

namespace BackendService.Services
{
    public class BlogService : IBlogService
    {
        private readonly DataContext _dataContext;

        public BlogService(DataContext dataContext)
        {
            this._dataContext = dataContext;
        }

        public List<Blog> GetAllBlogs()
        {
            return _dataContext.Blogs.ToList();
        }

        public Blog GetBlogById(int blogId)
        {
            throw new NotImplementedException();
        }

        public Blog Add(Blog blog)
        {
            var newBlog = new Blog();
            newBlog.URL = blog.URL;

            _dataContext.Add(newBlog);
            _dataContext.SaveChanges();

            return newBlog;
        }

        public Blog Update(int blogId, Blog blog)
        {
            var updateBlog = _dataContext.Blogs.Find(blogId);

            if (updateBlog == null)
            {
                throw new ArgumentNullException($"Blog with Id {blogId} not found.");
            }

            updateBlog.URL = blog.URL;

            _dataContext.Update(updateBlog);
            _dataContext.SaveChanges();

            return updateBlog;
        }

        public void Delete(int blogId)
        {
            var deleteBlog = _dataContext.Blogs.Find(blogId);

            if (deleteBlog == null)
            {
                throw new ArgumentNullException($"Blog with Id {blogId} not found.");
            }

            _dataContext.Remove(deleteBlog);
            _dataContext.SaveChanges();
        }
    }
}
