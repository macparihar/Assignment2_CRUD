using assignment2_crud.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2_crud
{
    public class DataContext : DbContext
    {
        public string DbPath { get; set; }

        public DataContext()
        {
            var path = AppContext.BaseDirectory;
            DbPath = Path.Combine(path, "TestDatabase.db");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
        public DbSet<User> Users { get; set; }
    }
}
