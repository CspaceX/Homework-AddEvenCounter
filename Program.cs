using System;

namespace OddAndEvenCounter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                int CountEven = 0;
                int CountOdd = 0;
                long SumEven = 0;
                long SumOdd = 0;                
                Console.WriteLine("Enter the lower number:");
                string minValue = Console.ReadLine();
                bool minValueParse = int.TryParse(minValue, out int min);
                Console.WriteLine("Enter the higher number:");
                string maxValue = Console.ReadLine();
                bool maxValueParse = int.TryParse(maxValue, out int max);

                if (minValueParse && maxValueParse)
                {
                    if (min < max)
                    {
                        while (min <= max)
                        {
                            if (min % 2 == 0)
                            {
                                CountEven++;
                                SumEven += min;
                            }
                            else
                            {
                                CountOdd++;
                                SumOdd += min;
                            }

                            min++;
                        }
                        Console.WriteLine($"Count of even: {CountEven}");
                        Console.WriteLine($"Count of odd: {CountOdd}");
                        Console.WriteLine($"Sum of even: {SumEven}");
                        Console.WriteLine($"Sum of odd: {SumOdd}");
                    }
                    else
                    {
                        Console.WriteLine("Incorrect input: lower number must be less than higher");
                    }
                }
                else
                {
                    Console.WriteLine("Incorrect input: you must enter only numbers");
                }
                Console.WriteLine("Press [Enter] to continue");
                Console.WriteLine("Press [E] to exit");
                
                //Exit programm                                 
                string exit = Console.ReadLine();
                Console.Clear();
                if (exit == "E" || exit == "e")
                {
                    break;
                }
                else
                {
                    continue;                              
                }                
            }
        }
    }
}

