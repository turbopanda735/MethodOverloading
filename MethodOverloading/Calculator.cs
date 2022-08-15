using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    internal class Calculator
    {
        //Create a method named Add, that accepts two integers 
        //and returns the sum of those two integers
        public static int Add(int x, int y)
        {
            return x + y;
        }
        //create an overload of the Add method to account for
        //being able to add two decimals together
        public static double Add(double x, double y)
        {
            return x + y;
        }
        //create another overload of the
        //Add method that returns a string and accepts 3 parameters:
        //2 integers and 1 boolean
        public static string Add(int x, int y, bool dollars)
        {
            if (dollars == true && (x + y <= 1))
            {
                return (x + y) + " dollar".ToString();
            }
            else if (dollars == true && (x + y > 1))
            {
                return (x + y) + " dollars".ToString();
            }
            else return "you have no money :(";
        }
        //another overload that takes doubles instead of ints, also dollar bool
        public static string Add(double x, double y, bool dollars)
        {
            if (dollars == true && (x + y <= 1))
            {
                return (x + y) + " dollar".ToString();
            }
            else if (dollars == true && (x + y > 1))
            {
                return (x + y) + " dollars".ToString();
            }
            else return "you have no money :(";
        }
    }
}