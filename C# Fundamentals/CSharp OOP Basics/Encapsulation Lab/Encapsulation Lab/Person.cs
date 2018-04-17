using System;

public class Person
{
    private const string invalidNameMessage = "{0} name cannot be less than 3 symbols";
    private const string invalidAgeMessage = "Age cannot be zero or negative integer";
    private const string invalidSalaryMessage = "Salary cannot be less than 460 leva";

    private string firstName;
    private string lastName;
    private int age;
    private decimal salary;

    public Person(string firstName, string lastName, int age, decimal salary)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Age = age;
        this.Salary = salary;
    }

    public string FirstName
    {
        get { return firstName; }
        set
        {
            if (value.Length < 3)
            {
                throw new ArgumentException(string.Format(invalidNameMessage,"First"));
            }
            firstName = value;
        }
    }

    public string LastName
    {
        get { return lastName; }
        set
        {
            if (value.Length < 3)
            {
                throw new ArgumentException(string.Format(invalidNameMessage, "Last"));
            }

            lastName = value;
        }
    }

    public int Age
    {
        get { return age; }
        set
        {
            if(value <= 0)
            {
                throw new ArgumentException(invalidAgeMessage);
            }
            age = value;
        }
    }

    public decimal Salary
    {
        get { return salary; }
        set
        {
            if(value < 460.0m)
            {
                throw new ArgumentException(invalidSalaryMessage);
            }
            salary = value;
        }
    }

    public void IncreaseSalary(decimal percent)
    {
        if(this.Age > 30)
        {
            this.Salary += this.Salary * percent / 100;
        }
        else
        {
            this.Salary += this.Salary * percent / 200;
        }
    }

    public override string ToString()
    {
        return $"{this.FirstName} {this.LastName} receives {this.Salary:f2} leva.";
    }
}

