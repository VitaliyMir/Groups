using NUnit.Framework;

[TestFixture]
public class TeacherEntityTests
{
    [Test]
    public void AddSubject_ShouldAddSubjectToTeacher()
    {
        var teacher = new TeacherEntity("Mrs. Johnson", 35);
        var subject = new SubjectEntity("History", teacher);
        teacher.AddSubject(subject);
        Assert.IsTrue(teacher.Subjects.Contains(subject));
    }
}