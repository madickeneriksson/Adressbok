
using ConsoleApp1.Interfaces;
using ConsoleApp1.Models;
using Newtonsoft.Json;

namespace ConsoleApp1.Services;

internal class Menu   
{
    private List<IContact> contacts = new List<IContact>();
    private Fileservice file = new Fileservice();

    public string FilePath { get; set; } = null!;
    public void StartMenu()
    {
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

        IContact contact = new Contact();
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

    }
    private void OptionTwo()
    {

    }
    private void OptionThree()
    {

    }
    private void OptionFour()
    {

    }
}
