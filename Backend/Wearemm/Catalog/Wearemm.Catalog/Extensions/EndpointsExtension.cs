using Wearemm.Catalog.Features.Genres.CreateGenre;

namespace Wearemm.Catalog.Extensions;

public static class EndpointsExtension
{
    public static void MapEndpoints(this IEndpointRouteBuilder app)
    {
        app.MapCreateGenreEndpoint();
    }
}
