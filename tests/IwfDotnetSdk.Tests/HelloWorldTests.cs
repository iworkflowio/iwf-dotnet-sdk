using IwfDotnetSdk.ApiClients.Model;

namespace IwfDotnetSdk.Tests;

public class HelloWorldTests
{
    [Fact]
    public void Hello_ReturnsHelloWorldWithTimerStatus()
    {
        // Arrange
        var helloWorld = new HelloWorld();
        
        // Act
        var result = helloWorld.Hello();
        
        // Assert
        Assert.Contains("Timer status can be:", result);
        Assert.Contains(TimerStatus.SCHEDULED.ToString(), result);
        Assert.Contains(TimerStatus.FIRED.ToString(), result);
    }
}