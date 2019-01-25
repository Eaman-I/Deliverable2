using System;

namespace Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask user for input
            Console.WriteLine("Please enter what grade you think you will receive in ISM4300");

            // Use try/catch to validate input and display errors.
            try
            {
                // Variable to gather user input
                string input = Console.ReadLine();
                // Variable used for sales, after parse
                decimal percentGrade = decimal.Parse(input);
                
                    switch (percentGrade) // switch to determine the letter grade and send message to user
                    {
                        case decimal i when (i >= 100):
                            Console.WriteLine("You will receive an Astounding A+!");
                            Console.WriteLine("Press any key to exit the program ...");
                            // pauses program until user presses key
                            Console.ReadKey(true);
                            break;
                        case decimal i when (i <= 97 && i >= 92):
                            Console.WriteLine("You will receive an Amazing A");
                            Console.WriteLine("Press any key to exit the program ...");
                            // pauses program until user presses key
                            Console.ReadKey(true);
                            break;
                        case decimal i when (i <= 91 && i >= 90):
                            Console.WriteLine("You will recieve an A-. Not too shabby");
                            Console.WriteLine("Press any key to exit the program ...");
                            // pauses program until user presses key
                            Console.ReadKey(true);
                            break;
                        case decimal i when (i <= 89 && i >=88):
                            Console.WriteLine("You will recieve a B+.");
                            Console.WriteLine("Press any key to exit the program ...");
                            // pauses program until user presses key
                            Console.ReadKey(true);
                            break;
                        case decimal i when (i <= 87 && i >= 82):
                            Console.WriteLine("You will receive a B.");
                            Console.WriteLine("Press any key to exit the program ...");
                            // pauses program until user presses key
                            Console.ReadKey(true);
                            break;
                        case decimal i when (i <= 81 && i >= 80):
                            Console.WriteLine("You will receive a B-");
                            Console.WriteLine("Press any key to exit the program ...");
                            // pauses program until user presses key
                            Console.ReadKey(true);
                            break;
                        case decimal i when (i <= 79 && i >= 78):
                            Console.WriteLine("You will recieve a C+.");
                            Console.WriteLine("Press any key to exit the program ...");
                            // pauses program until user presses key
                            Console.ReadKey(true);
                            break;
                        case decimal i when (i <= 77 && i >= 72):
                            Console.WriteLine("You will recieve a C.");
                            Console.WriteLine("Press any key to exit the program ...");
                            // pauses program until user presses key
                            Console.ReadKey(true);
                            break;
                        case decimal i when (i <= 71 && i >= 70):
                            Console.WriteLine("You will receive a C-.");
                            Console.WriteLine("Press any key to exit the program ...");
                            // pauses program until user presses key
                            Console.ReadKey(true);
                            break;
                        case decimal i when (i <= 69 && i >= 68):
                            Console.WriteLine("You will receive a D+.");
                            Console.WriteLine("Press any key to exit the program ...");
                            // pauses program until user presses key
                            Console.ReadKey(true);
                            break;
                        case decimal i when (i <= 67 && i >= 62):
                            Console.WriteLine("You will recieve a D.");
                            Console.WriteLine("Press any key to exit the program ...");
                            // pauses program until user presses key
                            Console.ReadKey(true);
                            break;
                        case decimal i when (i <= 61 && i >= 60):
                            Console.WriteLine("You will recieve a D-.");
                            Console.WriteLine("Press any key to exit the program ...");
                            // pauses program until user presses key
                            Console.ReadKey(true);
                            break;
                        case decimal i when (i <= 59 && i >= 0):
                            Console.WriteLine("You will recieve n F.");
                            Console.WriteLine("Press any key to exit the program ...");
                            // pauses program until user presses key
                            Console.ReadKey(true);
                            break;
                    default:
                            Console.WriteLine("Error: Unabale to display letter grade.");
                            Console.WriteLine("Be sure to enter a percentage between 0 and 100.");
                            Console.WriteLine("Press any key to exit the program.");
                            // pauses program until user presses key
                            Console.ReadKey(true);
                            break;
                            // end of switch
                    }
                
                    }
            catch
            {
                Console.WriteLine("Please use a decimal data type for your percent grade");
                Console.WriteLine("Press any key to exit the program and try again...");
                Console.ReadKey(true);
            } // end of catch
        }
            } // end of try

            
        }
    
    

