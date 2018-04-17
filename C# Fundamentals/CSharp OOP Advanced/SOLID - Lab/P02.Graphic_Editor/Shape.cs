namespace P02.Graphic_Editor
{
    public abstract class Shape : IShape
    {
        public string Name => this.GetType().Name;
    }
}
