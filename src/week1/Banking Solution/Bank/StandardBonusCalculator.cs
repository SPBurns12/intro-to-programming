﻿

namespace Bank;
public class StandardBonusCalculator : ICalculateBonusesForDeposits
{
    public decimal CalculateBonus(decimal balance, decimal amountOfDeposit)
    {
        return balance >= 5000M ? amountOfDeposit * .15M : 0;
    }
}
