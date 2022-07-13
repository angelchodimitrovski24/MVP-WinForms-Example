using BackendService.Models;
using BackendService.Services;

namespace MVPWinForms.Presenters.Blogs
{
    // Facade design pattern of the Services backend

    public class BlogsPresenter
    {
        private readonly IBlogService _blogService;

        public BlogsPresenter(IBlogService iBlogService)
        {
            this._blogService = iBlogService;
        }

        public List<Blog> GetAllBlogs()
        {
            return _blogService.GetAllBlogs();
        }

        public Blog AddBlog(Blog blog)
        {
            _blogService.Add(blog);
            return blog;
        }

        public Blog UpdateBlog(int id, Blog blog)
        {   
            _blogService.Update(id, blog);

            return blog;
        }

        public void DeleteBlog(int id)
        {
            _blogService.Delete(id);            
        }
    }
}
