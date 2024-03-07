

using Bank;
using NSubstitute;

namespace Banking.UnitTests.Accounts;
public class GoldCustomerDeposits
{
    [Fact]
    public void MakingADespositIncreasesBalance()
    {
        // Given
        var amountToDeposit = 142.23M;
        var expectedBonus = 13.23M;
        var stubbedBonusCalculator = Substitute.For<ICalculateBonusesForDeposits>();
        var account = new BankAccount(stubbedBonusCalculator);
        var openingBalance = account.GetBalance();
        stubbedBonusCalculator.CalculateBonus(openingBalance, amountToDeposit).Returns(expectedBonus);

        // When
        // WTCYWYH 
        // Command - Telling it to do some work.
        account.Deposit(amountToDeposit);

        // Then
        Assert.Equal(openingBalance + amountToDeposit + expectedBonus, account.GetBalance());
    }
}
