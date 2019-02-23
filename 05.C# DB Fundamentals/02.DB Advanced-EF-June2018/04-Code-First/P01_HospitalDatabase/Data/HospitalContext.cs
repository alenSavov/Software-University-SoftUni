namespace P01_HospitalDatabase.Data
{
    using Microsoft.EntityFrameworkCore;
    using Models;

    public class HospitalContext : DbContext
    {
        public HospitalContext()
        { }

        public HospitalContext(DbContextOptions options)
            : base(options) { }

        public DbSet<Patient> Patients { get; set; }
        public DbSet<Medicament> Medicaments { get; set; }
        public DbSet<Diagnose> Diagnoses { get; set; }
        public DbSet<Visitation> Visitations { get; set; }
        public DbSet<PatientMedicament> PatientsMedicaments { get; set; }
        public DbSet<Doctor> Doctors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            if (!builder.IsConfigured)
            {
                builder.UseSqlServer(Configuration.ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Patient>(entity =>
            {
                entity.HasKey(p => p.PatientId);

                entity
                    .Property(p => p.FirstName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode();

                entity
                    .Property(p => p.LastName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode();

                entity
                    .Property(p => p.Address)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode();

                entity
                    .Property(p => p.Email)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity
                    .Property(p => p.HasInsurance)
                    .IsRequired()
                    .HasDefaultValue(true);
            });

            builder.Entity<Doctor>(entity =>
            {
                entity.HasKey(e => e.DoctorId);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode();

                entity.Property(e => e.Specialty)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode();
            });

            builder.Entity<Visitation>(entity =>
            {
                entity.HasKey(v => v.VisitationId);

                entity.Property(v => v.Date)
                    .IsRequired()
                    .HasDefaultValueSql("GETDATE()");

                entity.Property(v => v.Comments)
                    .IsRequired(false)
                    .HasMaxLength(250)
                    .IsUnicode();

                entity.Property(v => v.DoctorId)
                    .IsRequired(false);

                entity.HasOne(v => v.Patient)
                    .WithMany(p => p.Visitations)
                    .HasForeignKey(p => p.PatientId);

                entity.HasOne(v => v.Doctor)
                    .WithMany(e => e.Visitations)
                    .HasForeignKey(v => v.DoctorId);

            });

            builder.Entity<Diagnose>(entity =>
            {
                entity.HasKey(d => d.DiagnoseId);

                entity.Property(d => d.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode();

                entity.Property(d => d.Comments)
                    .IsRequired(false)
                    .HasMaxLength(250)
                    .IsUnicode();

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.Diagnoses)
                    .HasForeignKey(p => p.PatientId);
            });

            builder.Entity<Medicament>(entity =>
            {
                entity.HasKey(m => m.MedicamentId);

                entity.Property(m => m.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode();
            });

            builder.Entity<PatientMedicament>(entity =>
            {
                entity.HasKey(pm => new { pm.PatientId, pm.MedicamentId });

                entity.HasOne(e => e.Medicament)
                    .WithMany(p => p.Prescriptions)
                    .HasForeignKey(e => e.MedicamentId);

                entity.HasOne(e => e.Patient)
                    .WithMany(p => p.Prescriptions)
                    .HasForeignKey(e => e.PatientId);
            });
        }
    }
}
