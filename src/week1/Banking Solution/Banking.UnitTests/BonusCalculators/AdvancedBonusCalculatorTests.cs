using Bank;
using NSubstitute;

namespace Banking.UnitTests.BonusCalculators;
public class AdvancedBonusCalcaulatorTests
{
    [Fact]
    public void DuringBusinessHoursWithAdequateBalance()
    {
        var stubbedClock = Substitute.For<IProvideTheBusinessClock>();
        stubbedClock.IsOpen().Returns(true);
        var calcuator = new AdvancedBonusCalculator(stubbedClock);

        var bonus = calcuator.CalculateBonus(5000, 100);

        Assert.Equal(10, bonus);
    }

    [Fact]
    public void DuringBusinessHoursWithInadequateBalance()
    {
        var stubbedClock = Substitute.For<IProvideTheBusinessClock>();
        stubbedClock.IsOpen().Returns(false);
        var calcuator = new AdvancedBonusCalculator(stubbedClock);

        var bonus = calcuator.CalculateBonus(4999.99M, 100);

        Assert.Equal(0, bonus);
    }

    [Fact]
    public void WhenWeAreClosed()
    {
        var stubbedClock = Substitute.For<IProvideTheBusinessClock>();
        stubbedClock.IsOpen().Returns(false);
        var calcuator = new AdvancedBonusCalculator(stubbedClock);

        var bonus = calcuator.CalculateBonus(5000, 100);

        Assert.Equal(0, bonus);
    }
}