using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Tomcat:Cat
{
    protected string gender;

    public Tomcat(string name, int age, string gender)
        :base(name,age,gender)
    {
        this.Gender = gender;
    }

    public override string ProduceSound()
    {
        return"MEOW";
    }

    protected override string Gender { get => this.gender; set => this.gender = "Male"; }

}

