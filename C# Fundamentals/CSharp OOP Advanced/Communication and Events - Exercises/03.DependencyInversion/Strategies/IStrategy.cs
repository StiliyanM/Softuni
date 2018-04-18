namespace _03DependencyInversion
{
    public interface IStrategy
    {
        int Calculate(int firstOperand, int secondOperand);
    }
}