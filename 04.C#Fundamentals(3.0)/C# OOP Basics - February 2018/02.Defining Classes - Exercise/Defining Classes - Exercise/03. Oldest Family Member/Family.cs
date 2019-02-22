
using System.Collections.Generic;
using System.Linq;

public class Family
{
    List<Person> members = new List<Person>();

    public Family()
    {
        this.members = new List<Person>();
    }

    public void AddMember(Person member)
    {
        this.members.Add(member);
    }

    public Person GetOldestMember()
    {
        return members
            .OrderByDescending(m => m.Age)
            .First();
    }
}