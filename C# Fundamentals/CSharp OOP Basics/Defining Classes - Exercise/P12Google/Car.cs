namespace P12Google
{
    class Car
    {
        public Car()
        {

        }
        public Car(string model, int speed)
        {
            Model = model;
            Speed = speed;
        }

        public string Model { get; set; }
        public int Speed { get; set; }
    }
}
