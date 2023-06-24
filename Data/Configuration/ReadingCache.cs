using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model;

namespace Data;
public class ReadingCacheMap : IEntityTypeConfiguration<ReadingCache>
{
    public void Configure(EntityTypeBuilder<ReadingCache> e) {
        e.HasKey(x => x.PMId);
        e.Property(x => x.ReadingDateTime).HasColumnType("TIMESTAMP");
        e.Property(x => x.ReadingValue).HasColumnType("DECIMAL(10,4)");
        e.Property(x => x.AcquisitionDate).HasColumnType("DATE");
    }
}