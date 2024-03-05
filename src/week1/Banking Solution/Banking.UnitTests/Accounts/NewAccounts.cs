using Bank;

namespace Banking.UnitTests.Accounts;

public class NewAccounts
{
    [Fact]
    public void NewAvvountsHaveCorrectOpeningBalance()
    {
        // WTCYWYH - write the code you wish you had

        // Given
        var account = new BankAccount();

        // When
        decimal openingBalance = account.GetBalance();

        // Then
        Assert.Equal(5000M, openingBalance);
    }
}
