using System;


namespace Classes_M2;


public static class BankCustomerExtensions
{
    public static bool IsValidCustomerId(this BankCustomer customer)
    {
        return customer.CustomerId.Length == 10;
    }

    public static string GreetCustomer(this BankCustomer customer)
    {
        return $"Hola, {customer.ReturnFullName()}";
    }
}

public static class BankAccountExtensions
{
    public static bool IsPositive(this BankAccount account)
    {
        return account.Balance < 0;
    }

    // Extension method to check if a specified amount can be withdrawn
    public static bool CanRetired(this BankAccount account, double amount)
    {
        return account.Balance >= amount;
    }
}
