using IfaceMainApi.Data.Mappings;
using IfaceMainApi.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace IfaceMainApi.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Careful> Carefuls { get; set; }
    public DbSet<Caregiver> Caregivers { get; set; }
    public DbSet<Change> Changes { get; set; }
    public DbSet<KnownPerson> KnownPersons { get; set; }
    public DbSet<Person> Persons { get; set; }
    public DbSet<PersonWithAlzheimerDisease> PersonWithAlzheimerDisease { get; set; }

    public DbSet<Prescription> Prescriptions { get; set; }
    public DbSet<Photo> Photos { get; set; }
    public DbSet<Routine> Routines { get; set; }
    public DbSet<Scheduling> Schedules { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new CaregiverMapping());
        modelBuilder.ApplyConfiguration(new ChangeMapping());
        modelBuilder.ApplyConfiguration(new KnownPersonMapping());
        modelBuilder.ApplyConfiguration(new PersonMapping());
        modelBuilder.ApplyConfiguration(new PersonWithAlzheimersDiseaseMapping());
        modelBuilder.ApplyConfiguration(new PhotoMapping());
        modelBuilder.ApplyConfiguration(new PrescriptionMapping());
        modelBuilder.ApplyConfiguration(new RoutineMapping());
        modelBuilder.ApplyConfiguration(new SchedulingMapping());
        modelBuilder.ApplyConfiguration(new CarefulMapping()); 

    }
}