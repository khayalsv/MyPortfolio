using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsessLayer.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=SALIMOV\\SQLEXPRESS;database=MyPortfolio;integrated security=true;");
        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<Home> Homes { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Skills> Skills { get; set; }
        public DbSet<Details> Details { get; set; }

    }
}
