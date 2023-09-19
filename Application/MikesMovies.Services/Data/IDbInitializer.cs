namespace MikesMovies.Services.Data;

public interface IDbInitializer
{
    Task InitializeAsync(CancellationToken cancellationToken = default);
}
