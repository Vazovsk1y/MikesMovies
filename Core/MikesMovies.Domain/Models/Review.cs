using MikesMovies.Domain.Common;

namespace MikesMovies.Domain.Models;

#nullable disable

public class Review : Entity<ReviewId>, IAuditable
{
    public UserId UserId { get; init; }

    public MovieId MovieId { get; init; }

    public DateTime CreatedDate { get; init; }

    public double Evaluation { get; set; }

    public string Text { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public Review() : base() { }
}

public record ReviewId(Guid Value) : IValueId<ReviewId>
{
    public static ReviewId Create() => new(Guid.NewGuid());
}

