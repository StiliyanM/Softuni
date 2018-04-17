public class Kitten:Cat
{
    protected string gender;

    public Kitten(string name, int age,string gender)
        :base(name,age,gender)
    {
        this.Gender = gender;
    }

    public override string ProduceSound()
    {
        return "Meow";
    }

    protected override string Gender { get => this.gender; set => this.gender = "Female"; }
}

