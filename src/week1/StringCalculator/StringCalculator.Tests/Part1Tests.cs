
// https://osherove.com/tdd-kata-1

namespace StringCalculator.Tests;
public class Part1Tests
{
    [Fact]
    public void EmptyStringReturnsZero()
    {
        var calculator = new Calculator();

        var result = calculator.Add("");

        Assert.Equal(0, result);
    }

    [Theory]
    [InlineData("1", 1)]
    [InlineData("15", 15)]
    [InlineData("721", 721)]
    [InlineData("0", 0)]
    public void OneNumberStringReturnsSameNumber(string numberString, int numberInt)
    {
        var calculator = new Calculator();

        var result = calculator.Add(numberString);

        Assert.Equal(numberInt, result);
    }
}
