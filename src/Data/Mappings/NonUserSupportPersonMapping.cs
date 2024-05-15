using IfaceMainApi.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IfaceMainApi.Data.Mappings;
public class NonUserSupportPersonMapping : IEntityTypeConfiguration<NonUserSupportPerson>
{
    public void Configure(EntityTypeBuilder<NonUserSupportPerson> builder)
    {
        builder.ToTable("non_user_support_persons");
        builder.HasKey(x => x.Id);
        builder.HasOne(x => x.Person).WithOne().HasForeignKey<NonUserSupportPerson>(x => x.PersonId);
        builder.HasOne(x => x.PersonWithAlzheimersDisease)
        .WithMany(x => x.NonUserSupportPeople).HasForeignKey(x => x.PersonWithAlzheimersDiseaseId);
    }
}
