using System;
using System.Collections.Generic;
using System.Linq;

public class Engine
{
    private CommandInterpreter interpreter;
    private Reader reader;
    private Writer writer;

    public Engine(CommandInterpreter interpreter, Reader reader, Writer writer)
    {
        this.interpreter = interpreter;
        this.reader = reader;
        this.writer = writer;
    }

    public void Run()
    {
        var input = reader.ReadLine();

        while (true)
        {
            var data = input.Split(" ".ToCharArray(),StringSplitOptions.RemoveEmptyEntries).ToList();

            var command = data[0];
            var result = interpreter.ProcessCommand(data);

            if (!string.IsNullOrWhiteSpace(result))
            {
                writer.WriteLine(result);
            }

            if (command == "Shutdown")
            {
                break;
            }
            input = reader.ReadLine();
        }
    }
}
