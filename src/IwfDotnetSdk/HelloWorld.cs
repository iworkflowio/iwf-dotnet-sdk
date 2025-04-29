using IwfDotnetSdk.ApiClients.Model;

namespace IwfDotnetSdk;

public class HelloWorld
{
    public string Hello()
    {
        return $"Hello, World! Timer status can be: {TimerStatus.SCHEDULED} or {TimerStatus.FIRED}";
    }
}