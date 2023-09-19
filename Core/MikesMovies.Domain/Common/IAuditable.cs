namespace MikesMovies.Domain.Common;

public interface IAuditable : IEntity
{
    DateTime CreatedDate { get; init; }
    DateTime? ModifiedDate { get; set; }
}
