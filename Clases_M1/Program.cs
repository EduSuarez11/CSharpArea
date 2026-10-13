namespace Classes_M1;

class Program
{
    public static void Main(string[] args)
    {

        string firstName = "David";
        string lastName = "Pérez";
        //string customerIdNumber = "3030303030";

        BankCustomer customer1 = new BankCustomer();

        firstName = "Sandy";

        BankCustomer customer2 = new BankCustomer(firstName, lastName);
        
        firstName = "Juan";
        lastName = "Pascual";
        //customerIdNumber = "4040404040";
        BankCustomer customer3 = new BankCustomer(firstName, lastName);

        Console.WriteLine($"BankCustomer 1: {customer1.firstName} {customer1.lastName} {customer1.customerId}");
        Console.WriteLine($"BankCustomer 2: {customer2.firstName} {customer2.lastName} {customer2.customerId}");
        Console.WriteLine($"BankCustomer 3: {customer3.firstName} {customer3.lastName} {customer3.customerId}");

    }
}
