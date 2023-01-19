
using ConsoleApp1.Interfaces;
using ConsoleApp1.Models;
using Newtonsoft.Json;

namespace ConsoleApp1.Services;

internal class Menu   
{
    private List<Contact> contacts = new List<Contact>();
    private Fileservice file = new Fileservice();

    public string FilePath { get; set; } = null!;
    public void StartMenu()
    {
        try
        {
            contacts = JsonConvert.DeserializeObject<List<Contact>>(file.Read(FilePath))!;
        }
        catch { }

        Console.Clear();
        Console.WriteLine("ADRESSBOKEN");
        Console.WriteLine("1. Skapa en kontakt");
        Console.WriteLine("2. Visa alla kontakter");
        Console.WriteLine("3. Visa en specifik kontakt");
        Console.WriteLine("4. Ta bort en specifik kontakt");
        Console.Write("");
        Console.Write("Vänligen välj ett av ovanstående alternativ. ");
        var option = Console.ReadLine();

        switch(option)
        {
            case "1": OptionOne(); break;
            case "2": OptionTwo(); break;
            case "3": OptionThree(); break;
            case "4": OptionFour(); break;
        }
    }
    private void OptionOne() 
    {
        Console.Clear();
        Console.WriteLine("Skapa en kontakt");

        Contact contact = new Contact();
        Console.Write("Ange förnamn: ");
        contact.FirstName = Console.ReadLine() ?? "";
        Console.Write("Ange efternamn: ");
        contact.LastName = Console.ReadLine() ?? "";
        Console.Write("Ange epostadress: ");
        contact.Email = Console.ReadLine() ?? "";
        Console.Write("Ange telefonnummer: ");
        contact.Phone = Console.ReadLine() ?? "";
        Console.Write("Ange adress: ");
        contact.Address = Console.ReadLine() ?? "";

        contacts.Add(contact);
        file.Save(FilePath, JsonConvert.SerializeObject(contacts));

        Console.WriteLine("");
        Console.WriteLine("Tryck på valfri tangent för att komma till huvudmeny.");
        Console.ReadKey();

    }
    private void OptionTwo()

    {
        Console.Clear();
        Console.WriteLine("Kontakter ");
        Console.WriteLine("");

        contacts!.ForEach(contact => Console.WriteLine("Namn: " + contact.FirstName + " " + contact.LastName + "   " + "Email: " + contact.Email));
        Console.WriteLine("");
        Console.WriteLine("Tryck på valfri tangent för att komma till huvudmeny.");
        Console.ReadKey();
    }
    private void OptionThree()
    {
        Console.Clear();
        Console.WriteLine("Visa specifik kontakt");
        Console.WriteLine("");
        Console.Write("Ange förnamn på den person du söker: ");
        var contactName = Console.ReadLine();

        var foundName = contacts.Find(contact => contact.FirstName == contactName);
        Console.WriteLine("Förnamn: " + foundName!.FirstName);
        Console.WriteLine("Efternamn: " + foundName!.LastName);
        Console.WriteLine("E-postadress: " + foundName!.Email);
        Console.WriteLine("Telefonnummer: " + foundName!.Phone);
        Console.WriteLine("Adress: " + foundName!.Address);

        Console.WriteLine("");
        Console.WriteLine("Tryck på valfri tangent för att komma till huvudmeny.");
        Console.ReadKey();

    }
    private void OptionFour()
    {
        Console.Clear();
        Console.Write("Ta bort en specifik kontakt");
        Console.WriteLine("");
        Console.Write("Ange E-postadress på personen du vill ta bort: ");
        var result = Console.ReadLine();
        Console.Write("Vill du ta bort personen med E-postadressen " + result + " " + "från listan? (y/n): ");
        var answer = Console.ReadLine();

        if (answer == "y") 
        {
            contacts.RemoveAll(contact => contact.Email == result);
            Console.WriteLine("Personen har tagits bort");
        }
        else if (answer == "n") 
        {
        Console.WriteLine("Avbryter");
        }

        Console.WriteLine("");
        Console.WriteLine("Tryck på valfri tangent för att komma till huvudmeny.");
        Console.ReadKey();
    }
}
text