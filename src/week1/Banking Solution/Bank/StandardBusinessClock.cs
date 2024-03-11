

namespace Bank;
public class StandardBusinessClock(IClock clock) : IProvideTheBusinessClock
{
    public bool IsOpen()
    {
        var now = clock.GetCurrentLocalTime();

        if (now.Hour >= 9 && now.Hour < 17)
        {
            return true;
        }

        return false;
    }
}
