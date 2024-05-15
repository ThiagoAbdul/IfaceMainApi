using IfaceMainApi.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IfaceMainApi.Data.Mappings;
public class CaregiverHelpMapping : IEntityTypeConfiguration<CaregiverHelp>
{
    public void Configure(EntityTypeBuilder<CaregiverHelp> builder)
    {
        builder.ToTable("caregiver_helps");
        builder.HasKey(x => x.Id);
        builder.HasOne(x => x.Helper).WithMany().HasForeignKey(x => x.HelperId);
        builder.HasOne(x => x.Supervisor).WithMany().HasForeignKey(x => x.SupervisorId);
        
    }
}
