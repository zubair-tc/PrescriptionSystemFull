using Microsoft.EntityFrameworkCore;
using PrescriptionSystem.Domain.Entities;

namespace PrescriptionSystem.Infrastructure.Data
{
    public class PrescriptionDbContext : DbContext
    {
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<PrescriptionItem> PrescriptionItems { get; set; }
        public DbSet<Medicine> Medicines { get; set; }
        public DbSet<Diagnosis> Diagnoses { get; set; }

        public PrescriptionDbContext(DbContextOptions<PrescriptionDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Fallback SQLite connection (for development)
                optionsBuilder.UseSqlite("Data Source=PrescriptionSystem.db");
            }
        }
    }
}
