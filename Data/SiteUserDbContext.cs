using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.Data
{
    public class SiteUserDbContext:DbContext
    {
        public SiteUserDbContext(DbContextOptions<SiteUserDbContext> options)
            : base(options)
        {
        }

        public DbSet<SiteUser> SiteUsers { get; set; }
    }
}
