namespace phone_book;

class Book
{
    public static List<Person> personList = new List<Person>();

    static Book()
    {
        personList.Add(new Person("Sena","Yildiz","5356785412"));
        personList.Add(new Person("Enes","Yilmaz","5314379876")); 
        personList.Add(new Person("Fatih","Celik","5456731234"));
        personList.Add(new Person("Sabri","Camlik","5556800043")); 
        personList.Add(new Person("Nisa","Cekmez","5332124567"));
    }
}