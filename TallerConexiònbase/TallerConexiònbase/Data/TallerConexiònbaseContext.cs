using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TallerConexiònbase.Models;

namespace TallerConexiònbase.Data
{
    public class TallerConexiònbaseContext : DbContext
    {
        public TallerConexiònbaseContext (DbContextOptions<TallerConexiònbaseContext> options)
            : base(options)
        {
        }

        public DbSet<TallerConexiònbase.Models.Pais> Pais { get; set; } = default!;
        public DbSet<TallerConexiònbase.Models.RegistroVacunacion> RegistroVacunacion { get; set; } = default!;
    }
}
