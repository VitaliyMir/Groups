using Students.Implementations;

namespace Groups.Implementions;

public class GroupManagerEntity
{
    public List<GroupEntity> Groups { get; private set; }

    public GroupManagerEntity()
    {
        Groups = new List<GroupEntity>();
    }

    public void AddGroup(GroupEntity group)
    {
        Groups.Add(group);
    }

    public GroupEntity FindGroupByName(string name)
    {
        return Groups.FirstOrDefault(g => g.Name == name);
    }
}