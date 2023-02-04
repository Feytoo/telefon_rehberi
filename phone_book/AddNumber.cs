namespace phone_book;

class AddNumber
{
    public static void add_number(List<Person> personList)
    {
        Console.Write("Lütfen isim giriniz             : ");
        string name = Console.ReadLine();
        Console.Write("Lütfen soyisim giriniz          : ");
        string surname = Console.ReadLine();
        Console.Write("Lütfen telefon numarasi giriniz : ");
        string number = Console.ReadLine();

        Console.WriteLine("*************************************");

        personList.Add(new Person(name, surname, number));

        Console.WriteLine("Islem basariyla tamamlandi.");
    }
}