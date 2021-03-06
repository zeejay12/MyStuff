﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBookAverage
{
    class GradeBookTest
    {
        static void Main(string[] args)
        {
            GradeBook myGradeBook = new GradeBook("CS101 Introduction to C# Programing");

            myGradeBook.DisplayMessage();
            myGradeBook.DetermineClassAverage();
            Console.WriteLine("");


            Console.WriteLine("==============================================================================\n");

            GradeBookSentinel myGradeBookSent = new GradeBookSentinel("Welcome to Devils Den. The ultimate guide");

            myGradeBookSent.DisplayMessage();
            myGradeBookSent.DetermineClassAverage();

            Console.ReadLine();
        }
    }
}
