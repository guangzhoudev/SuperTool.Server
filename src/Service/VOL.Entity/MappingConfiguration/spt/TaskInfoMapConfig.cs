using VOL.Entity.MappingConfiguration;
using VOL.Entity.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VOL.Entity.MappingConfiguration
{
    public class TaskInfoMapConfig : EntityMappingConfiguration<TaskInfo>
    {
        public override void Map(EntityTypeBuilder<TaskInfo>
        builderTable)
        {
          //b.Property(x => x.StorageName).HasMaxLength(45);
        }
     }
}

