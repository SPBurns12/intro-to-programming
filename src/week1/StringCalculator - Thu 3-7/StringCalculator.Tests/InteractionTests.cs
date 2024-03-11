using NSubstitute;

namespace StringCalculator.Tests;
public class InteractionTests
{
    [Theory]
    [InlineData("1,2", "3")]
    [InlineData("42", "42")]
    public void ResultIsLogged(string numbers, string expected)
    {
        // given
        var mockedLogger = Substitute.For<ILogger>();
        var calculator = new Calculator(mockedLogger, Substitute.For<IWebService>());
        // when
        calculator.Add(numbers);
        // then
        mockedLogger.Received().Write(expected);
    }

    [Fact]
    public void WhenTheLoggerCrashesYouCallAWebService()
    {
        // given
        var mockedLogger = Substitute.For<ILogger>();
        var mockedService = Substitute.For<IWebService>();
        mockedLogger.When(s => s.Write("10")).Throw<LoggerException>();
        var calculator = new Calculator(mockedLogger, mockedService);
        // when
        calculator.Add("10");
        // then
        mockedService.Received().NotifyOfLoggingError("Logger Failure 10");
    }
}
