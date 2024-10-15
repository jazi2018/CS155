namespace ExtraCredit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] quizzes = [9, 9, 10];
            int midterm = 95;
            int final = 87;
            StudentRecord student1 = new StudentRecord(quizzes, midterm, final);

            int[] quizzes2 = [5, 5, 8];
            int midterm2 = 67;
            int final2 = 78;
            StudentRecord student2 = new StudentRecord(quizzes2, midterm2, final2);

            Console.WriteLine("Student 1: \n" + student1.toString() + "\n");
            Console.WriteLine("Student 2: \n" + student2.toString() + "\n");

            string isEqual = (student1.Equals(student2)) ? "The two students have equal grades." : "The two students do not have equal grades.";
            Console.WriteLine(isEqual);
            string isEqual2 = (student1.Equals(student1)) ? "The equals function works." : "The equals function does not work.";
            Console.WriteLine(isEqual2);
        }
    }
}
