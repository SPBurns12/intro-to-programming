

namespace Bank;
public class AdvancedBonusCalculator(IProvideTheBusinessClock clock) : ICalculateBonusesForDeposits
{
    public decimal CalculateBonus(decimal currentBalance, decimal amountToDeposit)
    {
        // if between 9am and 5pm, not weekend, not holiday
        // and if current balance at least 5000
        // then return bonus of 10%
        // else return nothing

        if (clock.IsOpen() && currentBalance >= 5000)
        {
            return amountToDeposit * .10M;
        }

        return 0;
    }
}
