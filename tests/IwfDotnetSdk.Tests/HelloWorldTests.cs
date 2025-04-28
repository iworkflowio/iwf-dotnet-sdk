namespace IwfDotnetSdk.Tests;

public class HelloWorldTests
{
    [Fact]
    public void Hello_ReturnsHelloWorld()
    {
        // Arrange
        var helloWorld = new HelloWorld();
        
        // Act
        var result = helloWorld.Hello();
        
        // Assert
        Assert.Equal("Hello, World!", result);
    }
}