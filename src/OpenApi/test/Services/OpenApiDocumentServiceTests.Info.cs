using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.OpenApi;
using Microsoft.Extensions.Hosting.Internal;
using Moq;

public partial class OpenApiDocumentServiceTests
{
    [Fact]
    public async Task GetOpenApiInfo_RespectsHostEnvironmentName()
    {
        // Arrange
        var hostEnvironment = new HostingEnvironment
        {
            ApplicationName = "TestApplication"
        };
        var docService = new OpenApiDocumentService("v1", hostEnvironment);

        // Act
        var document = await docService.GetOpenApiDocumentAsync();

        // Assert
        Assert.Equal("TestApplication | v1", document.Info.Title);
    }
}
