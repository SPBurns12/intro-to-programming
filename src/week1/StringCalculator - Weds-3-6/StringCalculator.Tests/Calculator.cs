
namespace StringCalculator.Tests;
public class Calculator
{
    public int Add(string numbers)
    {
        if (numbers == "") return 0;
        var delimeters = new List<char> { ',', '\n' };
        if (numbers.StartsWith("//"))
        {   // "//;\n1;2"
            delimeters.Add(numbers[2]);
            numbers = numbers[4..];
        }

        return numbers.Split(delimeters.ToArray()).Select(int.Parse).Sum();
    }
}
