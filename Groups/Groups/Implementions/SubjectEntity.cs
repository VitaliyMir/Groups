namespace Groups.Implementions;

public class SubjectEntity
{
    public string Name { get; set; }
    public TeacherEntity Teacher { get; set; }

    public SubjectEntity(string name, TeacherEntity teacher)
    {
        Name = name;
        Teacher = teacher;
    }
}