using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model;

namespace Data;
public class ArgMap : IEntityTypeConfiguration<Arg>
{
    public void Configure(EntityTypeBuilder<Arg> e) {
        e.HasKey(x => x.Id);
        e.Property(x => x.Ts).IsRowVersion();

        e.HasOne(x => x.PM).WithMany(x => x.Args).HasForeignKey(x => x.PMId);
    }
}