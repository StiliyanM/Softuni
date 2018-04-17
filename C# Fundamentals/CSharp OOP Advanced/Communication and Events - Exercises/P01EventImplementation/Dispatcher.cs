namespace P01EventImplementation
{
    public delegate void NameEventChanger(object sender, NameChangeEventArgs args);

    public class Dispatcher
    {
        public event NameEventChanger NameChange;

        private string name;

        public Dispatcher(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return name; }
            set
            {
                OnNameChange(new NameChangeEventArgs(value));
                name = value;
            }
        }

        public void OnNameChange(NameChangeEventArgs args)
        {
            if(this.NameChange != null)
            {
                this.NameChange.Invoke(this, args);
            }
        }
    }
}
