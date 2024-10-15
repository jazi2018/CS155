using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraCredit
{
    internal class StudentRecord
    {
        private int[] quizzes;
        private int midterm;
        private int final;
        private double[] grade_weights = [0.25, 0.35, 0.40]; // quizzes (combined), midterms, tests
        private const int MAX_POINTS = 230; //3 10 point quizzes plus 2 100 point exams

        public StudentRecord()
        {
            this.quizzes = [-1, -1, -1];
            this.midterm = -1;
            this.final = -1;
        }

        public StudentRecord(int[] quizzes, int midterm, int final)
        {
            this.quizzes = quizzes;
            this.midterm = midterm;
            this.final = final;
        }

        //getters
        public int[] getQuizzes() { return this.quizzes; }
        public int getMidterm() { return this.midterm; }
        public int getFinal() { return this.final; }
        public double[] getGradeWeights() { return this.grade_weights; }

        //setters
        public void setQuizzes(int[] quizzes) { this.quizzes = quizzes; }
        public void setQuiz(int quiz_score, int index) 
        {
            //bound checking
            if (index >= 0 && index < quizzes.Length)
            {
                this.quizzes[index] = quiz_score;
            }
            else
            {
                //if out of bounds
                Console.WriteLine("Invalid index provided");
            }
        }
        public void updateQuizzes(int quiz_score)
        {
            for (int i = 0; i < this.quizzes.Length; i++)
            {
                //checks if any quizzes have not been overwritten yet
                if (this.quizzes[i] == -1)
                {
                    this.quizzes[i] = quiz_score;
                    //exits function once one is overwritten
                    return;
                }
            }
            //if nothing is overwritten, print that
            Console.WriteLine("All quiz scores are assigned.");
        }
        public void setMidterm(int midterm) { this.midterm = midterm; }
        public void setFinal(int final) { this.final = final; }
        public void setGradeWeights(double[] weights)
        {
            //check to make sure that the grade weights add up to 100%
            double sum = 0;
            for (int i = 0; i < this.quizzes.Length; i++)
            {
                sum += weights[i];
            }

            if (sum == 1.00)
            {
                this.grade_weights = weights;
            }
            else
            {
                Console.WriteLine("Grade weights do not add to 100%. Weights unchanged");
            }
        }

        //misc functions
        public double calcGrade()
        {
            //initialize individual percentage variables
            double quiz_percentage = 0, midterm_percentage, final_percentage;

            //calculate overall grade for quizzes
            for (int i = 0; i < this.quizzes.Length; ++i)
            {
                quiz_percentage += this.quizzes[i];
            }
            quiz_percentage *= this.grade_weights[0];

            //calculate grade for midterm
            midterm_percentage = this.midterm * this.grade_weights[1];

            //calucate grade for final
            final_percentage = this.final * this.grade_weights[2];

            return Math.Round((quiz_percentage + midterm_percentage + final_percentage), 2);
        }

        public bool Equals(StudentRecord other)
        {
            if (this.calcGrade == other.calcGrade)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string toString()
        {
            string output = String.Format("Quiz 1: {0}\n" +
                "Quiz 2: {1}\n" +
                "Quiz 3: {2}\n" +
                "Midterm: {3}\n" +
                "Final: {4}\n" +
                "Overall: {5}", quizzes[0], quizzes[1], quizzes[2], midterm, final, this.calcGrade());

            return output;
        }
    }
}
