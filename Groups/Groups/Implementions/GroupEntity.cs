using Groups.Implementions;

namespace Groups.Implementions;

public class GroupEntity
{
    public string Name { get; set; }
    public List<StudentEntity> Students { get; private set; }

    public GroupEntity(string name)
    {
        Name = name;
        Students = new List<StudentEntity>();
    }

    public void AddStudent(StudentEntity student)
    {
        Students.Add(student);
    }
}