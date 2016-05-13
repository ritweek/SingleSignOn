using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using SingleSignOn.Models;

namespace SingleSignOn.Service
{
    public class Context : DbContext
    {

        public Context() : base  ("Context")
        {
           
        }

        public DbSet<UserDetails> Users { get; set; } 
    }
}