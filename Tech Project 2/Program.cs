using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tech_Project_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your expected grade for this class?");

            try
            {
                string input = Console.ReadLine();

                int desiredGrade = int.Parse(input);


                if (desiredGrade < 60)
                {
                    Console.WriteLine("Your expected grade is a F!");
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
                else
                {
                    Console.WriteLine("Your expected grade is a A!");
                }                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
