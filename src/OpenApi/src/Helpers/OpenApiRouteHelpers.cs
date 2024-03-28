internal static class OpenApiRouteHelpers
{
    /// <summary>
    /// Maps the relative path included in the ApiDescription to the path
    /// that should be included in the OpenApiDocument. This typically
    /// consists of removing any constraints from route parameter parts
    /// and retaining only the literals.
    /// </summary>
    /// <param name="relativePath"></param>
    /// <returns></returns>
    private static string MapRelativePathToItemPath(this string relativePath)
    {
        var strippedRoute = new StringBuilder();
        var routePattern = RoutePatternFactory.Parse(relativePath);
        foreach (var segment in routePattern.PathSegments)
        {
            foreach (var part in segment.Parts)
            {
                if (part is RoutePatternLiteralPart literalPart)
                {
                    strippedRoute.Append(literalPart.Content);
                }
                else if (part is RoutePatternParameterPart parameterPart)
                {
                    strippedRoute.Append('{');
                    strippedRoute.Append(parameterPart.Name);
                    strippedRoute.Append('}');
                }
            }
            strippedRoute.Append('/');
        }
        return strippedRoute.ToString();
    }
}
