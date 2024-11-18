namespace Week13Homework
{
    internal class Program
    {
        struct Score
        {
            public int rank;
            public int occurences;

            public Score()
            {
                rank = 0;
                occurences = 0;
            }
        }

        static void Main(string[] args)
        {
            //initialize dictionary
            Dictionary<string, Score> boyNames = new Dictionary<string, Score>();
            Dictionary<string, Score> girlNames = new Dictionary<string, Score>();

            //define delimeter(s)
            char[] delimeters = { ' ' };

            //parse boy names, weird path because it was searching for the file in
            //bin/debug/net8.0
            Parse("../../../boynames.txt", boyNames, delimeters);

            //parse girl names
            Parse("../../../girlnames.txt", girlNames, delimeters);

            //get user input
            while (true)
            {
                Console.WriteLine("Enter a name or enter to stop:");
                string name = Console.ReadLine();

                if (name == "")
                {
                    Console.WriteLine("Exiting program.");
                    break;
                }

                //check girl names
                if (girlNames.ContainsKey(name))
                {
                    Score temp = girlNames[name];
                    Console.WriteLine($"{name} is ranked {temp.rank} in popularity among girls with {temp.occurences} namings.");
                }
                else
                {
                    Console.WriteLine($"{name} is not ranked among the top 1000 girl names.");
                }

                //check boy names
                if (boyNames.ContainsKey(name))
                {
                    Score temp = boyNames[name];
                    Console.WriteLine($"{name} is ranked {temp.rank} in popularity among boys with {temp.occurences} namings.");
                }
                else
                {
                    Console.WriteLine($"{name} is not ranked among the top 1000 boy names.");
                }

                Console.WriteLine();
            }
        }

        static void Parse(string path, Dictionary<string, Score> dict, char[] delim)
        {
            using (StreamReader file = new StreamReader(path))
            {
                int count = 1;
                string line = null;
                while (!file.EndOfStream)
                {
                    line = file.ReadLine();
                    Score score;

                    //split line
                    string[] parts = line.Split(delim);

                    //store relevant values
                    string name = parts[0];
                    score.occurences = int.Parse(parts[1]);
                    score.rank = count;

                    //add to boyname dict
                    dict.Add(name, score);

                    //iterate count for next rank
                    count++;
                }
            }
        }
    }
}
