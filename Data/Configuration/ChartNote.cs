using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model;

namespace Data;
public class ChartNoteMap : IEntityTypeConfiguration<ChartNote>
{
    public void Configure(EntityTypeBuilder<ChartNote> e) {
        e.HasKey(x => x.Id);
        e.Property(x => x.Xpos).HasColumnType("TIMESTAMP");
        e.Property(x => x.Ypos).HasColumnType("NUMERIC(10, 4)");

    }
}