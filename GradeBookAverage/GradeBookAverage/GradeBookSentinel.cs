using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBookAverage
{
    class GradeBookSentinel
    {
        public string CourseName { get; set; }

        public GradeBookSentinel(string name)
        {
            CourseName = name;
        }

        public void DisplayMessage()
        {
            Console.WriteLine("Welcome to {0}", CourseName); ;
            Console.WriteLine("");
        }

        public void DetermineClassAverage()
        {
            int gradesTotal = 0; //sum of the grades entered by user
            int numOfGrades = 0;// number of the grade to be entered next
            int grade = 0;// grade value entered by the user
            double average;// number with decimal point for average
            int counter = 0;

            // initization phase
            // initialize the total
            // initialize the loop counter

            // processing phase

            //prompt for and read a grade from the user

            Console.Write("Enter grade or -1 to quit: ");
            grade = Convert.ToInt32(Console.ReadLine());
            
            // loop until sentinel value is read from the user
            while (grade != -1)
            {   
               
                
                gradesTotal = gradesTotal + grade;// add the grade to total
                Console.Write("Enter grade or -1 to quit: ");// prompt the user
                grade = Convert.ToInt32(Console.ReadLine());//read the grade
                counter++;
            }

            average = Convert.ToDouble (gradesTotal) / Convert.ToDouble(counter);// integer divison yields integer result
            
            //display total and average of grades
            if (gradesTotal == 0)
            {
                Console.WriteLine("No grades were entered");
            }
            else
            {   Console.WriteLine("Total of the {0} grades entred is {1}",counter, gradesTotal );
                Console.WriteLine("Class average is {0:F}", average);
            }

            //terminate phase

            



        }
    }
}
