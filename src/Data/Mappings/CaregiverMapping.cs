using IfaceMainApi.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IfaceMainApi.Data.Mappings;
public class CaregiverMapping : IEntityTypeConfiguration<Caregiver>
{
    public void Configure(EntityTypeBuilder<Caregiver> builder)
    {
        builder.ToTable("caregivers");
        builder.HasKey(x => x.Id);
        builder.HasOne(x => x.Person).WithOne().HasForeignKey<Caregiver>(x => x.PersonId);
        builder.HasOne(x => x.Credentials).WithOne().HasForeignKey<Caregiver>(x => x.CredentialsId);
        builder.HasMany(x => x.ClinicCaregivers).WithOne(x => x.Caregiver);
    }
}
