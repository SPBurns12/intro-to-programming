
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

    [Theory]
    [InlineData("1,1", 2)]
    [InlineData("1,0", 1)]
    [InlineData("21,15", 36)]
    [InlineData("100,120", 220)]
    public void TwoNumberStringReturnsSum(string numberString, int numberInt)
    {
        var calculator = new Calculator();

        var result = calculator.Add(numberString);

        Assert.Equal(numberInt, result);
    }

    [Theory]
    [InlineData("1,1,1", 3)]
    [InlineData("1,0,5,5,5,5,5", 26)]
    [InlineData("21,15,4", 40)]
    [InlineData("100,120,0,0,0,0,0", 220)]
    public void ManyNumberStringReturnsSum(string numberString, int numberInt)
    {
        var calculator = new Calculator();

        var result = calculator.Add(numberString);

        Assert.Equal(numberInt, result);
    }

    [Theory]
    [InlineData("1\n1\n1", 3)]
    [InlineData("1,0\n5,5\n5,5\n5", 26)]
    [InlineData("21,15\n4", 40)]
    [InlineData("100\n120\n0,0,0\n0\n0", 220)]
    public void ManyNumberStringSeparatedWithNewLineReturnsSum(string numberString, int numberInt)
    {
        var calculator = new Calculator();

        var result = calculator.Add(numberString);

        Assert.Equal(numberInt, result);
    }

    [Theory]
    [InlineData("1,\n1,\n1")]
    [InlineData("1,0,,\n5,5\n5,5\n5")]
    [InlineData("21,15\n,4")]
    [InlineData("100\n120\n0,,,0,0\n0\n0")]
    public void MultipleDelimitersNextToEachOtherThrowException(string numberString)
    {
        var calculator = new Calculator();

        Assert.Throws<DelimiterFormatException>(() => calculator.Add(numberString));
    }

    [Theory]
    [InlineData("1,\n1,\n1\n")]
    [InlineData("1,0,,\n5,5\n5,5\n5,,,,,,,")]
    public void DelimitersAtEndOfStringThrowException(string numberString)
    {
        var calculator = new Calculator();

        Assert.Throws<DelimiterFormatException>(() => calculator.Add(numberString));
    }

    [Theory]
    [InlineData("//F\n1F1\n1", 3)]
    [InlineData("//.\n1.0.5,5.5,5.5", 26)]
    public void CustomDelimiterUsageReturnsSumOfNumbers(string numberString, int numberInt)
    {
        var calculator = new Calculator();

        var result = calculator.Add(numberString);

        Assert.Equal(numberInt, result);
    }
}
