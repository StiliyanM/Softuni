﻿using System;

internal class Child :Person
{
    public Child(string name, int age)
    : base(name, age)
    {
        this.Age = age;
    }

    public override int Age
    {
        get
        {
            return base.Age;
        }

        set
        {
            if (value > 14)
                throw new ArgumentException("Child's age must be less than 15!");

            base.Age = value;
        }
    }

}