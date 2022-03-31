using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonUsingOOPs 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to line comparison using OOPs");


            CalculateLength calculateLength = new CalculateLength();

            calculateLength.length();

            CheckEquality checkEquality = new CheckEquality();

            checkEquality.Equality();

            GreaterOrLess greaterOrLess = new GreaterOrLess();

            greaterOrLess.Compare();




        }
    }
}