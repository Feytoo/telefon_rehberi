namespace phone_book;

class SearchPerson
{
    public static void search_person(List<Person> personList)
    {
        bool islem = false;
        while(!islem)
        {
            Console.WriteLine(" Arama yapmak istediğiniz tipi seçiniz.");
            Console.WriteLine("**********************************************");
            Console.WriteLine();
            Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
            Console.WriteLine("Telefon numarasina göre arama yapmak için: (2)");
            Console.WriteLine("Islem iptali icin: (3)");
            string secenek = Console.ReadLine();
            if(secenek == "1")
            {
                Console.Write("Lütfen sorgulamak istediğiniz kişinin adini ya da soyadini giriniz: ");
                string name_surname = Console.ReadLine();
                foreach (var person in personList)
                {
                    if(person.Name.ToLower()== name_surname.ToLower())
                    {
                        Console.WriteLine("Arama Sonuçlariniz:");
                        Console.WriteLine("**********************************************");
                        Console.WriteLine($"Isim: {person.Name}");
                        Console.WriteLine($"Soyisim: {person.Surname}");
                        Console.WriteLine($"Numara: {person.Number}");
                        Console.WriteLine("--");
                    }
                    else if(person.Surname.ToLower()== name_surname.ToLower())
                    {
                        Console.WriteLine("Arama Sonuçlariniz:");
                        Console.WriteLine("**********************************************");
                        Console.WriteLine($"Isim: {person.Name}");
                        Console.WriteLine($"Soyisim: {person.Surname}");
                        Console.WriteLine($"Numara: {person.Number}");
                        Console.WriteLine("--");
                    }
                }
            }
            else if(secenek == "2")
            {
                Console.Write("Lütfen sorgulamak istediğiniz kişinin numarasini giriniz: ");
                string number = Console.ReadLine();
                foreach (var person in personList)
                {
                    if(person.Number== number)
                    {
                        Console.WriteLine("Arama Sonuçlariniz:");
                        Console.WriteLine("**********************************************");
                        Console.WriteLine($"Isim: {person.Name}");
                        Console.WriteLine($"Soyisim: {person.Surname}");
                        Console.WriteLine($"Numara: {person.Number}");
                        Console.WriteLine("--");
                    }
                }

            }
            else if(secenek == "3")
            {
                islem = true;
                break;
            }
        }
    }
}