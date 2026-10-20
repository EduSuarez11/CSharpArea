using Classes_M2;

namespace ProgramClasesM2;
class Program
{
    public static void Main()
    {
        string firstName = "Kike";
        string lastName = "Rodríguez";
        //string customerIdNumber = "3030303030";

        /**
        Crear objetos BankCustomer.
        Cree objetos BankAccount para los clientes instanciados.
        Demuestre el uso de las propiedades de BankCustomer. Por ejemplo, actualice el nombre del cliente.
        Demuestra el uso de los métodos de Cuenta Bancaria. Por ejemplo, depositar, retirar, transferir, aplicar intereses.
        Demuestra el uso de métodos de extensión. Por ejemplo, saluda al cliente, verifica si el ID del cliente es válido, comprueba si la cuenta está en descubierto y verifica si se puede retirar una cantidad específica.
        Muestra la información del cliente y de la cuenta mediante los métodos DisplayCustomerInfo y DisplayAccountInfo. Estos métodos están 
        definidos en las clases BankCustomer y BankAccount, respectivamente.
        */

        // BankCustomers
        BankCustomer customer1 = new BankCustomer(firstName, lastName);
        BankCustomer customer2 = new BankCustomer("Juan", "Pérez");
        //customerIdNumber = "4040404040";
        firstName = "Tim";
        lastName = "Shao";
        BankCustomer customer3 = new BankCustomer(firstName, lastName);

        customer3.UpdateName("Tom", "Stones");
        Console.WriteLine($"{customer1.GreetCustomer()}. Tus datos - Customer 1: {customer1.ReturnFullName()} {customer1.CustomerId}");
        Console.WriteLine($"{customer2.GreetCustomer()}. Tus datos - Customer 2: {customer2.ReturnFullName()} {customer2.CustomerId}");
        Console.WriteLine($"{customer3.GreetCustomer()}. Tus datos - Customer 3: {customer3.ReturnFullName()} {customer3.CustomerId}");


        // BankAccounts
        BankAccount account1 = new BankAccount(customer1.CustomerId);
        BankAccount account2 = new BankAccount(customer2.CustomerId, 1500, "Checking");
        BankAccount account3 = new BankAccount(customer3.CustomerId, 3000, "Checking");

        Console.WriteLine($"Account 1: {account1.DisplayAccountInfo()} | Customer es válido - {customer1.IsValidCustomerId()}");
        Console.WriteLine($"Account 2: {account2.DisplayAccountInfo()} | Customer es válido - {customer2.IsValidCustomerId()}");
        Console.WriteLine($"Account 3: {account3.DisplayAccountInfo()} | Customer es válido - {customer3.IsValidCustomerId()}");
        
        // Depositar dinero
        account1.Deposit(1000);
        Console.WriteLine($"La cuenta {account1.AccountNumber} ha depositado dinero");

        // Retirar dinero
        if (account3.RetiredMoney(250))
        {
            Console.WriteLine($"La cuenta {account3.AccountNumber} ha retirado dinero");
        } else
        {
            Console.WriteLine("Saldo insuficiente");
        }

        if(account2.Transfer(account1, 750))
        {
            Console.WriteLine($"La cuenta {account2.AccountNumber} ha transferido dinero a la cuenta {account1.AccountNumber}");       
        }
        
        // Console.WriteLine($"Update BankCustomer1: {customer1.FirstName} {customer1.LastName} {customer1.CustomerId}");
        Console.WriteLine($"Account 1: {account1.DisplayAccountInfo()} | Balance de cuenta: {account1.IsPositive()} |\nPosibilidad de retiro de dinero: {account1.CanRetired(10000)}");
        Console.WriteLine($"Account 2: {account2.DisplayAccountInfo()} | Balance de cuenta: {account2.IsPositive()} |\nPosibilidad de retiro de dinero: {account2.CanRetired(100)}");
        Console.WriteLine($"Account 3: {account3.DisplayAccountInfo()} | Balance de cuenta: {account3.IsPositive()} |\nPosibilidad de retiro de dinero: {account3.CanRetired(450)}");
    }
}
        