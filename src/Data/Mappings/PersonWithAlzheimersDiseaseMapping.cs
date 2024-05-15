using IfaceMainApi.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IfaceMainApi.Data.Mappings;
public class PersonWithAlzheimersDiseaseMapping : IEntityTypeConfiguration<PersonWithAlzheimersDisease>
{
    public void Configure(EntityTypeBuilder<PersonWithAlzheimersDisease> builder)
    {
        builder.ToTable("persons_with_alzheimer_disease");
        builder.HasKey(x => x.Id);
        builder.HasOne(x => x.Person).WithOne().HasForeignKey<PersonWithAlzheimersDisease>(x => x.PersonId);
        builder.HasOne(x => x.Clinic).WithMany(x => x.Patients).HasForeignKey(x => x.ClinicId);
        builder.HasOne(x => x.Responsible).WithMany(x => x.PersonsWithAlzheimerDisease)
            .HasForeignKey(x => x.ResponsibleId);
    }
}
