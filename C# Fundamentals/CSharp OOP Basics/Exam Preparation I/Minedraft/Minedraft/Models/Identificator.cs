public abstract class Identificator
{
    public string Id { get; protected set; }

    protected Identificator(string id)
    {
        this.Id = id;
    }

}