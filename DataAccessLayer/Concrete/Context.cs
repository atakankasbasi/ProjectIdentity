using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : IdentityDbContext<AppUser, AppRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //(localdb)\\MSSQLLocalDB    
            optionsBuilder.UseSqlServer("Server=MUHAMMET\\SQLEXPRESS; initial catalog=IdentityDB;integrated security=true");
        }
        public DbSet<Message> Messages { get; set; }
    }
}

