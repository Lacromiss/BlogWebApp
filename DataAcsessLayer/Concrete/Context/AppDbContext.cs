using EntityLayerr.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcsessLayer.Concrete.Context
{
    public class AppDbContext:DbContext
    {
       protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("server =DESKTOP-ESAVM42\\SQLEXPRESS; database=BlogWebApMM; integrated security=true;");
        }
      public  DbSet<Test> tests { get; set; }
      public  DbSet<Blog> blogs { get; set; }
      public  DbSet<Category> categories { get; set; }
      public  DbSet<Comment> comments { get; set; }
      public  DbSet<Contact> contacts { get; set; }
    }
}
