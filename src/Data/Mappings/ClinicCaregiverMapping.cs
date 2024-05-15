using IfaceMainApi.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IfaceMainApi.Data.Mappings;

public class ClinicCaregiverMapping : IEntityTypeConfiguration<ClinicCaregiver>
{
    public void Configure(EntityTypeBuilder<ClinicCaregiver> builder)
    {
        builder.ToTable("clinic_caregivers");
        builder.HasKey(x => x.Id);
        builder.HasOne(x => x.Clinic).WithMany(x => x.ClinicCaregivers).HasForeignKey(x => x.ClinicId);
        builder.HasOne(x => x.Caregiver).WithMany(x => x.ClinicCaregivers).HasForeignKey(x => x.CaregiverId);
    }
}
