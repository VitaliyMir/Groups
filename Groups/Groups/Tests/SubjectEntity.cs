using NUnit.Framework;

[TestFixture]
public class SubjectEntityTests
{
    [Test]
    public void SubjectEntity_Creation_ShouldSetProperties()
    {
        var subjectName = "Mathematics";
        var teacher = new TeacherEntity("Mr. Smith", 40);
        var subject = new SubjectEntity(subjectName, teacher);
        Assert.AreEqual(subjectName, subject.Name);
        Assert.AreEqual(teacher, subject.Teacher);
    }
}