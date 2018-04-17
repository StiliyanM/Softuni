using System;
using System.Collections.Generic;

namespace P01GenericBoxOfString
{
    class StartUp
    {        
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            ////GenericBoxOfStringImplementation(n);
            //GenericBoxOfIntImplementation(n);
            //GenericSwapOfStringImplementation(n);
            //GenericSwapOfIntImplementation(n);
            //GenericCountMethodStringsImplementation(n);
            GenericCountMethodDoubleImplementation(n);
        }

        private static void GenericCountMethodDoubleImplementation(int n)
        {
            List<Box<double>> data = FillListOfDoubles(n);

            var element = double.Parse(Console.ReadLine());

            int compareCount = GetCompareCount<double>(data, element);

            Console.WriteLine(compareCount);

        }

        private static List<Box<double>> FillListOfDoubles(int n)
        {
            var data = new List<Box<double>>();

            for (int i = 0; i < n; i++)
            {
                var box = new Box<double>(double.Parse(Console.ReadLine()));
                data.Add(box);
            }

            return data;

        }

        private static void GenericCountMethodStringsImplementation(int n)
        {
            List<Box<string>> data = FillListOfStrings(n);

            var element = Console.ReadLine();

            int compareCount = GetCompareCount<string>(data, element);

            Console.WriteLine(compareCount);
        }

        private static int GetCompareCount<T>(List<Box<T>> data, T element) where T: IComparable
        {
            var count = 0;

            foreach (var item in data)
            {
                if(item.Compare(element) > 0)
                {
                    count++;
                }
            }

            return count;
        }

        private static void GenericSwapOfIntImplementation(int n)
        {          
            List<Box<int>> data = FillListOfInts(n);

            Swap<int>(data);

            PrintList<int>(data);

        }

        private static void GenericSwapOfStringImplementation(int n)
        {
            List<Box<string>> data = FillListOfStrings(n);

            Swap<string>(data);

            PrintList(data);
        }

        private static List<Box<int>> FillListOfInts(int n)
        {
            var data = new List<Box<int>>();

            for (int i = 0; i < n; i++)
            {
                var box = new Box<int>(int.Parse(Console.ReadLine()));
                data.Add(box);
            }

            return data;
        }

        private static void PrintList<T>(List<Box<T>> data) where T: IComparable
        {
            foreach (var item in data)
            {
                Console.WriteLine(item);
            }
        }

        private static List<Box<string>> FillListOfStrings(int n)
        {
            var data = new List<Box<string>>();

            for (int i = 0; i < n; i++)
            {
                var box = new Box<string>(Console.ReadLine());
                data.Add(box);
            }

            return data;
        }

        private static void GenericBoxOfIntImplementation(int n)
        {
            for (int i = 0; i < n; i++)
            {
                var number = int.Parse(Console.ReadLine());

                var box = new Box<int>(number);

                Console.WriteLine(box);
            }
        }

        private static void GenericBoxOfStringImplementation(int n)
        {
            for (int i = 0; i < n; i++)
            {
                var str = Console.ReadLine();

                var box = new Box<string>(str);

                Console.WriteLine(box);
            }
        }

        private static void Swap<T>(List<Box<T>> data) where T: IComparable
        {
            var arguments = Console.ReadLine().Split();

            var firstElementIndex = int.Parse(arguments[0]);
            var secondElementIndex = int.Parse(arguments[1]);

            var temp = data[firstElementIndex];
            data[firstElementIndex] = data[secondElementIndex];
            data[secondElementIndex] = temp;
        }
    }
}
