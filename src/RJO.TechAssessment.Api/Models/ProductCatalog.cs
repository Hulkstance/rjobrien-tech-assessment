namespace RJO.TechAssessment.Api.Models;

public class ProductCatalog
{
    public IReadOnlyCollection<ProductInfo> Products { get; init; } = [];
    public required ApiKeys ApiKeys { get; init; }
}
