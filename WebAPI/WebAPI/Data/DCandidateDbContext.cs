using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAPI.Models;

namespace WebAPI.Data
{
    public class DCandidateDbContext : DbContext
    {
        public DCandidateDbContext (DbContextOptions<DCandidateDbContext> options)
            : base(options)
        {
        }

        public DbSet<WebAPI.Models.DCandidate> DCandidate { get; set; }
    }
}
