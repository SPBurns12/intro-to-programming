namespace Bank;

public class BankAccount
{
    private decimal _currentBalance = 5000M;
    public void Deposit(decimal amountToDeposit)
    {
        // Never type Private, always refactor to it.
        GuardTransactionAmount(amountToDeposit);
        _currentBalance += amountToDeposit;
    }

    private static void GuardTransactionAmount(decimal transactionAmount)
    {
        if (transactionAmount <= 0)
        {
            throw new InvalidTransactionAmountException();
        }
    }

    public decimal GetBalance()
    {
        return _currentBalance;
    }

    public void Withdraw(decimal amountToWithdraw)
    {
        if (amountToWithdraw > _currentBalance)
        {
            throw new OverdraftException();
        }
        GuardTransactionAmount(amountToWithdraw);
        _currentBalance -= amountToWithdraw;
    }
    // Overloaded the Withdraw
    public void Withdraw(Money money)
    {

        _currentBalance -= money.Amount;
    }
}

public class Money
{
    public decimal Amount { get; private set; }
    public Currency Currency { get; private set; }
    private Money() { }
    public static Money FromUsd(decimal amount)
    {
        if (amount < 0)
        {
            throw new Exception();
        }
        return new Money { Amount = amount, Currency = Currency.USD };
    }
}
public enum Currency { USD, EUR, YEN };