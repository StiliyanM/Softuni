namespace _03DependencyInversion
{
    internal class PrimitiveCalculator
    {
        private bool isAddition;
        private IStrategy strategy;

        public PrimitiveCalculator()
        {
            this.strategy = new AdditionStrategy();
            this.isAddition = true;
        }

        public void changeStrategy(char @operator)
        {
            switch (@operator)
            {
                case '+':
                    this.strategy = new AdditionStrategy();
                    break;

                case '-':
                    this.strategy = new SubtractionStrategy();
                    break;

                case '*':
                    this.strategy = new MultiplyingStrategy();
                    break;

                case '/':
                    this.strategy = new DividingStrategy();
                    break;
            }
        }

        public int performCalculation(int firstOperand, int secondOperand)
        {
            return this.strategy.Calculate(firstOperand, secondOperand);
        }
    }
}