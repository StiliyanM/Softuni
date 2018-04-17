namespace SOLID.Contracts
{
    public interface IAppender
    {
        ILayout Layout { get; }

        void Append(IError error);

    }
}
