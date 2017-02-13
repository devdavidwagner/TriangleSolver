using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * DAVID WAGNER
 * ASSIGNMENT 2
 * Simple console program to create a triangle and detect its type
 * 
 * CREATED: 2/13/2017 12:00PM
 * FINISHED: Program.cs and TriangleSolver.cs 
 * 
 * 
 * 
 * */

namespace DWAssignment2PROG2070
{
    class Program
    {
        static void Main(string[] args)
        {

            string choice = "";
            int a, b, c = 0;
            while (true)
            {
                Console.WriteLine("Welcome to the Triangle Solver!\n"
                + "<--------------------------------------->\n" 
                + "1. Enter triangle dimensions\n" 
                + "2. Exit\n"
                 + "<--------------------------------------->\n");

            choice = Console.ReadLine();
          
                if (choice != "1" && choice != "2")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\nPlease choose 1 or 2 \n");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    switch (choice)
                    {

                        case "1":
                            while (true)
                            {
                                Console.WriteLine("Please enter three integers:\n");

                                try
                                {
                                    a = int.Parse(Console.ReadLine());
                                    b = int.Parse(Console.ReadLine());
                                    c = int.Parse(Console.ReadLine());

                                    string message = TriangleSolver.Analyze(a, b, c);

                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine("\n" + message + "\n");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    break;

                                }

                                catch (Exception e)
                                {
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Console.WriteLine("\n!--Please enter a numeric value--!\n");
                                    Console.ForegroundColor = ConsoleColor.White;

                                }
                            }



                            break;

                        case "2":

                            Environment.Exit(0);
                            break;

                        default:

                            break;
                    }



                }
            }
              
            





        }
    }
}
