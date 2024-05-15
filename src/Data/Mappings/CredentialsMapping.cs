using IfaceMainApi.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IfaceMainApi.Data.Mappings;

public class CredentialsMapping : IEntityTypeConfiguration<Credentials>
{
    public void Configure(EntityTypeBuilder<Credentials> builder)
    {
        builder.ToTable("credentials");
        builder.HasKey(x => x.Id);
        builder.HasIndex(x => x.Email).IsUnique();
        
    }
}
