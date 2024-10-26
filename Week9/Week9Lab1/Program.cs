namespace Week9Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pizza order1 = new Pizza();
            order1.setSize("SMALL");
            order1.CheeseToppings = 1;
            order1.PepperoniToppings = 1;
            order1.HamToppings = 0;

            Console.WriteLine("Order 1: A " + order1.ToString() + ".");

            Pizza order2 = new Pizza(1, 1, 3, 2);
            Console.WriteLine("Order 2: A " + order2.ToString() + ".");

            order1.setSize(2);
            Console.WriteLine("Update to Order 1. The size is now " + order1.getSize() + ".\n" +
                              "Its new price is $" + order1.CalculateCost() + ".");
        }
    }
}
