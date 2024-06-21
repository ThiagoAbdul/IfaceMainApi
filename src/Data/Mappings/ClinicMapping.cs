using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IfaceMainApi.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IfaceMainApi.Data.Mappings
{
    public class ClinicMapping : IEntityTypeConfiguration<Clinic>
    {
        public void Configure(EntityTypeBuilder<Clinic> builder)
        {
            builder.ToTable("clinics");
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Credentials).WithOne().HasForeignKey<Clinic>(x => x.CredentialsId);
            builder.HasMany(x => x.ClinicCaregivers).WithOne(x => x.Clinic);
        }
    }
}