using System;
using System.Collections.Generic;
using System.Linq;

class StartUp
{
    static void Main()
    {
        var people = new List<Person>();
        var products = new List<Product>();

        var peopleInput = Console.ReadLine().Split(";",StringSplitOptions.RemoveEmptyEntries);
        var productsInput = Console.ReadLine().Split(";",StringSplitOptions.RemoveEmptyEntries);

        var personName = "";

        var productName = "";
        decimal price;

        try
        {
            foreach (var personInput in peopleInput)
            {
                personName = personInput.Split('=').First();
                decimal money = decimal.Parse(personInput.Split('=').Last());

                var person = new Person(personName, money);
                people.Add(person);
            }

            foreach (var productInput in productsInput)
            {

                productName = productInput.Split('=').First();
                price = decimal.Parse(productInput.Split('=').Last());

                var product = new Product(productName, price);
                products.Add(product);
            }

            string command;

            while ((command = Console.ReadLine()) != "END")
            {
                var args = command.Split();
                personName = args[0];
                productName = args[1];

                var person = people.FirstOrDefault(p => personName == p.Name);
                var product = products.FirstOrDefault(p => productName == p.Name);

                person.BuyProduct(product);               
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

