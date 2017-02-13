using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DWAssignment2PROG2070
{
    class TriangleSolver
    {
      
        /// <summary>
        /// Accepts three integers for triangle sides and returns a string 
        /// </summary>
        /// <param name="a">side 1</param>
        /// <param name="b"> side 2</param>
        /// <param name="c">side 3</param>
        /// <returns>whether integers can return a triangle and what type of triangle it is</returns>
        public static string Analyze(int a, int b, int c)
        {
            string message = "";


            //triangle inequality theorem
            if (a + b > c && a + c > b && b +c > a) 
            {
                if(a == b && a == c && b == c)
                {
                    message = "Your triangle is an equilateral triangle";
                }
                else if (a == b || b == c || a == c)
                {
                    message = "Your triangle is an isosceles triangle";
                }
                else if (a != b && b != c && c != a)
                {
                    message = "Your triangle is a scalene triangle";
                }
            }
            else
            {
                message = "These integers do not form a triangle!";
            }





            return message;



        }


    }
}
