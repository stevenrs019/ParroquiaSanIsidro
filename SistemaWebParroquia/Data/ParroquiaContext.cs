using Microsoft.EntityFrameworkCore;
using SistemaWebParroquia.Models;

namespace SistemaWebParroquia.Data
{
    public class ParroquiaContext : DbContext
    {
        public ParroquiaContext(DbContextOptions<ParroquiaContext> options) : base(options)
        {
        }

        public DbSet<SistemaWebParroquia.Models.Bautizo> bautizos { get; set; }
        public DbSet<SistemaWebParroquia.Models.Confirmacion> confirmacion { get; set; }
        public DbSet<SistemaWebParroquia.Models.Matrimonios> matrimonios { get; set; }
        public DbSet<SistemaWebParroquia.Models.Persona> persona { get; set; }
        public DbSet<SistemaWebParroquia.Models.PrimeraComunion> primeraComunion { get; set; }
        public DbSet<SistemaWebParroquia.Models.Personas> personas { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Confirmacion>()
                .Property(e => e.FechaConfirmacion)
                .HasColumnType("Date");
            modelBuilder.Entity<Confirmacion>()
               .Property(e => e.fechaBautizo)
               .HasColumnType("Date");
            modelBuilder.Entity<PrimeraComunion>()
               .Property(e => e.FechaComunion)
               .HasColumnType("Date");
            modelBuilder.Entity<PrimeraComunion>()
               .Property(e => e.FechaBautizo)
               .HasColumnType("Date");
            modelBuilder.Entity<Personas>()
               .Property(e => e.FechaNacimiento)
               .HasColumnType("Date");
            modelBuilder.Entity<Bautizo>()
               .Property(e => e.FechaBautizo)
               .HasColumnType("Date");
            modelBuilder.Entity<Matrimonios>()
             .Property(e => e.FechaMatrimonio)
             .HasColumnType("Date");
            modelBuilder.Entity<Matrimonios>()
            .Property(e => e.FechaBautizo1)
            .HasColumnType("Date");
            modelBuilder.Entity<Matrimonios>()
            .Property(e => e.FechaBautizo2)
            .HasColumnType("Date");
        }
    }
}
