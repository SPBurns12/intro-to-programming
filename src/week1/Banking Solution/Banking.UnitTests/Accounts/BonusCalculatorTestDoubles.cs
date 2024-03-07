

using Bank;

namespace Banking.UnitTests.Accounts;

// just an object that takes the place of something real, but has no logic, doesn't pass or fail the test, any of that kind of thing
public class DummyBonusCalculator : ICalculateBonusesForDeposits
{
    public decimal CalculateBonus(decimal currentBalance, decimal amountToDeposit)
    {
        return 0;
    }
}

public class StubbedBonusCalculator : ICalculateBonusesForDeposits
{
    public decimal CalculateBonus(decimal currentBalance, decimal amountToDeposit)
    {
        return currentBalance == 5000M && amountToDeposit == 142.23M ? 13.23M : 0;
    }
}