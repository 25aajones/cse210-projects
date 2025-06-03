// See https://aka.ms/new-console-template for more information
class Program
{
    public static void Main(string[] args)
    {
        Person myPerson = new Person("Bubba", "Bob", 53);

        Console.WriteLine(myPerson.GetPersonInformation());

        PoliceMan myPoliceMan = new PoliceMan("Cooper", "Silver", 34);
        Console.WriteLine(myPoliceMan.GetPersonInformation());
    }
}


