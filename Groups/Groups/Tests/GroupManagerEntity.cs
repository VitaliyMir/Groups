using NUnit.Framework;

[TestFixture]
public class GroupManagerEntityTests
{
    [Test]
    public void AddGroup_ShouldAddGroup()
    {
        var manager = new GroupManagerEntity();
        var group = new GroupEntity("Test Group");
        manager.AddGroup(group);
        Assert.IsTrue(manager.Groups.Contains(group));
    }

    [Test]
    public void FindGroupByName_ShouldReturnCorrectGroup()
    {
        var manager = new GroupManagerEntity();
        var groupName = "Test Group";
        var group = new GroupEntity(groupName);
        manager.AddGroup(group);
        var foundGroup = manager.FindGroupByName(groupName);
        Assert.AreEqual(group, foundGroup);
    }
}