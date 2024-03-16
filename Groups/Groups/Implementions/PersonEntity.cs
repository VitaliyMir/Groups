namespace Groups.Implementions;

public class PersonEntity
{
    public string Name { get; set; }
    public int Age { get; set; }

    public PersonEntity(string name, int age)
    {
        Name = name;
        Age = age;
    }
}