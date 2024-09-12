using IfaceMainApi.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IfaceMainApi.Data.Mappings;
public class PrescriptionMapping : MappingBase<Prescription>
{
    public override void Configure(EntityTypeBuilder<Prescription> builder)
    {
        base.Configure(builder);

        builder.ToTable("prescriptions");

        builder.HasOne(x => x.Patient)
                .WithMany(x => x.Prescriptions)
                .HasForeignKey(x => x.PatientId);
        
    }
}
