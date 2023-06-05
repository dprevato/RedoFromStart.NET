using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model;

namespace Data;
public class AgentMap : IEntityTypeConfiguration<Agent>
{
    public void Configure(EntityTypeBuilder<Agent> e) {
        e.HasKey(x => x.Id);
        e.Property(x => x.PersonId).IsRequired();
        e.Property(x => x.LoginName).IsRequired();
        e.Property(x => x.RoleId).IsRequired();
        e.Property(x => x.FirstLogOn).HasColumnType("DATE");
        e.Property(x => x.LastLogOn).HasColumnType("DATE");
        e.Property(x => x.Ts).IsRowVersion();

        e.HasOne(x => x.Person).WithMany(x => x.Agents).HasForeignKey(x => x.PersonId);
    }
}