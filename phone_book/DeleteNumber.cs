namespace phone_book;

class DeleteNumber
{
    public static void delete_number(List<Person> personList)
    {
        baslangic:
        Console.Write("Lütfen numarasini silmek istediğiniz kişinin adini ya da soyadini giriniz: ");
        string name_surname = Console.ReadLine();
        bool islem = false;
       while(!islem)
       {
           foreach(var item in personList)
           {
               if(item.Name.ToLower() == name_surname.ToLower())
               {
                   Console.Write("{0} {1} isimli kisiyi silmek istediginize emin misiniz? (y/n)",item.Name,item.Surname);
                   string control = Console.ReadLine();
                   if(control.ToLower() == "y")
                   {
                        Console.WriteLine("{0} {1} isimli kisi silindi.",item.Name,item.Surname);
                        personList.Remove(item);
                        islem = true;
                        break;
                   }
                   else
                   {
                       islem = true;
                   }
               }
               else if(item.Surname.ToLower() == name_surname.ToLower())
               {
                   Console.Write("{0} {1} isimli kisiyi silmek istediginize emin misiniz? (y/n)",item.Name,item.Surname);
                   string comtrol = Console.ReadLine();
                   if(comtrol.ToLower() == "y")
                   {
                        Console.WriteLine("{0} {1} isimli kisi silindi.",item.Name,item.Surname);
                        personList.Remove(item);
                        islem = true;
                        break;
                   }
                   else
                   {
                       islem=true;
                   }
               }
            }
            if(!islem)
            {
                Console.WriteLine("Aradiğiniz krtiterlere uygun veri rehberde bulunamadi. Lütfen bir seçim yapiniz.");
                Console.WriteLine("Silmeyi sonlandirmak icin : (1)");
                Console.WriteLine("Yeniden denemek icin : (2)");
                string cnt = Console.ReadLine();
                if(cnt == "1")
                {
                    islem = true;
                }
                else if(cnt == "2")
                {
                    goto baslangic;
                }
            }
        }
    }
}