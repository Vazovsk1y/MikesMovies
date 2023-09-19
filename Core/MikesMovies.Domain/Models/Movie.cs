using MikesMovies.Domain.Common;

namespace MikesMovies.Domain.Models;

#nullable disable

public class Movie : Entity<MovieId>
{
    public DirectorId DirectorId { get; init; }

    public Director DirectedBy { get; set; }

    public string Title { get; set; }

    public string Annotation { get; set; }

    public DateOnly ReleaseDate { get; set; }

    public ICollection<WishList> WishLists { get; set; } = new List<WishList>();

    public ICollection<SeenList> SeenLists { get; set; } = new List<SeenList>();

    public ICollection<Actor> Cast { get; set; } = new List<Actor>();

    public ICollection<Review> Reviews { get; set; } = new List<Review>();

    public Movie() : base() { }
}

public record MovieId(Guid Value) : IValueId<MovieId>
{
    public static MovieId Create() => new(Guid.NewGuid());
}


