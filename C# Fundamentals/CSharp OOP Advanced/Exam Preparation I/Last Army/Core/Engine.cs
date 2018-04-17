using System;
using System.Text;

public class Engine
{
    private GameController gameController;

    public Engine(GameController gameController)
    {
        this.gameController = gameController;
    }

    public void Run()
    {
        var input = ConsoleReader.ReadLine();
        var result = new StringBuilder();

        while (!input.Equals("Enough! Pull back!"))
        {
            try
            {
                gameController.GiveInputToGameController(input);
            }
            catch (ArgumentException arg)
            {
                result.AppendLine(arg.Message);
            }
            input = ConsoleReader.ReadLine();
        }

        //gameController.RequestResult(result);
        ConsoleWriter.WriteLine(result.ToString());
    }
}

