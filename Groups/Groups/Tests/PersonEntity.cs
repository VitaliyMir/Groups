using NUnit.Framework;

[TestFixture]
public class PersonEntityTests
{
    [Test]
    public void PersonEntity_Creation_ShouldSetProperties()
    {
        var name = "John Doe";
        var age = 30;
        var person = new PersonEntity(name, age);
        Assert.AreEqual(name, person.Name);
        Assert.AreEqual(age, person.Age);
    }
}