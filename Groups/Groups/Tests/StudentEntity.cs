using NUnit.Framework;

[TestFixture]
public class StudentEntityTests
{
    [Test]
    public void StudentEntity_Creation_ShouldInheritPersonEntity()
    {
        var name = "Jane Doe";
        var age = 20;
        var studentId = 123;
        var student = new StudentEntity(name, age, studentId);
        Assert.AreEqual(name, student.Name);
        Assert.AreEqual(age, student.Age);
        Assert.AreEqual(studentId, student.StudentId);
    }
}