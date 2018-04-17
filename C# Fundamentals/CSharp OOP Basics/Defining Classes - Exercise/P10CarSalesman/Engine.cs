namespace P10CarSalesman
{
    class Engine
    {
        public string Model { get; set; }
        public string Power { get; set; }

        private string efficiency;
        private int? displacement;

        public int? Displacement
        {
            get { return displacement; }
            set
            {
                displacement = value;

            }
        }

        public string Efficiency
        {
            get { return efficiency; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    efficiency = "n/a";
                }
                else
                {
                    efficiency = value;
                }
            }
        }
    }
}
