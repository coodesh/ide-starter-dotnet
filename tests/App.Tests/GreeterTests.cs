using App;

namespace App.Tests;

public class GreeterTests
{
    [Fact]
    public void CumprimentaPeloNome()
    {
        Assert.Equal("Olá, Ana!", Greeter.Greet("Ana"));
    }
}
