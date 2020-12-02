using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using telerik_asp_core.Models;
using Microsoft.EntityFrameworkCore;


namespace telerik_asp_core.Data
{
    public class LeadsDbContext : DbContext
    {
        public LeadsDbContext(DbContextOptions<LeadsDbContext> options) : base(options)
        {

        }

        public DbSet<Lead> Leads {get; set;}
    }
}
