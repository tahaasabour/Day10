

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

public class PlaylistConfiguration : IEntityTypeConfiguration<Playlist>
{
    public void Configure(EntityTypeBuilder<Playlist> builder)
    {
        builder.ToTable("Playlist");
        builder
            .HasKey(i => i.ID);
        builder.Property
            (i => i.ID).ValueGeneratedOnAdd();

        builder.Property
           (i => i.Title).IsRequired().HasMaxLength(500);

        builder.HasMany(i => i.Videos)
            .WithOne(i => i.Playlist)
            .HasForeignKey(i => i.PlaylistID)
            .IsRequired();
    }
}