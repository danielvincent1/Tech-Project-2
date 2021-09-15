/*
Daniel Villavicencio
ISM 4300
Due Date: 09/16/21
Description: This app tells the user the letter grade of their expected integer grade
*/

using System;

namespace Tech_Project_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your expected grade for this class?"); // The app first asks the user what grade they expect

            try // a try-catch is used in case the user does not enter an int value
            {
                string input = Console.ReadLine(); // the app takes an input for the user

                int desiredGrade = int.Parse(input); // the input is read as an integer


                if (desiredGrade < 60) // the app starts to go through the conditional statements
                {
                    Console.WriteLine("Your expected grade is a F!"); // the loop stops if the value falls in the parameter and displays the letter grade
                }
                else if (desiredGrade <= 62)
                {
                    Console.WriteLine("Your expected grade is a D-!");
                }
                else if (desiredGrade < 66)
                {
                    Console.WriteLine("Your expected grade is a D!");
                }
                else if (desiredGrade < 70)
                {
                    Console.WriteLine("Your expected grade is a D+!");
                }
                else if (desiredGrade <= 72)
                {
                    Console.WriteLine("Your expected grade is a C-!");
                }
                else if (desiredGrade < 76)
                {
                    Console.WriteLine("Your expected grade is a C!");
                }
                else if (desiredGrade < 79)
                {
                    Console.WriteLine("Your expected grade is a C+!");
                }
                else if (desiredGrade <= 82)
                {
                    Console.WriteLine("Your expected grade is a B-!");
                }
                else if (desiredGrade < 86)
                {
                    Console.WriteLine("Your expected grade is a B!");
                }
                else if (desiredGrade < 90)
                {
                    Console.WriteLine("Your expected grade is a B+!");
                }
                else if (desiredGrade <= 92)
                {
                    Console.WriteLine("Your expected grade is a A-!");
                }
                else // only else if necessary because anything above 92 is an A
                {
                    Console.WriteLine("Your expected grade is a A!");
                }                
            } // end try
            catch (Exception ex) // if the input does not match any of those values, it goes into the catch
            {
                Console.WriteLine(ex.Message); // the system tells the user the input was wrong or what the error is
            } // end catch
        }
    }
}
