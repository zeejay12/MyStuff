using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBookAverage
{
    class GradeBook
    {

        public string CourseName { get; set; }

        public GradeBook (string name)
        {
            CourseName = name;
        }

        public void DisplayMessage()
        {
            Console.WriteLine("Welcome to {0}", CourseName); ;
        }

        public void DetermineClassAverage()
        {
            int gradesTotal = 0; //sum of the grades entered by user
            int numOfGrades = 0;// number of the grade to be entered next
            int grade = 0;// grade value entered by the user
            int average = 0;// average of the grades

            // initization phase
            // initialize the total
            // initialize the loop counter

            // processing phase
            while (numOfGrades <= 10)
            {   //loop 10 times
                Console.Write("Enter grade: ");// prompt the user
                grade = Convert.ToInt32(Console.ReadLine());//read the grade
                gradesTotal = gradesTotal + grade;// add the grade to total
                numOfGrades++; // increment the counter by 1
                
            }

            //terminate phase
            
            average = gradesTotal / numOfGrades;// integer divison yields integer result
            Console.WriteLine("Total of all 10 grades is: {0}", gradesTotal);
            Console.WriteLine("Class average is {0}", average);
            //display total and average of grades



        }
    }
}
