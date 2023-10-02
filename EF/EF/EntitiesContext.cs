
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client.Platforms.Features.DesktopOs.Kerberos;

public class EntitiesContext : DbContext
{

    public DbSet<Video> Videos { get; set; }
    public DbSet<Playlist> Playlists { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration<Playlist>(new PlaylistConfiguration());
        modelBuilder.ApplyConfiguration<Video>(new VideoConfiguration());
        base.OnModelCreating(modelBuilder);
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Data Source=.; Initial Catalog=Test; 
                    Integrated Security=True; TrustServerCertificate=True;");
        base.OnConfiguring(optionsBuilder);
    }
}