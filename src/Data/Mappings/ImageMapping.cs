using IfaceMainApi.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IfaceMainApi.Data.Mappings
{
    public class ImageMapping : MappingBase<Image>
    {
        public override void Configure(EntityTypeBuilder<Image> builder)
        {
            base.Configure(builder);

            builder.ToTable("images");

            builder.HasOne(x => x.KnownPerson)
                .WithMany(x => x.Photos)
                .HasForeignKey(x => x.KnownPersonId);
        }
    }
}
