using IfaceMainApi.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IfaceMainApi.Data.Mappings;
public class SchedulingMapping : IEntityTypeConfiguration<Scheduling>
{
    public void Configure(EntityTypeBuilder<Scheduling> builder)
    {
        builder.ToTable("schedules");
        builder.HasKey(x => x.Id);
        builder.HasOne(x => x.PersonWithAlzheimersDisease).WithMany(x => x.Schedules)
            .HasForeignKey(x => x.PersonWithAlzheimersDiseaseId);
        builder.HasOne(x => x.Prescription).WithMany().HasForeignKey(x => x.PrescriptionId);
    }
}
