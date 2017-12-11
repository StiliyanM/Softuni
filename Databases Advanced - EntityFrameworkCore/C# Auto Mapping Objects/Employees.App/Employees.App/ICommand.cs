namespace Employees.App
{
    interface ICommand
    {
        string Execute(params string[] args);
    }
}
