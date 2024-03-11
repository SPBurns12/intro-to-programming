
using Bank;
using NSubstitute;

namespace Banking.UnitTests.Accounts;
public class GoldCustomerDeposits
{
    [Fact]
    public void MakingADespositIncreasesBalance()
    {
        // Given 
        var stubbedBonusCalculator = Substitute.For<ICalculateBonusesForDeposits>();
        var account = new BankAccount(stubbedBonusCalculator);
        var amountToDeposit = 142.23M;
        var expectedBonus = 13.23M;
        var openingBalance = account.GetBalance();
        stubbedBonusCalculator.CalculateDepositBonusFor(openingBalance, amountToDeposit).Returns(13.23M);
        // When
        // WTCYWYH 
        // Command - Telling it to do some work.
        account.Deposit(amountToDeposit);

        // Then
        //Assert.Equal(openingBalance + expected, account.GetBalance());
        // did the bonus calculator get called with the balance, and the amount to deposit.
        // did the bonus get added to the balance.

        Assert.Equal(openingBalance + amountToDeposit + expectedBonus, account.GetBalance());
    }
}
