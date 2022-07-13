using BackendService;
using BackendService.Models;
using BackendService.Services;

namespace MVPWinForms.Views.Blogs
{
    public partial class FrmBlogs : Form
    {
        private readonly BlogsViewer _blogsViewer;
        private readonly DataContext _dataContext;
        public DataGridView? TableBlogGridView
        {
            get => tableBlogs;
            set => tableBlogs = value;
        }

        public TextBox Url
        {
            get => txtURL;
            set => txtURL = value;
        }

        public TextBox BlogId
        {
            get => txtBlogId;
            set => txtBlogId = value;
        }

        public FrmBlogs()
        {
            _dataContext = new DataContext();
            _blogsViewer = new BlogsViewer(new Blog(), this, new BlogService(_dataContext));
            InitializeComponent();
        }

        private void frmBlogsViewer_Load(object sender, EventArgs e)
        {
            _blogsViewer.GetAllBlogs();
        }

        public void AddBlog_Click(object sender, EventArgs e)
        {
            _blogsViewer.AddBlog();
        }

        private void UpdateBlog_Click(object sender, EventArgs e)
        {   
            _blogsViewer.UpdateBlog();
        }

        private void tableBlogs_MouseClick(object sender, MouseEventArgs e)
        {
            _blogsViewer.SelectedBlogItem();
        }

        private void DeleteBlog_Click(object sender, EventArgs e)
        {
            _blogsViewer.DeleteBlog();
        }
    }
}
