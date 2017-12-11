using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class StartUp
{
    static void Main()
    {
        var people = new List<Person>();
        var products = new List<Product>();

        var peopleInput = Console.ReadLine().Split(';');
        var productsInput = Console.ReadLine().Split(';');

        var personName = "";
        decimal money;

        var productName = "";
        decimal price;

        try
        {

            foreach (var p in peopleInput)
            {
                personName = p.Split('=').First();
                money = decimal.Parse(p.Split('=').Last());

                var person = new Person(personName, money);
                people.Add(person);
            }

            foreach (var p in productsInput)
            {
                if (p == "")
                {
                    continue;
                }

                productName = p.Split('=').First();
                price = decimal.Parse(p.Split('=').Last());


                var product = new Product(productName, price);
                products.Add(product);
            }


            string command;

            while ((command = Console.ReadLine()) != "END")
            {
                var args = command.Split();
                personName = args[0];
                productName = args[1];

                var person = people.First(p => personName == p.Name);
                money = person.Money;

                var product = products.Find(p => productName == p.Name);
                price = product.Price;

                var newMoney = money - price;

                if (newMoney < 0)
                {
                    Console.WriteLine($"{personName} can't afford {productName}");
                    continue;
                }

                person.Money = newMoney;
                person.Products.Add(productName);

                Console.WriteLine($"{personName} bought {productName}");
            }

            foreach (var p in people)
            {
                Console.WriteLine(p);
            }
        }

        catch (Exception e)
        {

            Console.WriteLine(e.Message);
        }
    }
}

