using Microsoft.EntityFrameworkCore;
using MikesMovies.Domain.Models;

namespace MikesMovies.Services.Data;

public interface IApplicationDbContext
{
    DbSet<Movie> Movies { get; set; }

    DbSet<WishList> WishLists { get; set; }

    DbSet<SeenList> SeenLists { get; set; }

    DbSet<Review> Reviews { get; set; }

    DbSet<User> Users { get; set; }

    DbSet<Director> Directors { get; set; }

    DbSet<Actor> Actors { get; set; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}
