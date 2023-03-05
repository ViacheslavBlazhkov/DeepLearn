using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DeepLearn.Models;

namespace DeepLearn.Data
{
    public class DeepLearnContext : DbContext
    {
        public DeepLearnContext (DbContextOptions<DeepLearnContext> options)
            : base(options)
        {
        }

        public DbSet<DeepLearn.Models.Lesson> Lesson { get; set; } = default!;

        public DbSet<DeepLearn.Models.Module> Module { get; set; } = default!;

        public DbSet<DeepLearn.Models.TheoryBlock> TheoryBlock { get; set; } = default!;
    }
}
