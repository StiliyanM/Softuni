using System.Collections.Generic;
public class Garage
{
    public ICollection<Car> ParkedCars { get; private set; } = new HashSet<Car>();
}
