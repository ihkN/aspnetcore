using Microsoft.AspNetCore.Mvc.ApiExplorer;

namespace Microsoft.AspNetCore.OpenApi;

/// <summary>
/// Represents the context in which an OpenAPI operation transformer is executed.
/// </summary>
public sealed class OpenApiOperationTransformerContext
{
    /// <summary>
    /// Gets the name of the associated OpenAPI document.
    /// </summary>
    public required string DocumentName { get; init; }

    /// <summary>
    /// Gets the API description associated with current document.
    /// </summary>
    public required ApiDescription Description { get; init; }

    /// <summary>
    /// Gets the application services associated with current document.
    /// </summary>
    public required IServiceProvider ApplicationServices { get; init; }
}
