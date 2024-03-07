

using Bank;

namespace Banking.UnitTests.Accounts;
public class MakingDeposits
{
    [Theory]
    [InlineData(100)]
    [InlineData(42.50)]
    [InlineData(1)]
    [InlineData(594312)]
    public void MakingADepositIncreasesBalance(decimal amountToDeposit)
    {
        var account = new BankAccount(new DummyBonusCalculator());
        var openingBalance = account.GetBalance();

        account.Deposit(amountToDeposit);

        Assert.Equal(openingBalance + amountToDeposit, account.GetBalance());
    }
}
