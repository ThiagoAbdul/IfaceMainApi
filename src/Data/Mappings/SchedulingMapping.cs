using IfaceMainApi.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IfaceMainApi.Data.Mappings;
public class SchedulingMapping : MappingBase<Scheduling>
{
    public override void Configure(EntityTypeBuilder<Scheduling> builder)
    {
        base.Configure(builder);

        builder.ToTable("schedules");
        
        builder.HasOne(x => x.PersonWithAlzheimersDisease)
            .WithMany(x => x.Schedules)
            .HasForeignKey(x => x.PersonWithAlzheimersDiseaseId);
    }
}
