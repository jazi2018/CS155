namespace Week11_Hmwk1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("John Doe");
            Person person2 = new Person("Jane Smith");

            //create vehicle objects
            Vehicle vehicle1 = new Vehicle(Manufacturer.Toyota, 4, person1);
            Vehicle vehicle2 = new Vehicle(Manufacturer.Ford, 6, person2);
            Vehicle vehicle3 = new Vehicle(Manufacturer.Toyota, 4, person1);

            //create truck objects
            Truck truck1 = new Truck(Manufacturer.Chevrolet, 8, person1, 2.5, 7500);
            Truck truck2 = new Truck(Manufacturer.Nissan, 6, person2, 2.0, 6500);
            Truck truck3 = new Truck(Manufacturer.Chevrolet, 8, person1, 2.5, 7500);

            //test ToString
            Console.WriteLine("Vehicle 1: " + vehicle1.ToString());
            Console.WriteLine("Truck 1: " + truck1.ToString());
            Console.WriteLine("Person 1: " + person1.ToString());

            //test Equals
            Console.WriteLine("Does vehicle1 = vehicle2? " + vehicle1.Equals(vehicle2));
            Console.WriteLine("Does vehicle1 = vehicle3? " + vehicle1.Equals(vehicle3));
            Console.WriteLine("Does person1 = person2? " + person1.Equals(person2));
            Console.WriteLine("Does truck1 = truck2? " + truck1.Equals(truck2));
            Console.WriteLine("Does truck1 = truck3? " + truck1.Equals(truck3));

            //test properties
            Console.WriteLine("Truck 2 originally: " + truck2.ToString());
            truck2.Cylinders += 2;
            truck2.Load = 3.0;
            truck2.Tow = 8000;
            Console.WriteLine("Truck 2 after changes: " + truck2.ToString());

        }
    }
}
