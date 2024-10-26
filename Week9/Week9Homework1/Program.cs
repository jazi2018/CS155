namespace Week9Homework1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Odometer car1 = new Odometer();
            Console.WriteLine("New car initialized");
            car1.Miles = 25.3;
            car1.Gallons = 2.1;
            Console.WriteLine("Car1 driven. New data: \n" +
                car1.ToString());

            Odometer car2 = new Odometer(79576.55, 3287.04);
            Console.WriteLine("Old car:\n"+
                car2.ToString());
            Console.WriteLine("Adding 45 miles and 3 gallons to car2:");
            car2.Add(45, 3);
            Console.WriteLine(car2.ToString());
            Console.WriteLine("Resetting car2:");
            car2.Reset();
            Console.WriteLine(car2.ToString());
        }
    }
}
