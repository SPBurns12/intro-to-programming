



namespace Bank;

public class BankAccount(ICalculateBonusesForDeposits bonusCalculator)
{

    private decimal _currentBalance = 5000M;
    public void Deposit(decimal amountToDeposit)
    {


        GuardTransactionAmount(amountToDeposit);

        // WTCAWHH (variation of the Write the Code You Wish You Had)
        decimal bonus = bonusCalculator.CalculateDepositBonusFor(_currentBalance, amountToDeposit);
        _currentBalance += amountToDeposit + bonus;
    }


    private void GuardTransactionAmount(decimal transactionAmount)
    {
        // Never type Private, always refactor to it.
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