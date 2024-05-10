using IPTestFormASP.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace IPTestFormASP.Data
{
    public class IPTestFormASPDbContext : DbContext
    {
        public DbSet<IPInfos> IPInfos { get; set; }

        public IPTestFormASPDbContext(DbContextOptions<IPTestFormASPDbContext> options) 
            : base(options)
        { 
        }
    }
}
