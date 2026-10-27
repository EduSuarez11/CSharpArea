
namespace BankApp;

// TASK 2: Define Enum, Struct, and Record types
public enum BankAccountType
{
    Checking,
    Savings,
    Business
}

public static class BankAccountTypeExtensions
{
    public static string GetDescription(this BankAccountType accountType)
    {
        return accountType switch
        {
            BankAccountType.Checking => "Una cuenta corriente estándar.",
            BankAccountType.Savings => "Una cuenta de ahorros con intereses.",
            BankAccountType.Business => "Una cuenta comercial para empresas.",
            _ => "Tipo de cuenta desconocido."
        };
    }

}


public readonly struct BankAccountNumber
{
    public string Value { get; }
    public BankAccountNumber(string value)
    {
        if (value is null || value.Length != 12 || !value.All(char.IsDigit)) throw new ArgumentException("Los números de cuenta deben tener 12 dígitos.");
        Value = value;
    }

    public override string ToString()
    {
        return Value;
    }

}

public record AccountHolderDetails(string Name, string CustomerId, string Address);

public record Transaction(decimal Amount, DateTime Date, string Description)
{
    public override string ToString()
    {
        return $"{Date:d}: {Description} - {Amount:C}";
    }
}


public class BankAccount
{
    public BankAccountNumber AccountNumber { get; }
    public BankAccountType AccountType { get;}
    public decimal Balance { get; private set; }
    public AccountHolderDetails? AccountHolder { get; }
    private List<Transaction> Transactions { get; } = new List<Transaction>();


    public BankAccount(BankAccountNumber accountNumber, BankAccountType type, AccountHolderDetails accountHolder, decimal balance)
    {
     AccountNumber = accountNumber;
     this.AccountType = type;
     AccountHolder = accountHolder;
     Balance = balance;
    }

    public void AddTransaction(decimal amount, string description)
    {
        Balance += amount;
        Transactions.Add(new Transaction(amount, DateTime.Now, description));
    }


    public string DisplayAccountInfo()
    {
        return $"Account Holder: {AccountHolder?.Name}, Account Number: {AccountNumber}, Type: {AccountType}, Balance: {Balance:C}";
    }

    public void DisplayTransactions()
    {
        Console.WriteLine("Transactions");
        foreach (Transaction transaction in Transactions)
        {
            Console.WriteLine($"{transaction}");
        }
    }
}
