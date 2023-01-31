
using ConsoleApp1.Models;
using Newtonsoft.Json;

namespace ConsoleApp1.Services;

public class Menu   
{
    public List<Contact> contacts = new List<Contact>();
    public Fileservice file = new Fileservice();

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
        Console.Write("Ange postnummer: ");
        contact.PostalCode = Console.ReadLine() ?? "";
        Console.Write("Ange stad: ");
        contact.City = Console.ReadLine() ?? "";

        contacts.Add(contact);
        file.Save(FilePath, JsonConvert.SerializeObject(contacts));

        Console.WriteLine("");
        Console.WriteLine("Tryck på valfri tangent för att komma till startsidan på adressboken..");
        Console.ReadKey();

    }
    private void OptionTwo()

    {
        Console.Clear();
        Console.WriteLine("Kontakter ");
        Console.WriteLine("");

        contacts!.ForEach(contact => Console.WriteLine("Namn: " + contact.FirstName + " " + contact.LastName + "   " + "Email: " + contact.Email));
        Console.WriteLine("");
        Console.WriteLine("Tryck på valfri tangent för att komma till startsidan på adressboken..");
        Console.ReadKey();
      
    }
    private void OptionThree()
    {
        Console.Clear();
        Console.WriteLine("Visa specifik kontakt");
        Console.WriteLine("");
        Console.Write("Ange förnamn på den person du söker: ");
        Console.WriteLine("");
        var contactFirstName = Console.ReadLine();

        var contact = contacts.Find(x => x.FirstName == contactFirstName);
        Console.WriteLine("Förnamn: " + contact!.FirstName);
        Console.WriteLine("Efternamn: " + contact!.LastName);
        Console.WriteLine("E-postadress: " + contact!.Email);
        Console.WriteLine("Telefonnummer: " + contact!.Phone);
        Console.WriteLine("Adress: " + contact!.Address + ", " + contact!.PostalCode + " " + contact!.City);

       
        Console.WriteLine("Tryck på valfri tangent för att komma till startsidan på adressboken.");
        Console.ReadKey();

    }
    private void OptionFour()
    {
        Console.Clear();
        Console.Write("Ta bort en specifik kontakt");
        Console.WriteLine("");
        Console.Write("Ange förnamn på personen du vill ta bort: ");
        Console.WriteLine("");
        var contactFirstName = Console.ReadLine();

        Console.WriteLine("Vill du ta bort " + contactFirstName + " från listan? ");

        Console.Write("j = ja. n = nej.");
        var inputanswer = Console.ReadLine();
        
        if (inputanswer == "j")
        {
           
            contacts.RemoveAll(contact => contact.FirstName! == contactFirstName);
            file.Save(FilePath, JsonConvert.SerializeObject(contacts));

            Console.WriteLine("Personen har tagits bort");
        }
            else if (inputanswer == "n")
        {
            Console.WriteLine("Åtgärden slutfördes ej");
        }
        Console.WriteLine("");
        Console.WriteLine("Tryck på valfri tangent för att komma till startsidan på adressboken..");
        Console.ReadKey(); 
    }
}
