using MikesMovies.Domain.Common;

namespace MikesMovies.Domain.Models;

#nullable disable

public class Actor : Entity<ActorId>
{
    public string Name { get; set; }

    public string LastName { get; set; }

    public ICollection<Movie> PlayedIn { get; set; } = new List<Movie>();

    public Actor() : base() { }
}

public record ActorId(Guid Value) : IValueId<ActorId>
{
    public static ActorId Create() => new(Guid.NewGuid());
}
