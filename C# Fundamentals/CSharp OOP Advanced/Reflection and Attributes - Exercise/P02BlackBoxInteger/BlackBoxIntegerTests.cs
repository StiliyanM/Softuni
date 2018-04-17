namespace P02BlackBoxInteger
{
    using System;
    using System.Reflection;

    public class BlackBoxIntegerTests
    {
        public static void Main()
        {
            string input;

            var type = typeof(BlackBoxInteger);
            var instance = Activator.CreateInstance(type, true);

            while ((input = Console.ReadLine()) != "END")
            {
                var args = input.Split('_');
                var command = args[0];
                var value = int.Parse(args[1]);

                InvokeMethod(type, instance, command, value);
            }
        }

        private static void InvokeMethod(Type type, object instance, string methodName, int value)
        {
            var method = type.GetMethod(methodName, BindingFlags.Instance | BindingFlags.NonPublic);

            method.Invoke(instance, new object[] { value });
            Console.WriteLine(type.GetField("innerValue", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(instance));
        }
    }
}
