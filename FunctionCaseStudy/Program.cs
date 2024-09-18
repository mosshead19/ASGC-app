using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionCaseStudy
{
    internal class Program
    {
        //Total Weighted Average
        public static double totalAveScore(double[] quizScores, double[] assignmentScores, double finalExamScore)
        {

            //average's grading criteria
            //Quiz = 25%
            //Assignment = 25%
            //Final Exam = 50%

            double assPercentage = 0.25;
            double quizPercentage = 0.25;
            double finalExamScorePercentage = 0.50;

            double assScoreAve = assignmentScores.Average();
            double quizScoreAve = quizScores.Average();

            //TotalAve = (25%*ass)+(25%*quiz)+(50%*finalExamScore)
            double weightedAverageScore = (assPercentage * assScoreAve) + (quizPercentage * quizScoreAve) + (finalExamScorePercentage * finalExamScore);

            return weightedAverageScore;


        }

        //Letter Grade
        public static string letterGrade(double weightedAverageScore)
        {
            //A: 90 - 100
            //B: 80 - 89
            //C: 70 - 79
            //D: 60 - 69
            //F: 0 - 59

            if (weightedAverageScore < 0 || weightedAverageScore > 100)
            {
                return "Invalid score";
            }

            else if (weightedAverageScore >= 90)
            {
                return "A";
            }
            else if (weightedAverageScore >= 80)
            {
                return "B";
            }
            else if (weightedAverageScore >= 70)
            {
                return "C";
            }
            else if (weightedAverageScore >= 60)
            {
                return "D";
            }
            else
            {
                return "F";
            }


        }




        //Student Report
        public static void displayStudentReport(string studentName, double[] assignmentScores, double[] quizScores, double finalExamScore)
        {

            double weightedAverageScore = totalAveScore(quizScores, assignmentScores, finalExamScore);
            string gradeLetter = letterGrade(weightedAverageScore);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("===========Student Report Summary===========");
            Console.WriteLine();
            Console.WriteLine($"Name of student: {studentName}");
            Console.WriteLine("\nAssignment Scores:");

            foreach (var i in assignmentScores)
            {
                Console.Write(i);
                Console.Write(" ");
            }

            Console.WriteLine("\n\nQuiz Scores:");
            foreach (var i in quizScores)
            {
                Console.Write(i);
                Console.Write(" ");
            }

            Console.WriteLine($"\n\nFinal Exam Score: {finalExamScore}");
            Console.WriteLine($"\nWeighted Average: {weightedAverageScore}");
            Console.WriteLine($"\nLetter Grade: {gradeLetter}");
        }






        static void Main(string[] args)
        {
            Console.Write("Enter student's name: ");
            string studentName = Console.ReadLine();



            Console.Write("\nEnter the number of assignments: ");
            int assNum = Convert.ToInt32(Console.ReadLine());

            double[] assignmentScores = new double[assNum];

            Console.WriteLine("Enter the assignment scores: ");
            for (int i = 0; i <= assNum - 1; i++)
            {
                assignmentScores[i] = Convert.ToInt32(Console.ReadLine());
            }



            Console.Write("\nEnter the number of quizzes: ");
            int quizNum = Convert.ToInt32(Console.ReadLine());

            double[] quizScores = new double[quizNum];

            Console.WriteLine("Enter the quizz scores: ");
            for (int i = 0; i <= quizNum - 1; i++)
            {
                quizScores[i] = Convert.ToInt32(Console.ReadLine());
            }



            Console.Write("\nEnter final exam score: ");
            double finalExamScore = Convert.ToDouble(Console.ReadLine());


            displayStudentReport(studentName, assignmentScores, quizScores, finalExamScore);
        }
    }
}