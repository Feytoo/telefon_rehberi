namespace phone_book;
class Program
{
    static void Main(string[] args)
    {
        baslangic:
        Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)");
        Console.WriteLine("*******************************************");
        Console.WriteLine("(1) Yeni Numara Kaydetmek");
        Console.WriteLine("(2) Varolan Numarayi Silmek");
        Console.WriteLine("(3) Varolan Numarayi Guncelleme");
        Console.WriteLine("(4) Reheri Listelemek");
        Console.WriteLine("(5) Rehberde Arama Yapmak");
        Console.WriteLine("(9) Cikis Yap");
        int karar = int.Parse(Console.ReadLine());
        bool control =true;
        while (control)
        {
            switch (karar)
            {
                case 1:
                    AddNumber.add_number(Book.personList);
                    break;
                
                case 2:
                    DeleteNumber.delete_number(Book.personList);
                    break;
                
                case 3:
                    UpdateNumber.update_number(Book.personList);
                    break;
                
                case 4:
                    DisplayList.display_list(Book.personList);
                    break;
                
                case 5:
                    SearchPerson.search_person(Book.personList);
                    break;
                
                case 9:
                    control = false;
                    break;
            }

            if (control)
            {
                Console.Write("Yapmak Istediginiz Yeni Islemi Seciniz: ");
                karar = int.Parse(Console.ReadLine());
                Console.WriteLine("**********************");
            }
        }
    }
}
