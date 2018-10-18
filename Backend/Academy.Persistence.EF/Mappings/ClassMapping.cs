using System;
using System.Collections.Generic;
using System.Text;
using Academy.Domain.Model.Classes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Academy.Persistence.EF.Mappings
{
    public class ClassMapping:IEntityTypeConfiguration<Class>
    {
        public void Configure(EntityTypeBuilder<Class> builder)
        {
            builder.ToTable("Class").HasKey(x=>x.Id);
            builder.Property(x => x.Title).HasMaxLength(30).IsRequired();
            builder.Property(x => x.Number).IsRequired();
        }
    }
}
