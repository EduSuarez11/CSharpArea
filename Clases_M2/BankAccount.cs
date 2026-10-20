using System;

namespace Classes_M2;

public class BankAccount
{
    private static int s_nextAccountNumber;
    public int AccountNumber { get; }
    public double Balance { get; private set; } = 0;
    public static double InterestRate;
    public string AccountType { get; set; } = "Checking";
    public string CustomerId { get; }

    static BankAccount()
    {
        Random random = new Random();
        s_nextAccountNumber = random.Next(10000000, 20000000);
        InterestRate = 0.12;
    }

    public BankAccount(string customerIdNumber)
    {
        this.AccountNumber = s_nextAccountNumber++;
        this.CustomerId = customerIdNumber;
    }

    public BankAccount(string customerIdNumber, double balance, string accountType)
    {
        this.AccountNumber = s_nextAccountNumber++;
        this.CustomerId = customerIdNumber;
        this.Balance = balance;
        this.AccountType = accountType;
    }

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            Balance += amount;
        }
    }

    public bool RetiredMoney(double amount)
    {
        if (amount > 0 && Balance >= amount)
        {
            Balance -= amount;
            return true;
        }
        return false;
    }

    public bool Transfer(BankAccount targetAccount, double amount)
    {
        if (RetiredMoney(amount))
        {
            targetAccount.Deposit(amount);
            targetAccount.ApplyInterest();
            return true;
        }
        return false;
    }

    public void ApplyInterest()
    {
        Balance += Balance * InterestRate;
    }

    public string DisplayAccountInfo()
    {
        return $"Numero de cuenta: {AccountNumber}, Tipo: {AccountType}, Balance: {Balance}, Tasa de interés: {InterestRate}, Customer ID: {CustomerId}";
    }
}
