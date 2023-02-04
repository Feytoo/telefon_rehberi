namespace phone_book;

class DisplayList
{
    public static void display_list(List<Person> personList)
    {
        Console.WriteLine("Telefon Rehberi");
        Console.WriteLine("**********************************************");
        foreach (var person in personList)
        {
            Console.WriteLine($"Isim: {person.Name}");
            Console.WriteLine($"Soyisim: {person.Surname}");
            Console.WriteLine($"Telefon Numarasi: {person.Number}");
            Console.WriteLine("--");
        }
    }     
}
