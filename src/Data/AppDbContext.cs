using IfaceMainApi.Data.Mappings;
using IfaceMainApi.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace IfaceMainApi.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{

    public DbSet<Caregiver> Caregivers { get; set; }
    public DbSet<CaregiverHelp> CaregiverHelps { get; set; }
    public DbSet<Clinic> Clinicis { get; set; }
    public DbSet<ClinicCaregiver> ClinicCaregivers { get; set; }
    public DbSet<Credentials> Credentials { get; set; }
    public DbSet<Medicine> Medicines { get; set; }
    public DbSet<NonUserSupportPerson> NonUserSupportPersons { get; set; }
    public DbSet<Person> Persons { get; set; }

    public DbSet<Prescription> Prescriptions { get; set; }
    public DbSet<Scheduling> Schedules { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new CaregiverMapping());
        modelBuilder.ApplyConfiguration(new CaregiverHelpMapping());
        modelBuilder.ApplyConfiguration(new ClinicMapping());
        modelBuilder.ApplyConfiguration(new ClinicCaregiverMapping());
        modelBuilder.ApplyConfiguration(new CredentialsMapping());
        modelBuilder.ApplyConfiguration(new MedicineMapping());
        modelBuilder.ApplyConfiguration(new NonUserSupportPersonMapping());
        modelBuilder.ApplyConfiguration(new PersonMapping());
        modelBuilder.ApplyConfiguration(new PersonWithAlzheimersDiseaseMapping());
        modelBuilder.ApplyConfiguration(new PrescriptionMapping());
        modelBuilder.ApplyConfiguration(new SchedulingMapping());
 
    }
}