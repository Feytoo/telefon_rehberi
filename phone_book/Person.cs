namespace phone_book;

public class Person
{
    private string name;
    private string surname;
    private string number;
    public string Name { get => name; set => name=value; }
    public string Surname { get => surname; set => surname=value; }
    public string Number { get => number; set => number = value; }

    public Person(string Name, string Surname, string Number)
    {
        name = Name;
        surname = Surname;
        number = Number;
    }
}
