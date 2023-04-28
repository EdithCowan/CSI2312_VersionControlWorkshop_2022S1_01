using System;
// CSI2312 - Foundations of Software Engineering
// Version control workshop
//
// A simple program, with a number of placeholder functions that are not implemented
// The project is to be hosted on hithub.
// The goal is to split the students into multiple groups, each will clone the repository, implement one of the functions, test, and commit their changes.
//
// Edith Cowan University, 2022 - Martin Masek
// updated for 2023, S1 - Martin Masek

namespace CSI2312_VersionControlWorkshop
{
    class Program
    {
        static void Task01(int[] data)
        {
            // Zero the list
            for(int i = 0; i < data.Length; i++)
            {
                data[i] = 0;
                // test
            }
        }

        static void Task02(int[] data)
        { 
            // Create random variable
            Random rand = new Random();

            // Randomise list
            for (int i = 0; i < data.Length; i++)
            {
                data[i] =rand.Next(1,100);
            }
        }

        // add further task methods here

        static void Main(string[] args)
        {
            // define some data
            int[] data = { 1, 2, 3, 4, 5, 6 };
            // menu loop

            while (true)
            {
                Console.Clear();
                int index = 0;
                Console.Write("The current data is: [");
                foreach (int x in data)
                {
                    Console.Write(x);
                    index++;
                    if (index < data.Length)
                    {
                        Console.Write(", ");
                    }
                    else
                    {
                        Console.WriteLine("]");
                    }
                    
                }
                Console.WriteLine("=============================");
                Console.WriteLine("Choose and option: ");
                Console.WriteLine("(1) Zero the list");
                Console.WriteLine("(2) Randomise the digits");
                Console.WriteLine("(3) Sort ascending");
                Console.WriteLine("(4) Sort descending");
                Console.WriteLine("(5) Set all to largest");
                Console.WriteLine("(6) Set all to smallest");
                Console.WriteLine("(7) Set all to total");
                Console.WriteLine("(8) Set all to average");
                Console.WriteLine("(9) Square all");
                Console.WriteLine("(10) Add 1 to all");
                Console.WriteLine("(11) Subtract average from all");
                Console.WriteLine("=============================");
                int choice;
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Task01(data);
                        break;
                    case 2:
                        Task02(data);
                        break;
                    default:
                        break;
                }
            }
        }
    }

}
