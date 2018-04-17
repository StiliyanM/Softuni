namespace P10CarSalesman
{
    class Car
    {
        public string Model { get; set; }
        public Engine Engine { get; set; }

        private int? weight;
        private string color;

        public int? Weight
        {
            get { return weight; }
            set
            {
                weight = value;
            }
        }

        public string Color
        {
            get { return color; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    color = "n/a";
                }
                else
                {
                    color = value;
                }
            }
        }
    }
}
