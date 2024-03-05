

using Bank;

namespace Banking.UnitTests.Accounts;
public class MakingWithdrawls
{
    [Theory]
    [InlineData(100)]
    [InlineData(46.59)]
    [InlineData(1)]
    [InlineData(8453)]
    public void MakingAWithdrawlDecreasesTheBalance(decimal amountToWithdraw)
    {
        var account = new BankAccount();
        var openingBalance = account.GetBalance();

        account.Withdraw(amountToWithdraw);

        Assert.Equal(openingBalance - amountToWithdraw, account.GetBalance());
    }

    [Fact]
    public void OverdraftNotAllowed()
    {
        var account = new BankAccount();
        var openingBalance = account.GetBalance();

        account.Withdraw(openingBalance + 1);

        Assert.Equal(openingBalance, account.GetBalance());
    }
}
