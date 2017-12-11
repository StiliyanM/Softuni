using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Product
{
    private string name;
    private decimal price;

    public Product(string name, decimal price)
    {
        this.Name = name;
        this.Price = price;
    }
    public string Name
    {
        get { return name; }
        set
        {
            if (value == "")
            {
                throw new ArgumentException("Name cannot be empty");
            }

            name = value;
        }
    }

    public decimal Price
    {
        get { return price; }
        set
        {
            if(value <= 0)
            {
                throw new ArgumentException("Price cannot be zero or negative");
            }

            price = value;
        }
    }


}

