

using Bank;

namespace Banking.UnitTests.Accounts;
public class MakingWithdrawls
{
    [Theory]
    [InlineData(100)]
    [InlineData(46.59)]
    [InlineData(1)]
    [InlineData(4453)]
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

        Assert.Throws<OverdraftException>(() => account.Withdraw(openingBalance + 1));
        Assert.Equal(openingBalance, account.GetBalance());
    }

    [Theory]
    [InlineData(-123.45)]
    [InlineData(0)]
    public void ValidateAmountsForWithdrawl(decimal amount)
    {
        var account = new BankAccount();
        var openingBalance = account.GetBalance();

        Assert.Throws<InvalidTransactionAmountException>(() => account.Withdraw(amount));
        Assert.Equal(openingBalance, account.GetBalance());
    }

    [Fact]
    public void CanWithdrawAllMoney()
    {
        var account = new BankAccount();
        var openingBalance = account.GetBalance();

        account.Withdraw(openingBalance);

        Assert.Equal(0, account.GetBalance());
    }
}
