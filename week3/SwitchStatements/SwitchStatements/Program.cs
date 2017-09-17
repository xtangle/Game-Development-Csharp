﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchStatements
{
    /// <summary>
    /// Demonstrates the switch statement
    /// </summary>
    class Program
    {
        /// <summary>
        /// Demonstrates the switch statement
        /// </summary>
        /// <param name="args">command-line args</param>
        static void Main(string[] args)
        {
            // ask for and get user answer
            Console.Write("Pick up the shiny thing? (y, n): ");
            char answer = Console.ReadLine()[0];

            // print appropriate message
            switch (answer)
            {
                case 'y':
                case 'Y':
                    Console.WriteLine("You have the shiny thing");
                    break;
                case 'n':
                case 'N':
                    Console.WriteLine("You don't have the shiny thing");
                    break;
                default:
                    Console.WriteLine("You're a n00b");
                    break;
            }

            Console.WriteLine();
        }
    }
}
