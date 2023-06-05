using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model;

namespace Data;
public class ChartDefinitionMap : IEntityTypeConfiguration<ChartDefinition>
{
    public void Configure(EntityTypeBuilder<ChartDefinition> e) {
        e.HasKey(x => x.Id);

    }
}