using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model;

namespace Data;
public class FormulaMap : IEntityTypeConfiguration<Formula>
{
    public void Configure(EntityTypeBuilder<Formula> e) {
        e.Property(x => x.Id).ValueGeneratedNever();
        e.HasKey(x => x.Id);

        e.Property(x => x.Ts).IsRowVersion();
    }
}