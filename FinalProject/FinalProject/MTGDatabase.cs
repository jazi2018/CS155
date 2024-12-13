namespace FinalProject
{
    internal class MTGDatabase
    {
        private static Collection collection = new Collection();
        private static Deck deck = new Deck();

        static void Main(string[] args)
        {
            LoadInitialCSV("cards.csv"); //prepare for LAG
            string choice;
            do
            {
                DisplayMenu();
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        deck.DisplayCollection();
                        break;
                    case "2":
                        AddCard();
                        break;
                    case "3":
                        RemoveCard();
                        break;
                    case "4":
                        SearchCards();
                        break;
                    case "5":
                        Console.WriteLine("Exiting program...");
                        break;
                    default:
                        Console.WriteLine("Invalid selection. Please try again.");
                        break;
                }
            } while (choice != "5");
            SaveCSV("deck.csv");
        }

        static void DisplayMenu()
        {
            Console.WriteLine("\nMTG Card Database");
            Console.WriteLine("1. View deck");
            Console.WriteLine("2. Add card to deck");
            Console.WriteLine("3. Remove card from deck");
            Console.WriteLine("4. Search cards from database");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");
        }

        static void AddCard()
        {
            Console.Write("Enter card name: ");
            string name = Console.ReadLine();
            Console.Write("Enter set: ");
            string set = Console.ReadLine();
            Console.Write("Enter type: ");
            string type = Console.ReadLine();

            Card newCard = new Card(name, set, type);
            collection.AddCard(newCard);
        }

        static void RemoveCard()
        {
            Console.Write("Enter card name to remove: ");
            string name = Console.ReadLine();
            Console.Write("Enter set: ");
            string set = Console.ReadLine();
            Console.Write("Enter type: ");
            string type = Console.ReadLine();

            Card newCard = new Card(name, set, type);
            collection.RemoveCard(newCard);
        }
        static void SearchCards()
        {
            Console.Write("Enter search criteria: ");
            string criteria = Console.ReadLine();
            collection.SearchCard(criteria);
        }

        static void LoadInitialCSV(string filename)
        {
            try
            {
                //this takes an insane amount of memory, may be necessary
                //to go line by line on certain computers
                string[] lines = File.ReadAllLines(filename);
                foreach (string line in lines)
                {
                    string[] values = line.Split(',');
                    Card card = new Card(
                        values[50], //name
                        values[64], //set code
                        values[55].Split(' ')[0] //will be creature, enchantment, instant, etc.
                        );
                    collection.AddCard(card);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine($"Error reading CSV file: {e.Message}");
            }
        }
        void LoadCSV(string filename)
        {
            try
            {
                string[] lines = File.ReadAllLines(filename);
                foreach (string line in lines)
                {
                    string[] values = line.Split(',');
                    Card card = new Card(
                        values[0], //name
                        values[1], //set code
                        values[2] //will be creature, enchantment, instant, etc.
                        );
                    collection.AddCard(card);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine($"Error reading CSV file: {e.Message}");
            }
        }
        static void SaveCSV(string filename)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filename))
                {
                    // Write header
                    writer.WriteLine("Name,Set,Type");

                    // Write each card to the CSV file
                    foreach (var card in collection.GetCards())
                    {
                        string line = $"{card.Name},{card.Set},{card.Type}";
                        writer.WriteLine(line);
                    }
                }
                Console.WriteLine($"Collection saved to {filename}");
            }
            catch (IOException e)
            {
                Console.WriteLine($"Error writing to CSV file: {e.Message}");
            }
        }
    }
}
