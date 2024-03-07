namespace Bank;

public interface ICalculateBonusesForDeposits
{
    decimal CalculateBonus(decimal currentBalance, decimal amountToDeposit);
}