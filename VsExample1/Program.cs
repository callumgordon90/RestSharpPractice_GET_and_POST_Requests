﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VsExample1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Set up Console UI (CUI)
            ConfigureCUI();

            //Wait for Enter key to be pressed.
            Console.ReadLine();

           
        }

        private static void ConfigureCUI()
        {
            Console.Title = "My Rocking App";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("***********************************");
            Console.WriteLine("**** Welcome to My Rocking App ****");
            Console.WriteLine("***********************************");
            Console.BackgroundColor = ConsoleColor.Black;
        }

    }
}

