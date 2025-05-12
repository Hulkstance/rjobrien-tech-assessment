namespace RJO.TechAssessment.Api.Models;

public class ProductInfo
{
    public required string Title { get; init; }
    public required decimal Price { get; init; }
    public required string[] Sizes { get; init; }
    public required string Description { get; init; }
}
