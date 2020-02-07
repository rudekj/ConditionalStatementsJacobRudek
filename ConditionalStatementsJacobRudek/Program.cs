using System;

namespace ConditionalStatementsJacobRudek
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Out of a total score of 100, what score do you expect to earn in ISM 4300? " +
                "Please enter only the number with no % sign");

            string grade;

            // int number = int.Parse(Console.ReadLine());
            int number = Convert.ToInt32(Console.ReadLine());

            grade = "";

            if (number <= 100 && number >= 98)
            {
                grade = "A+";
            }
            else if (number <= 97 && number >= 92)
            {
                grade = "A";
            }
            else if (number <= 91 && number >= 90)
            {
                grade = "A-";
            }



            else if (number <= 89 && number >= 88)
            {
                grade = "B+";
            }
            else if (number <= 87 && number >= 82)
            {
                grade = "B";
            }
            else if (number <= 81 && number >= 80)
            {
                grade = "B-";
            }




            else if (number <= 79 && number >= 78)
            {
                grade = "C+";
            }
            else if (number <= 77 && number >= 72)
            {
                grade = "C";
            }
            else if (number <= 71 && number >= 70)
            {
                grade = "C-";
            }




            else if (number <= 69 && number >= 68)
            {
                grade = "D+";
            }
            else if (number <= 67 && number >= 62)
            {
                grade = "D";
            }
            else if (number <= 61 && number >= 60)
            {
                grade = "D-";
            }




            else if (number <= 59 && number >= 0)
            {
                grade = "F";
            }






            Console.WriteLine("Your letter Grade in the course:" + "  " + grade);

        }
    }
}
