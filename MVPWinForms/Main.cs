using System.IO.Pipes;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using BackendService;
using BackendService.Services;
using MVPWinForms.Presenters.Blogs;
using MVPWinForms.Views.Blogs;

namespace MVPWinForms
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            FrmBlogs b = new FrmBlogs();
            b.Show();
        }
    }
}