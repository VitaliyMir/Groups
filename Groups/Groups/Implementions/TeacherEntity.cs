using Groups.Implementions;

namespace Students.Implementations;

public class TeacherEntity : PersonEntity
{
    public List<SubjectEntity> Subjects { get; set; }

    public TeacherEntity(string name, int age) : base(name, age)
    {
        Subjects = new List<SubjectEntity>();
    }

    public void AddSubject(SubjectEntity subject)
    {
        Subjects.Add(subject);
    }
}