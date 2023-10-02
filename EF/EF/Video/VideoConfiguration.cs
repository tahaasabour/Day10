


using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

public class VideoConfiguration : IEntityTypeConfiguration<Video>
{
    public void Configure(EntityTypeBuilder<Video> builder)
    {
        builder.ToTable("Video");
        builder
            .HasKey(i => i.ID);
        builder.Property
            (i => i.ID).ValueGeneratedOnAdd();
        builder.Property
            (i => i.Title).IsRequired().
            HasMaxLength(250);
        builder.Property
           (i => i.Description).IsRequired().
           HasMaxLength(500);
    }
}