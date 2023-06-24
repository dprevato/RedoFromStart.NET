using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model;

namespace Data;
public class RoleMap : IEntityTypeConfiguration<Role>
{
    public void Configure(EntityTypeBuilder<Role> e) {
        e.HasKey(x => x.Id);
        e.Property(x => x.Id).HasMaxLength(16);
        e.Property(x => x.Ts).IsRowVersion();
    }
}