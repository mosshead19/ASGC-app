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
        public static double totalAveScore(int[] quizScores, int[] assignmentScores, int finalExamScore) {

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
        public static string letterGrade (double weightedAverageScore)
        {
        //A: 90-100
        //B: 80 - 89
        //C: 70 - 79
        //D: 60 - 69
        //F: 0 - 59

            if (weightedAverageScore < 0 || weightedAverageScore > 100)
            {
                return "Invalid score";
            }

            else if (weightedAverageScore>=90)
            {
                return "A";
            }
            else if (weightedAverageScore >= 80 )
            {
                return  "B";
            }
            else if (weightedAverageScore >= 70 )
            {
                return "C";
            }
            else if (weightedAverageScore >= 60 )
            {
                return "D";
            }
            else 
            {
                return "F";
            }
           
            
        }


        
        
        //Student Report

        static void Main(string[] args)
        {
            //test case
        }
    }
}
