using MikesMovies.Domain.Common;

namespace MikesMovies.Domain.Models;

#nullable disable

public class Director : Entity<DirectorId>
{
    public string Name { get; set; }

    public string LastName { get; set; }

    public ICollection<Movie> Movies { get; set; } = new List<Movie>();

    public Director() : base() { }
}

public record DirectorId(Guid Value) : IValueId<DirectorId>
{
    public static DirectorId Create() => new(Guid.NewGuid());
}

