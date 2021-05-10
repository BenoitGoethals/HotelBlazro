using HotelBlazro.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelBlazro.Repos
{
    public class RoomConfiguration: IEntityTypeConfiguration<Room>
    {
        public void Configure(EntityTypeBuilder<Room> builder)
        {
            builder.Property(f => f.Id)
                .ValueGeneratedOnAdd(); ;
            builder.Property(s => s.Name).HasColumnName(nameof(Room.Name)).HasMaxLength(50).IsRequired();
            builder.Property(s => s.Price).HasColumnName(nameof(Room.Price)).IsRequired();
            builder.Property(s => s.Active).HasColumnName(nameof(Room.Active)).IsRequired();
            builder.Property(s => s.RoomNumber).HasColumnName(nameof(Room.RoomNumber));
           

          
        }
    }
}