using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class StartUp
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine().Trim();

        while (input != "Beast!")
        {
            try
            {
                string[] data = Console.ReadLine().Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToArray();
                string name = data[0];
                int age;
                if (!int.TryParse(data[1], out age))
                {
                    throw new ArgumentException("Invalid input!");
                }

                string gender = data[2];

                switch (input)
                {
                    case "Dog":
                        Dog dog = new Dog(name, age, gender);
                        Console.WriteLine(dog);
                        break;
                    case "Cat":
                        Cat cat = new Cat(name, age, gender);
                        Console.WriteLine(cat);
                        break;
                    case "Frog":
                        Frog frog = new Frog(name, age, gender);
                        Console.WriteLine(frog);
                        break;
                    case "Kitten":
                        Kitten kitten = new Kitten(name, age, gender);
                        Console.WriteLine(kitten);
                        break;
                    case "Tomcat":
                        Tomcat tomcat = new Tomcat(name, age, gender);
                        Console.WriteLine(tomcat);
                        break;
                    default:
                        throw new ArgumentException("Invalid input!");
                }
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input!");
            }
            input = Console.ReadLine().Trim();
        }
    }
}

