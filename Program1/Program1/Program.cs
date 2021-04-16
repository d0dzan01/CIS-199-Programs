//K4312
//Program1
//September 22, 2019
//CIS 199-02
//This program estimates how many cans of paint you will need to purchase based on wall length, height, number of doors, windows, and how many coats of paint

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Program1
{
    class Program
    {
        static void Main(string[] args)
        {
            double wallLength,                      // Will store the Wall Length
                wallHeight,                         // Will store the Wall Height
                totalGallons;                       // Will be calculated based on user input, says the exact number of gallons needed
            int numDoors,                           // Will store the number of doors
                numWindows,                         // Will store the number of windows
                numCoats,                           // Will store the number of desired coats of paint
                buyGallons;                         // Will be the actual number of gallons that need to be purchased. totalGallons rounded up
            const int doorSize = 21,                // Constant, standard door size
                windowSize = 12;                    // Constant, standard window size
            const double paintCoverage = 400.0;     // Constant, standard paint coverage per gallon of paint

            WriteLine("Welcome to the Handy-Dandy Paint Estimator");
            WriteLine("");
            Write("Enter the total length of all walls (in feet): ");
            wallLength = double.Parse(ReadLine());                              // User input for Wall Length
            Write("Enter the height of all the walls (in feet): ");
            wallHeight = double.Parse(ReadLine());                              // User input for Wall Height
            Write("Enter the number of doors (non-neg int): ");
            numDoors = int.Parse(ReadLine());                                   // User input for Number of Doors
            Write("Enter the number for windows (non-neg int): ");
            numWindows = int.Parse(ReadLine());                                 // User input for Number of Windows
            Write("Enter the number of coats of paint (non-neg int): ");
            numCoats = int.Parse(ReadLine());                                   // User input for Number of Coats of Paint
            WriteLine("");

            totalGallons = (((wallLength * wallHeight) - ((numDoors * doorSize) + (numWindows * windowSize))) * numCoats) / paintCoverage;
            buyGallons = (int)Math.Ceiling(totalGallons);

            WriteLine($"You need a minimum of {totalGallons:F1} gallons of paint");
            WriteLine($"You'll need to buy {buyGallons} gallons, though");

        }
    }
}
