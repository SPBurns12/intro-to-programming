
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
    [InlineData("2", 2)]
    [InlineData("128", 128)]
    public void SingleDigits(string numbers, int expected)
    {
        var calculator = new Calculator();

        var result = calculator.Add(numbers);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("1,2", 3)]
    [InlineData("2,2", 4)]
    [InlineData("108,2", 110)]

    public void TwoDigits(string numbers, int expected)
    {
        var calculator = new Calculator();

        var result = calculator.Add(numbers);

        Assert.Equal(expected, result);
    }

        [Theory]
    [InlineData("1\n2", 3)]
    [InlineData("2\n2", 4)]
    [InlineData("108\n2", 110)]

    public void NewLine(string numbers, int expected)
    {
        var calculator = new Calculator();

        var result = calculator.Add(numbers);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("1,2,3,4,5,6,7,8,9", 45)]
    
    public void Arbitrary(string numbers, int expected)
    {
        var calculator = new Calculator();

        var result = calculator.Add(numbers);

        Assert.Equal(expected, result);
    }
}
