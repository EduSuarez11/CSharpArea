namespace ProyectoNameSpace;

class Program
{
    public static void Main(string[] args)
    {
        //Person person = new("Juan", 24);

        Person person1 = new Person { Nombre = "Kike" };
        //person1.ChangeEdad(30);
        //Console.WriteLine($"Persona 0: {person.Nombre}, {person.Edad} | Persona 1: {person1.Nombre}, {person1.Edad}");
        //Console.WriteLine($"Persona con nombre {person.GetNombre()} y tiene {person.GetEdad()} años | multiplicador {person1.multiplyEdad}");

        var value = 20;
        Console.WriteLine("In Main, value = {0}", value);
        ModifyValue(ref value);
        Console.WriteLine("Back in Main, value = {0}", value);
    }

    private static void ModifyValue(ref int i)
    {
        i = 30;
        Console.WriteLine("In ModifyValue, parameter value = {0}", i);
        return;
    }

    private struct Person
    {
        public string? Nombre { get; set; }
        public int Edad { get; private set; }

        // public Person()
        // {

        // }

        // public Person(string Nombre, int Edad)
        // {
        //     this.Nombre = Nombre;
        //     this.Edad = Edad;
        //     // Console.WriteLine($"Nombre: {this.nombre} | Edad: {this.edad}");
        // }



        // public static Person CreatePerson(string name, int edad)
        // {
        //     return new Person(name, edad);
        // }

        // public void ChangeEdad(int Edad) => this.Edad = Edad;

        public string Name
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }
        public int Age
        {
            get => Age;
            private set => Age = value;
        }

    }
}


