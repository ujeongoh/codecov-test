namespace CodeCoverageTest.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        // 간단한 덧셈 테스트
        int a = 2;
        int b = 3;
        int sum = a + b;
        Assert.Equal(5, sum);
    }

    [Fact]
    public void Add_ReturnsCorrectSum()
    {
        int result = CodeCoverageTest.MathUtil.Add(10, 20);
        Assert.Equal(30, result);
    }

    [Fact]
    public void CelsiusToFahrenheit_ReturnsCorrectValue()
    {
        // 0도C -> 32도F
        Assert.Equal(32, CodeCoverageTest.WeatherUtil.CelsiusToFahrenheit(0));
        // 100도C -> 212도F
        Assert.Equal(212, CodeCoverageTest.WeatherUtil.CelsiusToFahrenheit(100));
        // -40도C -> -40도F
        Assert.Equal(-40, CodeCoverageTest.WeatherUtil.CelsiusToFahrenheit(-40));
    }
}
