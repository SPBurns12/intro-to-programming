

namespace StringCalculator.Tests;
public class Calculator
{
    public int Add(string numbers)
    {
        if (numbers.Length == 0)
        {
            return 0;
        }

        char[] delimiters = [',', '\n'];

        if (numbers.Contains("//"))
        {
            delimiters = delimiters.Append(numbers[2]).ToArray();
            numbers = numbers.Substring(4);
        }

        string[] numberArray = numbers.Split(delimiters);

        int sum = 0;
        foreach (string number in numberArray)
        {
            if (number.Length == 0)
            {
                throw new DelimiterFormatException();
            }

            sum += int.Parse(number);
        }

        return sum;
    }
}
