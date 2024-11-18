using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace IQUEventors
{
    public class AppDbContext : DbContext
    {
        public DbSet<UserSubmission> UserSubmissions { get; set; }
    }
 
}