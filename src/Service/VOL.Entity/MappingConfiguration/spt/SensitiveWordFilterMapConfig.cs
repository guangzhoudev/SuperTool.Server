using VOL.Entity.MappingConfiguration;
using VOL.Entity.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VOL.Entity.MappingConfiguration
{
    public class SensitiveWordFilterMapConfig : EntityMappingConfiguration<SensitiveWordFilter>
    {
        public override void Map(EntityTypeBuilder<SensitiveWordFilter>
        builderTable)
        {
          //b.Property(x => x.StorageName).HasMaxLength(45);
        }
     }
}

