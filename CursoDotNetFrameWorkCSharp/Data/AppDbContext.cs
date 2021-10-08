using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using CursoDotNetFrameWorkCSharp.Models;

namespace CursoDotNetFrameWorkCSharp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base(nameOrConnectionString: "DefaultConnection")
        {

        }

        public DbSet<Cliente> Clientes {get; set;}
    }
}