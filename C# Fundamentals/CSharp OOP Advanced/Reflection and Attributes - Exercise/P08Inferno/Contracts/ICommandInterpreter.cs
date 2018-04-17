namespace P08Inferno.Contracts
{
    public interface ICommandInterpreter
    {
        ICommand ParseCommand(string commandName, string[] data);
    }
}
