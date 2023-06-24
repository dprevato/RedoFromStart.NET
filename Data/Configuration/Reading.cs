using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model;

namespace Data;
public class ReadingMap : IEntityTypeConfiguration<Reading>
{
    public void Configure(EntityTypeBuilder<Reading> e) {
        e.Property(x => x.Id).ValueGeneratedOnAdd();
        e.HasKey(x => x.Id);
        e.Property(x => x.ScanDate).HasColumnType("TIMESTAMP");
        e.Property(x => x.Value).HasColumnType("DECIMAL(10,4)");
        e.Property(x => x.AcquisitionDate).HasColumnType("DATE");
        e.Property(x => x.ValidationDate).HasColumnType("DATE").IsRequired(false);
        e.Property(x => x.Ts).IsRowVersion();

        e.HasOne(x => x.PM).WithMany(x => x.Readings).HasForeignKey(x => x.PMId);
    }
}