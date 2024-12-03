namespace Week14_Hmwk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>
            {
                //disclaimer: this list of people is AI generated
                new Person("Alice", 10, 1.35),
                new Person("Bob", 15, 1.70),
                new Person("Charlie", 8, 1.25),
                new Person("David", 35, 1.80),
                new Person("Eva", 12, 1.50),
                new Person("Frank", 45, 1.75),
                new Person("Grace", 6, 1.15),
                new Person("Henry", 25, 1.85),
                new Person("Ivy", 30, 1.65),
                new Person("Jack", 11, 1.40)
            };
            List<Person> kids_list = new List<Person>();
            List<Person> average_height_list = new List<Person>();

            kids_list.AddRange(from a in list where a.Age <= 12 select a);
            Console.WriteLine("Kids:");
            foreach (Person person in kids_list)
            {
                Console.WriteLine("Name: " + person.Name + " Age: " + person.Age + " Height: " + person.Height);
            }

            double avg_height = 0;
            foreach (Person person in list)
            {
                avg_height += person.Height;
            }
            int count = (from b in list select b).Count();
            avg_height /= count;
            Console.WriteLine("Avg height: " +  avg_height);

            average_height_list.AddRange(from a in list where a.Height >= avg_height select a);
            Console.WriteLine("People above or at avg height:");
            foreach (Person person in average_height_list)
            {
                Console.WriteLine("Name: " + person.Name + " Age: " + person.Age + " Height: " + person.Height);
            }
        }
    }
}
