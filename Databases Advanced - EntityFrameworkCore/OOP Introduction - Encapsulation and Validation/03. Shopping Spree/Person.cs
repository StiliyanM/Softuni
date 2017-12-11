using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Person
{
    private string name;
    private decimal money;
    private List<string> products;

    public Person(string name, decimal money)
    {
        this.Name = name;
        this.Money = money;

        this.Products = new List<string>();
    }

    public string Name
    {
        get
        { return this.name; }
        set
        {
            if(value == "")
            {
                throw new ArgumentException("Name cannot be empty");

            }

            this.name = value;
        }
    }

    public decimal Money
    {
        get { return this.money; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Money cannot be negative");
            }

            this.money = value;
        }
    }

    public List<string> Products
    {
        get
        {
            return this.products;
        }
        set { this.products = value; }
    }

    public override string ToString()
    {
        if(this.Products.Count != 0)
        {
            return $"{this.Name}" + " - " + string.Join(", ", this.Products);
        }
        else return $"{this.Name}" + " - " + "Nothing bought";
    }
}

