using ClinicaApi.Models;
using Microsoft.EntityFrameworkCore;

namespace ClinicaApi.Data
{
    public class VetContext : DbContext
    {
        public VetContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Tutor> Tutores { get; set; }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<Veterinario> Veterinarios { get; set; }
        public DbSet<Consulta> Consultas { get; set; }
    }
}
