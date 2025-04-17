using Wearemm.Catalog.Database;
using Wearemm.Catalog.Entities;

namespace Wearemm.Catalog.Features.Genres.CreateGenre;

public static class CreateGenreEndpoint
{
    public static void MapCreateGenreEndpoint(this IEndpointRouteBuilder routes)
    {
        routes.MapPost("/genres", async (CreateGenreRequest request, CatalogDbContext context) =>
        {
            var genre = new Genre
            {
                Name = request.Name
            };

            context.Genres.Add(genre);
            await context.SaveChangesAsync();

            return Results.Created($"/genres/{genre.Id}", genre);
        });
    }
}
