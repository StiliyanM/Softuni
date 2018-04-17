using System.Collections.Generic;
using System.Linq;
public class Person
{
    private string name;
    private int age;
    private List<BankAccount> accounts;

    public Person()
    {
        this.Accounts = new List<BankAccount>();
    }

    public Person(string name, int age)
        : this()
    {
        this.Name = name;
        this.Age = age;
    }

    public Person(string name, int age, List<BankAccount> bankAccounts)
        : this(name, age)
    {
        this.Accounts = bankAccounts;
    }

    public decimal GetBalance()
    {
        return this.Accounts.Sum(e => e.Balance);
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public List<BankAccount> Accounts
    {
        get { return accounts; }
        set { accounts = value; }
    }
}

