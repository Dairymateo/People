using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ClaseRecuperacion2.Models;

namespace ClaseRecuperacion2.Data
{
    public class ClaseRecuperacion2Context : DbContext
    {
        public ClaseRecuperacion2Context (DbContextOptions<ClaseRecuperacion2Context> options)
            : base(options)
        {
        }

        public DbSet<ClaseRecuperacion2.Models.Persona> Persona { get; set; } = default!;
    }
}
