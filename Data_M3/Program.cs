namespace BankApp;

class Program
{
    static void Main(string[] args)
    {
        AccountHolderDetails customer1 = new AccountHolderDetails("Kike", "123", "Calle Luna 5");
        BankAccountNumber accountNumber = new BankAccountNumber("000012345678");

        BankAccount bankAccount = new BankAccount(accountNumber, BankAccountType.Checking, customer1, 500m);

        Console.WriteLine("TAREA 4: Mostrar información básica de la cuenta bancaria");
        Console.WriteLine($"Tipo de cuenta: {bankAccount.AccountType.GetDescription()}");
        Console.WriteLine(bankAccount.DisplayAccountInfo());


        bankAccount.AddTransaction(200m, "Depositar");
        bankAccount.AddTransaction(-50m, "Retiro en cajero automático");

        Console.WriteLine("\nTAREA 5: Demostrar el uso del registro de transacciones.");
        Console.WriteLine(bankAccount.DisplayAccountInfo());
        bankAccount.DisplayTransactions();

        AccountHolderDetails customer2 = new("Kike", "123", "Calle Luna 5");

        Console.WriteLine("\nTAREA 6: Demostrar la comparación de registros y la inmutabilidad de la estructura.");
        Console.WriteLine($"¿Son los clientes iguales? - {customer1 == customer2}");

        BankAccountNumber accountNumber2 = new BankAccountNumber("000123456789");
        Console.WriteLine($"Numero de cuenta original: {accountNumber2}");

        //accountNumber2.Value = "000987654321"; // Uncommenting this line will cause an error

    }
}