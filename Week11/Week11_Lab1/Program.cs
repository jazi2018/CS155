namespace Week11_Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Email email1 = new Email();
            email1.setSender("alice@example.com");
            email1.setRecipient("bob@example.com");
            email1.setTitle("Meeting Tomorrow");
            email1.setText("Hi Bob, just a reminder about our meeting tomorrow at 2 PM.");

            Email email2 = new Email();
            email2.setSender("charlie@example.com");
            email2.setRecipient("david@example.com");
            email2.setTitle("Project Update");
            email2.setText("David, please find attached the latest project update document.");

            File file1 = new File();
            file1.setPathname("/home/user/documents/report.txt");
            file1.setText("This is the annual report for the fiscal year 2024.");

            File file2 = new File();
            file2.setPathname("/home/user/documents/notes.txt");
            file2.setText("Remember to buy groceries and call mom.");

            Console.WriteLine("Testing ContainsKeyword method:");
            Console.WriteLine($"Email1 contains 'meeting': {ContainsKeyword(email1, "meeting")}");
            Console.WriteLine($"Email2 contains 'project': {ContainsKeyword(email2, "project")}");
            Console.WriteLine($"File1 contains 'report': {ContainsKeyword(file1, "report")}");
            Console.WriteLine($"File2 contains 'groceries': {ContainsKeyword(file2, "groceries")}");
        }

        public static bool ContainsKeyword(Document docObject, string keyword)
        {
            if (docObject.ToString().IndexOf(keyword, 0) >= 0)
            {
                return true;
            }
            return false;
        }
    }
}
