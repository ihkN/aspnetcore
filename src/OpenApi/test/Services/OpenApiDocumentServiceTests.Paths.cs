
public partial class OpenApiDocumentServiceTests
{
    [Fact]
    public async Task GetOpenApiPaths_ReturnsPaths()
    {
        // Arrange
        var apiDescriptionGroupCollectionProvider = new Mock<IApiDescriptionGroupCollectionProvider>();
        var hostEnvironment = new HostingEnvironment { ApplicationName = "TestApplication" };
        var docService = new OpenApiDocumentService("v1", apiDescriptionGroupCollectionProvider.Object, hostEnvironment);

        // Act
        var document = await docService.GetOpenApiDocumentAsync();

        // Assert
        Assert.NotNull(document.Paths);
    }
}
