// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var account = new BankAccount();


account.Deposit(100M);
account.Deposit(200M);

foreach (var h in account.GetDepositHistory())
{


    Console.WriteLine($"On {h.DepositedOn} you deposited {h.Amount:c}");
}




var s1 = new Student { FirstName = "Joe", LastName = "Schmidt" };
var s2 = new Student { FirstName = "Joe", LastName = "Schmidt" };

Console.WriteLine(s1.ToString());
var areTheSame = s1 == s2;

//var newJoe = new Student { FirstName = "Joseph", LastName = s1.LastName };
var newJoe = s1 with { FirstName = "Joseph" };
Console.WriteLine(newJoe);
Console.WriteLine("They are the same? " + areTheSame);

public class BankAccount
{
    private List<DepositRecord> depositRecords = new();

    public int Id { get; set; }

    // properties:
    // should not throw exceptions.
    // should not involve "compute" - like there is no Async stuff for this.
    // should return the same value for every "get" after it is set.

    public string FirstName { get; set; } = string.Empty;
    public decimal Balance { get; private set; } = 5000;

    public void Deposit(decimal amount)
    {
        var dr = new DepositRecord(amount, DateTime.Now);

        depositRecords.Add(dr);
        Balance += amount;
    }

    public IEnumerable<DepositRecord> GetDepositHistory()
    {
        return depositRecords;
    }
}

public record DepositRecord(decimal Amount, DateTime DepositedOn);

public record Student
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
}