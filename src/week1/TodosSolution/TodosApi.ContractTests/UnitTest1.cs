namespace TodosApi.ContractTests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        // Given
        int a = 10, b = 20, answer;

        // When
        answer = a + b;

        // Then
        Assert.Equal(30, answer);
    }

    [Theory]
    [InlineData(10, 20, 30)]
    [InlineData(2, 2, 4)]
    public void CanAddIntegers(int a, int b, int expected)
    {
        int answer = a + b;

        Assert.Equal(expected, answer);
    }
}