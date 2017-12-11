﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Animal
{
    private string name;
    private int age;
    private string gender;

    public Animal(string name, int age, string gender)
    {
        this.Name = name;
        this.Age = age;
        this.Gender = gender;
    }

    protected virtual string Gender
    {
        get { return gender; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Invalid input!");
            }
            gender = value;
        }
    }

    protected int Age
    {
        get { return age; }
        set
        {
            if (string.IsNullOrWhiteSpace(value.ToString()) || value < 0)
            {
                throw new ArgumentException("Invalid input!");
            }
            age = value;
        }
    }
    protected virtual string Name
    {
        get { return name; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Invalid input!");
            }
            name = value;
        }
    }

    public virtual string ProduceSound()
    {
        return "Some sound";
    }

    public override string ToString()
    {
        return $"{this.GetType()}" + Environment.NewLine +
               $"{this.Name} {this.Age} {this.Gender}" + Environment.NewLine +
               $"{this.ProduceSound()}";
    }
}

