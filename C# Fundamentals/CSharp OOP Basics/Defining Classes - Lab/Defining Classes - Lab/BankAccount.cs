public class BankAccount
{
    private int id;
    private decimal balance;

    public BankAccount(int id)
    {
        this.Id = id;
    }

    public BankAccount()
    {

    }

    public int Id
    {
        get { return id; }
        set { id = value; }
    }

    public decimal Balance
    {
        get { return balance; }
        set { balance = value; }
    }

    public void Deposit(decimal amount)
    {
        this.Balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if(this.Balance - amount < 0)
        {
            System.Console.WriteLine("Insufficient balance");
            return;
        }
        this.Balance -= amount;
    }

    public override string ToString()
    {
        return $"Account ID{this.Id}, balance {this.Balance:f2}";
    }
}

