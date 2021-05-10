using HotelBlazro.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelBlazro.Repos
{
    public class SupplementConfiguration: IEntityTypeConfiguration<Supplement>
    {
        public void Configure(EntityTypeBuilder<Supplement> builder)
        {
            builder.Property(f => f.Id).ValueGeneratedOnAdd(); ;
            builder.Property(s => s.Description).HasColumnName(nameof(Supplement.Description)).HasMaxLength(50).IsRequired();
            builder.Property(s => s.Price).HasColumnName(nameof(Supplement.Price)).IsRequired();
            builder.Property(s => s.Selected).HasColumnName(nameof(Supplement.Selected)).IsRequired();
        }
    }
}