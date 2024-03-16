using NUnit.Framework;

[TestFixture]
public class GroupEntityTests
{
    [Test]
    public void GroupEntity_Creation_ShouldSetGroupName()
    {
        var groupName = "Test Group";
        var group = new GroupEntity(groupName);
        Assert.AreEqual(groupName, group.Name);
    }

    [Test]
    public void AddStudent_ShouldAddStudentToGroup()
    {
        var group = new GroupEntity("Test Group");
        var student = new StudentEntity("John Doe", 20, 1);
        group.AddStudent(student);
        Assert.IsTrue(group.Students.Contains(student));
    }
}