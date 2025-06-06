﻿using System;
using System.Collections.Immutable;
// CSI2312 - Foundations of Software Engineering
// Version control workshop
//
// A simple program, with a number of placeholder functions that are not implemented
// The project is to be hosted on hithub.
// The goal is to split the students into multiple groups, each will clone the repository, implement one of the functions, test, and commit their changes.
//
// Edith Cowan University, 2022 - Martin Masek
// updated for 2023, S1 - Martin Masek
// updated for 2026, S1 - Martin Masek

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

        // Sort an array in ascending order
        static void Task03(int[] data)
        {
            Array.Sort(data);
        }

        // Sort an array in descending order
        static void Task04(int[] data)
        {
            //bubble sort for descending order
            // loop to compare each array element
            for (int step = 0; step < data.Length - 1; ++step)
            {
                // loop to compare array elements
                for (int i = 0; i < data.Length - step - 1; ++i)
                {
                    // compare two adjacent elements
                    if (data[i] < data[i + 1])
                    {
                        // swapping elements if elements are not in the inteded order
                        int temp = data[i];
                        data[i] = data[i + 1];
                        data[i + 1] = temp;
                    }
                }
            }
        }

        //print something
        static void Task05(int[] data)
        {
            //Find highest - vouk :)
            int largest = data[0];
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > largest)
                {
                    largest = data[i];
                }
            }

            //Set All to largest - vouk 2023 :D
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = largest;
            }
        }
        // add further task methods here
        static void Task11(int[] data)
        {
            // Get average of integers and subtract from each list item
            int sum = 0;

            for (int i = 0; i < data.Length; i++)
            {
                sum += data[i];
            }

            int average = sum / data.Length;

            for (int i = 0; i < data.Length; i++)
            {
                data[i] = data[i] - average;
            }
        }

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
                    case 3:
                        Task03(data);
                        break;
                    case 4:
                        Task04(data);
                        break;
                    case 5: //vouk :P
                        Task05(data);
                        break;
                    case 11:
                        Task11(data);
                        break;
                    default:
                        break;
                }
            }
        }
    }

}
// good afternoon (from semester 1 2023 software engineering) !!!