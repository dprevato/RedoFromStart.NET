using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model;

namespace Data;
public class MetaDictionaryMap : IEntityTypeConfiguration<MetaDictionary>
{
    public void Configure(EntityTypeBuilder<MetaDictionary> e) {
        e.Property(x => x.Key).HasMaxLength(64);
        e.HasKey(x => x.Key);
    }
}