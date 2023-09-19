using MikesMovies.Domain.Common;

namespace MikesMovies.Domain.Models;

#nullable disable

public class WishList : Entity<WishListId>
{
    public UserId UserId { get; init; }

    public ICollection<Movie> Movies { get; set; } = new List<Movie>();

    public WishList() : base() { }
}

public record WishListId(Guid Value) : IValueId<WishListId>
{
    public static WishListId Create() => new(Guid.NewGuid());
}
