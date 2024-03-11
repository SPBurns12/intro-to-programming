
using Bank;
using NSubstitute;

namespace Banking.UnitTests.BusinessClock;
public class StandardBusinessClockTests
{
    [Fact]
    public void WeAreClosed()
    {
        // You can substitute interfaces, virtual methods, and abstract classes with abstract methods.


        var fakeClock = Substitute.For<IClock>();
        fakeClock.GetCurrentLocalTime().Returns(new DateTime(2024, 3, 7, 17, 00, 00));
        var clock = new StandardBusinessClock(fakeClock);

        Assert.False(clock.IsOpen());
    }
    [Fact]
    public void WeAreOpen()
    {
        var fakeClock = Substitute.For<IClock>();
        fakeClock.GetCurrentLocalTime().Returns(new DateTime(2024, 3, 7, 16, 59, 59));
        var clock = new StandardBusinessClock(fakeClock);
        Assert.True(clock.IsOpen());
    }
}
