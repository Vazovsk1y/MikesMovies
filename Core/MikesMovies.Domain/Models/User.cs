using MikesMovies.Domain.Common;

namespace MikesMovies.Domain.Models;

#nullable disable

public class User : Entity<UserId>
{
    public string Login { get; set; }

    public string Password { get; set; }

    public WishList WishList { get; set; }

    public SeenList SeenList { get; set; }

    public ICollection<Review> Reviews { get; set; } = new List<Review>();

    public User() : base() { }
}

public record UserId(Guid Value) : IValueId<UserId>
{
    public static UserId Create() => new(Guid.NewGuid());
}