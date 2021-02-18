using VOL.Entity.MappingConfiguration;
using VOL.Entity.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VOL.Entity.MappingConfiguration
{
    public class UpdateLogsMapConfig : EntityMappingConfiguration<UpdateLogs>
    {
        public override void Map(EntityTypeBuilder<UpdateLogs>
        builderTable)
        {
          //b.Property(x => x.StorageName).HasMaxLength(45);
        }
     }
}

