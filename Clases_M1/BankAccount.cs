using System;
namespace Classes_M1;

class BankAccount
{
    public int accountNumber;
    public double balance;
    public static double interestRate;
    public string accountType = "Checking";
    public readonly string customerId;
    private static int s_nextAccountNumber;

    static BankAccount()
    {
        Random random = new Random();
        s_nextAccountNumber = random.Next(1000000000, 2000000000);
        interestRate = 0;
    }

    public BankAccount(string customerId)
    {
        accountNumber = s_nextAccountNumber++;
        this.customerId = customerId;
    }


    public BankAccount(string customerId, double balance, string accountType)
    {
        accountNumber = s_nextAccountNumber++;
        this.customerId = customerId;
        this.balance = balance;
        this.accountType = accountType;
    }

}