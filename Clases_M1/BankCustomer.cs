using System;

namespace Classes_M1;

class BankCustomer
{
    public string firstName = "Kike";
    public string lastName = "Rodríguez";
    public readonly string customerId = "1010101010";
    private static int s_nextCustomerId;


    public BankCustomer()
    {
        //Console.WriteLine("BankCustomer creado");
        customerId = s_nextCustomerId++.ToString("D10");
    }


    public BankCustomer(string firstName, string lastName)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        customerId = s_nextCustomerId++.ToString("D10");
        //Console.WriteLine($"BankCustomer creado: {firstName} {lastName}");
    }


    // public BankCustomer(string firstName, string lastName, string customerId)
    // {
    //     this.firstName = firstName;
    //     this.lastName = lastName;
    //     this.customerId = customerId;
    // }


    static BankCustomer()
    {
        Random random = new Random();
        s_nextCustomerId = random.Next(1000000000, 2000000000);
    }


}
