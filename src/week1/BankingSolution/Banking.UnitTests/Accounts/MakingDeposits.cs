
using Bank;

namespace Banking.UnitTests.Accounts;
public class MakingDeposits
{
    [Theory]
    [InlineData(100)]
    [InlineData(42.23)]
    public void MakingADespositIncreasesBalance(decimal amountToDeposit)
    {
        // Given
        var account = new BankAccount(new DummyBonusCalculator());
        // Get Balance is a "Query" - we are asking it for something.
        var openingBalance = account.GetBalance();

        // When
        // WTCYWYH 
        // Command - Telling it to do some work.
        account.Deposit(amountToDeposit);

        // Then
        Assert.Equal(openingBalance + amountToDeposit, account.GetBalance());
    }
}
