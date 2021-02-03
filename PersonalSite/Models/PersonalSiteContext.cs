using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace PersonalSite.Models
{
    public class PersonalSiteContext : DbContext
    {
        public PersonalSiteContext()
            : base("PersonalSite")
        { 
        }
        public DbSet<PersonalSiteEntry> Entries { get; set; }
    }
}
