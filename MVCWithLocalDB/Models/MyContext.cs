using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using MVCWithLocalDB.Models;

namespace MVCWithLocalDB
{
    public class MyContext : DbContext
    {
        public DbSet<Test> Tests { get; set; }
    }
}