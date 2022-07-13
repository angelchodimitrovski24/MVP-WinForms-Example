using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackendService.Models;
using Microsoft.EntityFrameworkCore;

namespace BackendService
{
    // DDD - domain driven design pattern
    public class DataContext : DbContext
    {
        private string _dbPath;

        // Database tables
        public DbSet<Blog> Blogs { get; set; }

        public DbSet<Post> Posts { get; set; }

        public string DbPath
        {
            get => _dbPath;
            set => _dbPath = value;
        }

        public DataContext()
        {
            var path = Environment.CurrentDirectory;
            _dbPath = Path.Join(path, "blogging.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // SQLite
            //optionsBuilder.UseSqlite($"Data Source={_dbPath}");

            //SQL Server
            //optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Blogging;Trusted_Connection=True");
            //optionsBuilder.UseSqlServer(@"Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
            optionsBuilder.UseSqlServer(@"Server=.\sqlexpress;Database=Blogging;Trusted_Connection=True;");
        }
    }
}
