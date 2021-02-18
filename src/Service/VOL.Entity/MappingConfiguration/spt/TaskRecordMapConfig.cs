using VOL.Entity.MappingConfiguration;
using VOL.Entity.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VOL.Entity.MappingConfiguration
{
    public class TaskRecordMapConfig : EntityMappingConfiguration<TaskRecord>
    {
        public override void Map(EntityTypeBuilder<TaskRecord>
        builderTable)
        {
          //b.Property(x => x.StorageName).HasMaxLength(45);
        }
     }
}

