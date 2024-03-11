
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
    [InlineData("420", 420)]
    public void SingleDigit(string numbers, int expected)
    {
        var calculator = new Calculator();

        var result = calculator.Add(numbers);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("1,2", 3)]
    [InlineData("108,2", 110)]
    [InlineData("1,99", 100)]

    public void TwoDigitsComma(string numbers, int expected)
    {
        var calculator = new Calculator();

        var result = calculator.Add(numbers);
        Assert.Equal(expected, result);
    }
    [Theory]
    [InlineData("1\n2", 3)]
    [InlineData("10\n2", 12)]

    public void TwoDigitsNewLine(string numbers, int expected)
    {
        var calculator = new Calculator();

        var result = calculator.Add(numbers);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("1,2,3,4,5,6,7,8,9", 45)]
    [InlineData("1\n2,3", 6)]
    public void Arbitrary(string numbers, int expected)
    {
        var calculator = new Calculator();

        var result = calculator.Add(numbers);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("//;\n1;2", 3)]
    [InlineData("//;\n1;2;3", 6)]
    [InlineData("//X\n1X2", 3)]
    [InlineData("//X\n1X2\n3,1", 7)]
    public void CustomDelimeter(string numbers, int expected)
    {
        var calculator = new Calculator();

        var result = calculator.Add(numbers);
        Assert.Equal(expected, result);
    }

}
