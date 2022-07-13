using BackendService.Models;
using BackendService.Services;
using MVPWinForms.Presenters.Blogs;

namespace MVPWinForms.Views.Blogs
{
    public class BlogsViewer
    {
        private FrmBlogs _view;
        private BlogsPresenter _blogsPresenter;
        private IBlogService _blogService;

        private Blog _blog;

        public BlogsViewer(Blog blog, FrmBlogs view, IBlogService blogService)
        {
            _blog = new Blog();
            _view = view;
            _blogService = blogService;
            _blogsPresenter = new BlogsPresenter(_blogService);
        }

        public void GetAllBlogs()
        {
            _view.TableBlogGridView!.DataSource = _blogsPresenter.GetAllBlogs();
        }

        public void AddBlog()
        {
            _blog.URL = _view.Url.Text;

            _blogsPresenter.AddBlog(_blog);

            MessageBox.Show(@"Blog added to DB");

            GetAllBlogs();
        }

        public void UpdateBlog()
        {
            if (_view.Url.Text != null)
                _blog.URL = _view.Url.Text;

            if (_view.BlogId.Text != null)
                _blogsPresenter.UpdateBlog(Convert.ToInt32(_view.BlogId.Text), _blog);

            MessageBox.Show(@"Blog updated!");

            GetAllBlogs();
        }

        public void DeleteBlog()
        {
            if (_view.BlogId.Text != null)
                _blogsPresenter.DeleteBlog(Convert.ToInt32(_view.BlogId.Text));

            MessageBox.Show(@"Blog deleted from DB");

            GetAllBlogs();
        }

        public void SelectedBlogItem()
        {
            string? valueId = null, url = null;
            if (_view.tableBlogs.SelectedRows.Count > 0)
            {
                valueId = _view.tableBlogs.SelectedRows[0].Cells[0].Value.ToString();
                if (valueId != null)
                {
                    _view.BlogId.Text = valueId;
                }

                url = _view.tableBlogs.SelectedRows[0].Cells[1].Value.ToString();
                if (valueId != null)
                {
                    _view.Url.Text = url;
                }
            }
        }
    }
}
