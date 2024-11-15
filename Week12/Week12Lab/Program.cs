namespace Week12Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Phonebook phonebook = new Phonebook();

            while (true)
            {
                Console.WriteLine("\nPhone Lookup Program");
                Console.WriteLine("1. Add Contact");
                Console.WriteLine("2. Delete Contact");
                Console.WriteLine("3. Find Phone Number");
                Console.WriteLine("4. Display All Contacts");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice (1-5): ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter phone number: ");
                        string phoneNumber = Console.ReadLine();
                        phonebook.Add(name, phoneNumber);
                        break;

                    case "2":
                        Console.Write("Enter name to delete: ");
                        name = Console.ReadLine();
                        phonebook.Remove(name);
                        break;

                    case "3":
                        Console.Write("Enter name to find: ");
                        name = Console.ReadLine();
                        phonebook.Lookup(name);
                        break;

                    case "4":
                        phonebook.ListAll();
                        break;

                    case "5":
                        Console.WriteLine("Exiting program. Goodbye!");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}
