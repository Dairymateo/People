using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TallerProgreso1.Models;

namespace TallerProgreso1.Data
{
    public class TallerProgreso1Context : DbContext
    {
        public TallerProgreso1Context(DbContextOptions<TallerProgreso1Context> options)
            : base(options)
        {
        }

        public DbSet<TallerProgreso1.Models.Propietaria> Propietaria { get; set; } = default!;
        public DbSet<TallerProgreso1.Models.Auto> Auto { get; set; } = default!;
        public DbSet<TallerProgreso1.Models.Motor> Motor { get; set; } = default!;
    }
}
