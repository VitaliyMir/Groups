namespace Groups.Implementions;

public class StudentEntity : PersonEntity
{
    public int StudentId { get; set; }

    public StudentEntity(string name, int age, int studentId) : base(name, age)
    {
        StudentId = studentId;
    }
}