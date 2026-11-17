using Microsoft.EntityFrameworkCore;

public class NTCuong_Day6_MovieContext(DbContextOptions<NTCuong_Day6_MovieContext> options) : DbContext(options)
{
    public DbSet<NTCuong_Day6_Movie.Models.Genre> Genre { get; set; } = default!;
    public DbSet<NTCuong_Day6_Movie.Models.Movie> Movie { get; set; } = default!;
}
