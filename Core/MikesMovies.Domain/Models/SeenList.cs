using MikesMovies.Domain.Common;

namespace MikesMovies.Domain.Models;

#nullable disable

public class SeenList : Entity<SeenListId>
{
    public UserId UserId { get; init; }

    public ICollection<Movie> Movies { get; set; } = new List<Movie>();

    public SeenList() : base() { }
}

public record SeenListId(Guid Value) : IValueId<SeenListId>
{
    public static SeenListId Create() => new(Guid.NewGuid());
}
