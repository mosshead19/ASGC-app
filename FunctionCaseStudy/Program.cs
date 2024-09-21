using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionCaseStudy
{
    internal class Program
    {
        public static string assignments;
        public static string quizzes;


        //Total Weighted Average
        public static double totalAveScore(List<double> quizScores, List<double> assignmentScores, double finalExamScore)
        {

            //Average's grading criteria
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


        //Student Report Display
        public static void displayStudentReport(string studentName, List<double> assignmentScores, List<double> quizScores, double finalExamScore)
        {

            double weightedAverageScore = totalAveScore(quizScores, assignmentScores, finalExamScore);
            string gradeLetter = letterGrade(weightedAverageScore);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("===========Student Report Summary===========");
            Console.WriteLine();
            Console.WriteLine($"Name of student: {studentName}");
            Console.WriteLine($"\nAssignment Scores: {assignments}");
            Console.WriteLine($"\nQuiz Scores: {quizzes}");
            Console.WriteLine($"\nFinal Exam Score: {finalExamScore}");
            Console.WriteLine($"\n\nWeighted Average: {weightedAverageScore}");
            Console.WriteLine($"\nLetter Grade: {gradeLetter}");
        }




        static void Main(string[] args)
        {
            Console.Write("Enter student's name: ");
            string studentName = Console.ReadLine();


            Console.WriteLine("\nEnter the scores like these examples: 3/5 8/10 13/15...");
            Console.WriteLine("Enter the assignment scores: ");
            assignments = Console.ReadLine();

            string[] aScores = assignments.Split(' ');
            List<double> assignmentScores = new List<double>();

            foreach (string score in aScores)
            {
                string[] values = score.Split('/');
                double numScore = Convert.ToDouble(values[0]);
                double numTotal = Convert.ToDouble(values[1]);
                double calculateValue = (numScore / numTotal) * 100;
                assignmentScores.Add(calculateValue);
            }


            Console.WriteLine("\nEnter the scores like these examples: 3/5 8/10 13/15...");
            Console.WriteLine("Enter the quizz scores: ");
            quizzes = Console.ReadLine();

            string[] qScores = quizzes.Split(' ');
            List<double> quizScores = new List<double>();

            foreach (string score in qScores)
            {
                string[] values = score.Split('/');
                double numScore = Convert.ToDouble(values[0]);
                double numTotal = Convert.ToDouble(values[1]);
                double calculateValue = (numScore / numTotal) * 100;
                quizScores.Add(calculateValue);
            }


            Console.WriteLine("\nEnter the final score like these examples: 85/100");
            Console.Write("Enter final exam score: ");
            string examFinalScore = Console.ReadLine();

            string[] finalExamScoreInput = examFinalScore.Split('/');
            double finalExamScore = Convert.ToDouble(finalExamScoreInput[0]) / Convert.ToDouble(finalExamScoreInput[1]) * 100;


            displayStudentReport(studentName, assignmentScores, quizScores, finalExamScore);
        }
    }
}