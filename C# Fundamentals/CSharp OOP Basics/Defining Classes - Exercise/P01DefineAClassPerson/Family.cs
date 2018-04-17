using System.Collections.Generic;
using System.Linq;

class Family
{
    private List<Person> members;

    public Family()
    {
        members = new List<Person>();
    }

    public List<Person> Members
    {
        get { return members; }
        set { members = value; }
    }

    public void AddMember(Person member)
    {
        this.Members.Add(member);
    }

    public Person GetOldestMember()
    {
        return members.OrderByDescending(p => p.Age).First();
    }

}

